using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DnDApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataManager dataManager = new DataManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DnDUnitCalc(dataManager));
        }
    }

    public class DataManager
    {
        public Unit unit;
        public Dictionary<string, Trait> traitsDict = new Dictionary<string, Trait>();
        public Dictionary<string, UnitAncestry> ancestories = new Dictionary<string, UnitAncestry>();
        public Dictionary<string, UnitEquipment> equipment = new Dictionary<string, UnitEquipment>();
        public Dictionary<string, UnitExperience> experiences = new Dictionary<string, UnitExperience>();
        public Dictionary<string, UnitSize> sizes = new Dictionary<string, UnitSize>();
        public Dictionary<string, UnitType> types = new Dictionary<string, UnitType>();
        public DataManager()
        {

        }

        public void makeUnit(string ancestory, string unitEquipment, string experience, string size, string type)
        {
            this.unit = new Unit(
                this.ancestories[ancestory],
                this.types[type],
                this.equipment[unitEquipment],
                this.experiences[experience],
                this.sizes[size]
                );
            unit.totals();
            unit.calc_cost();
        }

        public void addTrait(string name, string desc, int cost)
        {
            Trait trait = new Trait(name, desc, cost);
            this.traitsDict.Add(name, trait);
        }
        public void addAncestory(string name, int attack, int power, int defense, int toughness, int morale, List<string> traits)
        {
            UnitAncestry ancestry = new UnitAncestry(name, attack, power, defense, toughness, morale);
            foreach (string trait in traits)
            {
                ancestry.add_trait(traitsDict[trait]);
            }

            this.ancestories.Add(name, ancestry);
        }
        public void addEquipment(string name, int attack, int power, int defense, int toughness, int morale)
        {
            UnitEquipment unitEquipment = new UnitEquipment(name, attack, power, defense, toughness, morale);
            this.equipment.Add(name, unitEquipment);
        }
        public void addExperience(string name, int attack, int power, int defense, int toughness, int morale)
        {
            UnitExperience experience = new UnitExperience(name, attack, power, defense, toughness, morale);
            this.experiences.Add(name, experience);

        }
        public void addSize(string dice, double mod)
        {
            UnitSize size = new UnitSize(dice, mod);
            this.sizes.Add(dice, size);
        }
        public void addType(string name, int attack, int power, int defense, int toughness, int morale, double mod)
        {
            UnitType unitType = new UnitType(name, attack, power, defense, toughness, morale, mod);
            this.types.Add(name, unitType);
        }
        public void SerializeNow()
        {
            // Serialize the object data to a file
            Stream stream = File.Open("data.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            // Send the object data to the file
            bf.Serialize(stream, new TableWrapper(this.traitsDict, this.ancestories, this.equipment, this.experiences, this.sizes, this.types));
            stream.Close();
        }
        public void DeSerializeNow()
        {
            // Read object data from the file
            Stream stream = File.Open("data.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            TableWrapper w = (TableWrapper)bf.Deserialize(stream);
            stream.Close();

            //Store in local dicts
            this.ancestories = w.ancestories;
            this.traitsDict = w.traitsDict;
            this.equipment = w.equipment;
            this.experiences = w.experiences;
            this.sizes = w.sizes;
            this.types = w.types;
            w = null;
        }
    }

    [Serializable()]
    public class TableWrapper : ISerializable
    {
        public Dictionary<string, Trait> traitsDict;
        public Dictionary<string, UnitAncestry> ancestories;
        public Dictionary<string, UnitEquipment> equipment;
        public Dictionary<string, UnitExperience> experiences;
        public Dictionary<string, UnitSize> sizes;
        public Dictionary<string, UnitType> types;

        public TableWrapper() { }

        public TableWrapper(
            Dictionary<string, Trait> traitsDict,
            Dictionary<string, UnitAncestry> ancestories,
            Dictionary<string, UnitEquipment> equipment,
            Dictionary<string, UnitExperience> experiences,
            Dictionary<string, UnitSize> sizes,
            Dictionary<string, UnitType> types)
        {
            this.traitsDict = traitsDict;
            this.ancestories = ancestories;
            this.equipment = equipment;
            this.experiences = experiences;
            this.sizes = sizes;
            this.types = types;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("traitsDict", this.traitsDict);
            info.AddValue("ancestories", this.ancestories);
            info.AddValue("equipment", this.equipment);
            info.AddValue("experiences", this.experiences);
            info.AddValue("sizes", this.sizes);
            info.AddValue("types", this.types);
        }
        public TableWrapper(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            this.traitsDict = (Dictionary<string, Trait>)info.GetValue("traitsDict", typeof(Dictionary<string, Trait>));
            this.ancestories = (Dictionary<string, UnitAncestry>)info.GetValue("ancestories", typeof(Dictionary<string, UnitAncestry>));
            this.equipment = (Dictionary<string, UnitEquipment>)info.GetValue("equipment", typeof(Dictionary<string, UnitEquipment>));
            this.experiences = (Dictionary<string, UnitExperience>)info.GetValue("experiences", typeof(Dictionary<string, UnitExperience>));
            this.sizes = (Dictionary<string, UnitSize>)info.GetValue("sizes", typeof(Dictionary<string, UnitSize>));
            this.types = (Dictionary<string, UnitType>)info.GetValue("types", typeof(Dictionary<string, UnitType>));
        }
    }
}
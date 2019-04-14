using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DnDApp2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            DataManager dataManager = new DataManager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dataManager.loadDefaultData();
            Application.Run(new DnDUnitCalc(dataManager));
        }
    }

    public class DataManager
    {
        public Unit unit;
        public DataSet1.traitDataTable traitsDict = new DataSet1.traitDataTable();
        public DataSet1.ancestryDataTable ancestories = new DataSet1.ancestryDataTable();
        public DataSet1.equipmentDataTable equipment = new DataSet1.equipmentDataTable();
        public DataSet1.experienceDataTable experiences = new DataSet1.experienceDataTable();
        public DataSet1.typeDataTable types = new DataSet1.typeDataTable();
        public DataSet1.sizeDataTable sizes = new DataSet1.sizeDataTable();

        public void makeUnit(string ancestory, string unitEquipment, string experience, string unitSize, string unitType)
        {

            if (ancestory == null || ancestory == "" ||
                unitType == null || unitType == "" ||
                unitEquipment == null || unitEquipment == "" ||
                experience == null || experience == "" ||
                unitSize == null || unitSize == "")
            {
                return;
            }
            this.unit = new Unit(
                this.ancestories.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == ancestory),
                this.types.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == unitType),
                this.equipment.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == unitEquipment),
                this.experiences.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == experience),
                this.sizes.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("size") == unitSize)
                );
            unit.totals();
            unit.calc_cost();
        }

        public void addTrait(string name, string desc, int cost, bool force = false)
        {
            if (force)
            {
                this.traitsDict.Rows.Remove(
                    this.traitsDict.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == name));
            }
            this.traitsDict.Rows.Add(new object[] { name, desc, cost });
        }
        public void addAncestory(string name, int attack, int power, int defense, int toughness, int morale, List<string> traits, bool force = false)
        {

            if (force)
            {
                this.ancestories.Rows.Remove(
                    this.ancestories.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == name));
            }

            string traitsString = String.Join("\n", traits.ToArray());
            int traitsCost = 0;
            foreach(string trait in traits)
            {
                DataRow row = this.traitsDict.AsEnumerable().SingleOrDefault(r => r.Field<string>("name") == trait);
                traitsCost += Int32.Parse((string)row["cost"]);
            }
            this.ancestories.Rows.Add(new object[] { name, attack, power, defense, toughness, morale, traitsString, traitsCost.ToString()});
        }
        public void addEquipment(string name, int attack, int power, int defense, int toughness, int morale, bool force = false)
        {
            if (force)
            {
                this.equipment.Rows.Remove(
                    this.equipment.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == name));
            }

            this.equipment.Rows.Add(new object[] { name, attack, power, defense, toughness, morale });
        }
        public void addExperience(string name, int attack, int power, int defense, int toughness, int morale, bool force = false)
        {
            if (force)
            {
                this.experiences.Rows.Remove(
                    this.experiences.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == name));
            }

            this.experiences.Rows.Add(new object[] { name, attack, power, defense, toughness, morale });
        }
        public void addSize(string dice, double mod, bool force = false)
        {
            if (force)
            {
                this.sizes.Rows.Remove(
                    this.sizes.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == dice));
            }

            this.sizes.Rows.Add(new object[] { dice, mod });
        }

        internal void generateCard()
        {
            return;
        }

        public void addType(string name, int attack, int power, int defense, int toughness, int morale, double mod, bool force = false)
        {
            if (force)
            {
                this.types.Rows.Remove(
                    this.types.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == name));
            }
            this.types.Rows.Add(new object[] { name, attack, power, defense, toughness, morale, mod });
        }

        public void loadDefaultData()
        {
            string filePath;
            traitsDict = new DataSet1.traitDataTable();
            ancestories = new DataSet1.ancestryDataTable();
            equipment = new DataSet1.equipmentDataTable();
            experiences = new DataSet1.experienceDataTable();
            types = new DataSet1.typeDataTable();
            sizes = new DataSet1.sizeDataTable();

            filePath = "traits_saf.xml";
            traitsDict.ReadXml(filePath);

            filePath = "ancestories_saf.xml";
            ancestories.ReadXml(filePath);

            filePath = "equipment_saf.xml";
            equipment.ReadXml(filePath);

            filePath = "experiences_saf.xml";
            experiences.ReadXml(filePath);

            filePath = "types_saf.xml";
            types.ReadXml(filePath);

            filePath = "sizes_saf.xml";
            sizes.ReadXml(filePath);
        }

        public void SerializeNow(String path)
        {
            BinaryFormatter b = new BinaryFormatter();
            Stream s = File.OpenWrite(path);

            Dictionary<string, string> xmlStringDict = new Dictionary<string, string>();

            StringWriter sw = new StringWriter();

            this.ancestories.WriteXml(sw);
            xmlStringDict.Add("ancestories", sw.ToString());
            sw = new StringWriter();

            this.traitsDict.WriteXml(sw);
            xmlStringDict.Add("traitsDict", sw.ToString());
            sw = new StringWriter();

            this.equipment.WriteXml(sw);
            xmlStringDict.Add("equipment", sw.ToString());
            sw = new StringWriter();

            this.experiences.WriteXml(sw);
            xmlStringDict.Add("experiences", sw.ToString());
            sw = new StringWriter();

            this.types.WriteXml(sw);
            xmlStringDict.Add("types", sw.ToString());
            sw = new StringWriter();

            this.sizes.WriteXml(sw);
            xmlStringDict.Add("sizes", sw.ToString());

            b.Serialize(s, xmlStringDict);
            sw.Close();
            s.Close();
        }
        public void DeSerializeNow(String path)
        {
            traitsDict = new DataSet1.traitDataTable();
            ancestories = new DataSet1.ancestryDataTable();
            equipment = new DataSet1.equipmentDataTable();
            experiences = new DataSet1.experienceDataTable();
            types = new DataSet1.typeDataTable();
            sizes = new DataSet1.sizeDataTable();

            Dictionary<string, string> xmlStringDict;

            FileStream s = new FileStream(path, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            xmlStringDict = (Dictionary<string, string>)b.Deserialize(s);
            StringReader stream;

            stream = new StringReader(xmlStringDict["ancestories"]);
            ancestories.ReadXml(stream);

            stream = new StringReader(xmlStringDict["traitsDict"]);
            traitsDict.ReadXml(stream);

            stream = new StringReader(xmlStringDict["equipment"]);
            equipment.ReadXml(stream);

            stream = new StringReader(xmlStringDict["experiences"]);
            experiences.ReadXml(stream);

            stream = new StringReader(xmlStringDict["types"]);
            types.ReadXml(stream);

            stream = new StringReader(xmlStringDict["sizes"]);
            sizes.ReadXml(stream);

            stream.Close();
            s.Close();
        }
    }
}
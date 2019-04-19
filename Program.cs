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

    /// <summary> 
    /// DataManager an interface and processor of information between gui and model. 
    /// </summary> 
    public class DataManager
    {
        private Unit unit;
        private DataSet1.traitDataTable traitsDict = new DataSet1.traitDataTable();
        private DataSet1.ancestryDataTable ancestories = new DataSet1.ancestryDataTable();
        private DataSet1.equipmentDataTable equipment = new DataSet1.equipmentDataTable();
        private DataSet1.experienceDataTable experiences = new DataSet1.experienceDataTable();
        private DataSet1.typeDataTable types = new DataSet1.typeDataTable();
        private DataSet1.sizeDataTable sizes = new DataSet1.sizeDataTable();
        private DataSet1.unitDataTable units = new DataSet1.unitDataTable();

        /// <summary> 
        /// Generated an object of the Unit type according to input and stores it in a class variable.
        /// Inforation about the unit is retrieved from a set of data tables containing information about its stats.
        /// </summary> 
        /// <param name="unit name"></param> 
        /// <param ancestory="ancestry of the unit"></param> 
        /// <param unitEquipment="equipment of the unit"></param> 
        /// <param experience="experience of the unit"></param> 
        /// <param unitSize="size of the unit"></param> 
        /// <param unitType="type of th unit"></param>
        public void makeUnit(string name = "", string ancestory = "", string unitEquipment = "", string experience = "", string unitSize = "", string unitType = "")
        {

            //Doing some null checks to make sure we don't break anything when we look up the in the data.
            if (ancestory == null || ancestory == "" ||
                unitType == null || unitType == "" ||
                unitEquipment == null || unitEquipment == "" ||
                experience == null || experience == "" ||
                unitSize == null || unitSize == "" ||
                string.IsNullOrEmpty(unitSize))
            {
                return;
            }

            //passing information to the Unit object
            //TODO:
            //Change to dicts for easier reading and getting of vars in the Unit class.

            this.unit = new Unit(
                name, 
                this.ancestories.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == ancestory).ItemArray,
                this.types.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == unitType).ItemArray,
                this.equipment.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == unitEquipment).ItemArray,
                this.experiences.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == experience).ItemArray,
                this.sizes.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("size") == unitSize).ItemArray
                );
            unit.totals();
            unit.calc_cost();
        }

        /// <summary> 
        /// Saves the currently active Unit object to the dataset.
        /// </summary> 
        /// <param force="override?"></param> 
        public void saveUnit(bool force = false)
        {
            if (force)
            {
                this.ancestories.Rows.Remove(
                    this.units.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == this.unit.name));
            }
            this.units.Rows.Add(new object[] { unit.name, unit.ancestryName, unit.equipmentName, unit.experienceName, unit.unitTypeName, unit.size});
        }

        /// <summary> 
        /// Load a Unit object from the dataset and sets it as the currently active Unit object.
        /// </summary> 
        /// <param name="unit name"></param> 
        public void loadUnit(string name)
        {
            DataRow unitRow = this.units.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == name);

            //foreach(object cell in unitRow.ItemArray)
            //    Console.WriteLine(cell.ToString());

            Console.WriteLine("---LOAD UNIT---");
            Console.WriteLine((string)unitRow["name"]);
            Console.WriteLine((string)unitRow["ancestry"]);
            Console.WriteLine((string)unitRow["equipment"]);
            Console.WriteLine((string)unitRow["experience"]);
            Console.WriteLine((string)unitRow["size"]);
            Console.WriteLine((string)unitRow["type"]);
            Console.WriteLine("---LOAD UNIT---");

            this.makeUnit(
                (string)unitRow["name"],
                (string)unitRow["ancestry"], 
                (string)unitRow["equipment"], 
                (string)unitRow["experience"], 
                (string)unitRow["size"],
                (string)unitRow["type"]
                );
        }

        /// <summary> 
        /// Remove currently active Unit from the units dataset.
        /// </summary> 
        public void removeUnit()
        {
            try
            {
                this.units.Rows.Remove(
                    this.units.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == this.unit.name));
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }

        /// <summary> 
        /// Add a trait to the traits dataset.
        /// </summary> 
        /// <param force="override?"></param> 
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

        /// <summary> 
        /// Add a ancestry to the ancestry dataset.
        /// </summary> 
        /// <param force="override?"></param> 
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

        /// <summary> 
        /// Add a equipment to the equipment dataset.
        /// </summary> 
        /// <param force="override?"></param> 
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

        /// <summary> 
        /// Add a experience to the experience dataset.
        /// </summary> 
        /// <param force="override?"></param> 
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

        /// <summary> 
        /// Add a size to the size dataset.
        /// </summary> 
        /// <param force="override?"></param> 
        public void addSize(string dice, double mod, bool force = false)
        {
            if (force)
            {
                this.sizes.Rows.Remove(
                    this.sizes.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("size") == dice));
            }

            this.sizes.Rows.Add(new object[] { dice, mod });
        }

        /// <summary> 
        /// Save an image to a location.
        /// </summary> 
        /// <param force="override?"></param> 
        internal void saveImage(System.Drawing.Bitmap bmp, string path)
        {
            bmp.Save(path);
            return;
        }

        /// <summary> 
        /// Add a type to the type dataset.
        /// </summary> 
        /// <param force="override?"></param> 
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

        /// <summary> 
        /// Loads in defaults from recourses to the dataset upon startup.
        /// </summary> 
        public void loadDefaultData()
        {
            traitsDict = new DataSet1.traitDataTable();
            ancestories = new DataSet1.ancestryDataTable();
            equipment = new DataSet1.equipmentDataTable();
            experiences = new DataSet1.experienceDataTable();
            types = new DataSet1.typeDataTable();
            sizes = new DataSet1.sizeDataTable();

            StringReader stream;

            stream = new StringReader(Properties.Resources.traits_saf);
            traitsDict.ReadXml(stream);

            stream = new StringReader(Properties.Resources.ancestories_saf);
            ancestories.ReadXml(stream);

            stream = new StringReader(Properties.Resources.equipment_saf);
            equipment.ReadXml(stream);

            stream = new StringReader(Properties.Resources.experiences_saf);
            experiences.ReadXml(stream);

            stream = new StringReader(Properties.Resources.types_saf);
            types.ReadXml(stream);

            stream = new StringReader(Properties.Resources.sizes_saf);
            sizes.ReadXml(stream);

            stream.Close();
        }

        /// <summary> 
        /// Converts datasets into xml, stores xml into dicts, serializes dicts into binary and saves this to given location.
        /// </summary> 
        /// <param path="save location"></param> 
        public void exportTables(String path)
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
            sw = new StringWriter();

            b.Serialize(s, xmlStringDict);
            sw.Close();
            s.Close();
        }

        /// <summary> 
        /// Loads binary from path, extracts dictionary with xml strings, loads xml strings into fresh databases.
        /// </summary> 
        /// <param path="import file location"></param>
        /// TODO:
        /// Find a way to reuse stream here it must be possible
        public void importTables(String path)
        {
            traitsDict = new DataSet1.traitDataTable();
            ancestories = new DataSet1.ancestryDataTable();
            equipment = new DataSet1.equipmentDataTable();
            experiences = new DataSet1.experienceDataTable();
            types = new DataSet1.typeDataTable();
            sizes = new DataSet1.sizeDataTable();
            units = new DataSet1.unitDataTable();

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

        /// <summary> 
        /// Exports units dataset to binary and stores at given location.
        /// </summary> 
        /// <param path="save location"></param> 
        public void exportLibrary(string path)
        {
            BinaryFormatter b = new BinaryFormatter();
            Stream s = File.OpenWrite(path);

            Dictionary<string, string> xmlStringDict = new Dictionary<string, string>();

            StringWriter sw = new StringWriter();

            this.units.WriteXml(sw);
            xmlStringDict.Add("units", sw.ToString());

            b.Serialize(s, xmlStringDict);
            sw.Close();
            s.Close();
        }

        /// <summary> 
        /// Imports unit dataset from binary at given location.
        /// </summary> 
        /// <param path="import file location"></param> 
        public void importLibrary(string path)
        {
            units = new DataSet1.unitDataTable();

            Dictionary<string, string> xmlStringDict;

            FileStream s = new FileStream(path, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            xmlStringDict = (Dictionary<string, string>)b.Deserialize(s);
            StringReader stream;

            stream = new StringReader(xmlStringDict["units"]);
            units.ReadXml(stream);

            stream.Close();
            s.Close();
        }

        /// <summary> 
        /// Checks if the currently atctive Unit object is not null
        /// </summary> 
        /// <param force="override?"></param> 
        public bool checkUnit()
        {
            return this.unit != null;
        }

        //Getters for unit info
        public string unitName()
        {
            return this.unit.name;
        }
        public void setUnitName(string name)
        {
            this.unit.name = name;
        }
        public string unitAncestry()
        {
            return this.unit.ancestryName;
        }
        public string unitEquipment()
        {
            return this.unit.equipmentName;
        }
        public string unitExperience()
        {
            return this.unit.experienceName;
        }
        public string unitType()
        {
            return this.unit.unitTypeName;
        }
        public string unitSize()
        {
            return this.unit.size;
        }
        public string unitAttack()
        {
            return this.unit.attack.ToString();
        }
        public string unitPower()
        {
            return this.unit.power.ToString();
        }
        public string unitDefense()
        {
            return (this.unit.defense + 10).ToString();
        }
        public string unitDefenseRaw()
        {
            return this.unit.defense.ToString();
        }
        public string unitToughness()
        {
            return (this.unit.toughness + 10).ToString();
        }
        public string unitToughnessRaw()
        {
            return this.unit.toughness.ToString();
        }        
        public string unitMorale()
        {
            return this.unit.morale.ToString();
        }
        public string unitCost()
        {
            return this.unit.cost.ToString();
        }
        public string[] unitTraits()
        {
            return this.unit.traits;
        }
        public string traitDesc(string name)
        {
            DataRow traitRow = this.traitsDict.AsEnumerable()
                .SingleOrDefault(r => r.Field<string>("name") == name);
            return (string)traitRow["desc"];
        }

        //Getters for data table keys
        public string[] getTraitNames()
        {
            //To lazy to use a normal for loop here.
            string[] traitNames = new string[traitsDict.Count];
            int i = 0;
            foreach (DataRow entry in traitsDict)
            {

                traitNames[i] = ((string)entry["name"]);
                i++;
            }
            return traitNames;
        }
        public string[] getAncestryNames()
        {
            //To lazy to use a normal for loop here.
            string[] names = new string[ancestories.Count];
            int i = 0;
            foreach (DataRow entry in ancestories)
            {

                names[i] = ((string)entry["name"]);
                i++;
            }
            return names;
        }
        public string[] getEquipmentNames()
        {
            //To lazy to use a normal for loop here.
            string[] names = new string[equipment.Count];
            int i = 0;
            foreach (DataRow entry in equipment)
            {

                names[i] = ((string)entry["name"]);
                i++;
            }
            return names;
        }
        public string[] getExperienceNames()
        {
            //To lazy to use a normal for loop here.
            string[] names = new string[experiences.Count];
            int i = 0;
            foreach (DataRow entry in experiences)
            {

                names[i] = ((string)entry["name"]);
                i++;
            }
            return names;
        }
        public string[] getTypeNames()
        {
            //To lazy to use a normal for loop here.
            string[] names = new string[types.Count];
            int i = 0;
            foreach (DataRow entry in types)
            {

                names[i] = ((string)entry["name"]);
                i++;
            }
            return names;
        }
        public string[] getSizeNames()
        {
            //To lazy to use a normal for loop here.
            string[] names = new string[sizes.Count];
            int i = 0;
            foreach (DataRow entry in sizes)
            {

                names[i] = ((string)entry["size"]);
                i++;
            }
            return names;
        }
        public string[] getUnitNames()
        {
            //To lazy to use a normal for loop here.
            string[] names = new string[units.Count];
            int i = 0;
            foreach (DataRow entry in units)
            {

                names[i] = ((string)entry["name"]);
                i++;
            }
            return names;
        }
    }
}
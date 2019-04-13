using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DnDApp2
{

    /// <summary>
    /// Summary description for Class1
    /// </summary>
    [Serializable()]
    public class UnitStats : ISerializable
    {
        public int attack { get; protected set; }
        public int power { get; protected set; }
        public int defense { get; protected set; }
        public int toughness { get; protected set; }
        public int morale { get; protected set; }

        public UnitStats(int attack = 0, int power = 0, int defense = 0, int toughness = 0, int morale = 0)
        {
            this.attack = attack;
            this.power = power;
            this.defense = defense;
            this.toughness = toughness;
            this.morale = morale;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("attack", this.attack);
            info.AddValue("power", this.power);
            info.AddValue("defense", this.defense);
            info.AddValue("toughness", this.toughness);
            info.AddValue("morale", this.morale);
        }
        public UnitStats(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            this.attack = (int)info.GetValue("attack", typeof(int));
            this.attack = (int)info.GetValue("attack", typeof(int));
            this.power = (int)info.GetValue("power", typeof(int));
            this.defense = (int)info.GetValue("defense", typeof(int));
            this.toughness = (int)info.GetValue("toughness", typeof(int));
            this.morale = (int)info.GetValue("morale", typeof(int));
        }
    }

    [Serializable()]
    public class UnitAncestry : UnitStats, ISerializable
    {
        private string ancestry;
        public List<Trait> traits { get; private set; } = new List<Trait>();
        public int trait_cost { get; private set; }

        public UnitAncestry(string ancestry, int attack = 0, int power = 0, int defense = 0, int toughness = 0, int morale = 0) :
            base(attack, power, defense, toughness, morale)
        {

        }

        public void add_trait(Trait trait)
        {
            this.traits.Add(trait);
            this.calc_cost();
        }
        public void remove_trait(Trait trait)
        {
            this.traits.Remove(trait);
            this.calc_cost();
        }
        public void reset_trait()
        {
            this.traits = new List<Trait>();
            this.trait_cost = 0;
        }

        private void calc_cost()
        {
            this.trait_cost = 0;
            foreach (Trait trait in this.traits)
            {
                this.trait_cost += trait.cost;
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            base.GetObjectData(info, context);
            info.AddValue("ancestry", this.ancestry);
            info.AddValue("traits", this.traits);
            info.AddValue("trait_cost", this.trait_cost);
        }
        public UnitAncestry(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
        {
            //Get the values from info and assign them to the properties
            this.ancestry = (string)info.GetValue("ancestry", typeof(string));
            this.traits = (List<Trait>)info.GetValue("traits", typeof(List<Trait>));
            this.trait_cost = (int)info.GetValue("trait_cost", typeof(int));
        }
    }

    [Serializable()]
    public class Trait : ISerializable
    {
        public string name { get; private set; }
        public string desc { get; private set; }
        public int cost { get; private set; }
        public Trait(string name = "", string desc = "", int cost = 0)
        {
            this.name = name;
            this.desc = desc;
            this.cost = cost;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("name", this.name);
            info.AddValue("desc", this.desc);
            info.AddValue("cost", this.cost);
        }
        public Trait(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            this.name = (string)info.GetValue("name", typeof(string));
            this.desc = (string)info.GetValue("desc", typeof(string));
            this.cost = (int)info.GetValue("cost", typeof(int));
        }
    }

    [Serializable()]
    public class UnitExperience : UnitStats, ISerializable
    {
        public string level { get; private set; }
        public UnitExperience(string level = "", int attack = 0, int power = 0, int defense = 0, int toughness = 0, int morale = 0) :
            base(attack, power, defense, toughness, morale)
        {
            this.level = level;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            base.GetObjectData(info, context);
            info.AddValue("level", this.level);
        }
        public UnitExperience(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
        {
            //Get the values from info and assign them to the properties
            this.level = (string)info.GetValue("level", typeof(string));
        }
    }

    [Serializable()]
    public class UnitType : UnitStats, ISerializable
    {
        private string unit_type;
        public double mod { get; private set; }

        public UnitType(string unit_type = "", int attack = 0, int power = 0, int defense = 0, int toughness = 0, int morale = 0, double mod = 0) :
            base(attack, power, defense, toughness, morale)
        {
            this.unit_type = unit_type;
            this.mod = mod;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            base.GetObjectData(info, context);
            info.AddValue("unit_type", this.unit_type);
            info.AddValue("mod", this.mod);
        }
        public UnitType(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
        {
            //Get the values from info and assign them to the properties
            this.unit_type = (string)info.GetValue("unit_type", typeof(string));
            this.mod = (double)info.GetValue("mod", typeof(double));
        }
    }

    [Serializable()]
    public class UnitEquipment : UnitStats, ISerializable
    {
        public string level { get; private set; }
        public UnitEquipment(string level = "", int attack = 0, int power = 0, int defense = 0, int toughness = 0, int morale = 0) :
            base(attack, power, defense, toughness, morale)
        {
            this.level = level;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            base.GetObjectData(info, context);
            info.AddValue("level", this.level);
        }
        public UnitEquipment(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
        {
            //Get the values from info and assign them to the properties
            this.level = (string)info.GetValue("level", typeof(string));
        }
    }

    [Serializable()]
    public class UnitSize : ISerializable
    {
        public string dice { get; private set; } = "1d4";
        public double mod { get; private set; }
        public UnitSize(string dice, double mod)
        {
            this.dice = dice;
            this.mod = mod;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("dice", this.dice);
            info.AddValue("mod", this.mod);
        }
        public UnitSize(SerializationInfo info, StreamingContext ctxt) 
        {
            //Get the values from info and assign them to the properties
            this.dice = (string)info.GetValue("dice", typeof(string));
            this.mod = (double)info.GetValue("mod", typeof(double));

        }
    }

    public class Unit
    {
        private UnitAncestry ancestry;
        private UnitType unitType;
        private UnitEquipment equipment;
        private UnitExperience experience;
        private UnitSize unitSize;
        public int attack { get; private set; }
        public int power { get; private set; }
        public int defense { get; private set; }
        public int toughness { get; private set; }
        public int morale { get; private set; }
        public string size { get; private set; }
        private int trait_cost { get; set; }
        public List<string> traits { get; private set; } = new List<string>();
        public double cost { get; private set; }

        private double cost_mod;

        public Unit(UnitAncestry ancestry, UnitType unitType, UnitEquipment equipment, UnitExperience experience, UnitSize unitSize)
        {
            this.ancestry = ancestry;
            this.unitType = unitType;
            this.equipment = equipment;
            this.experience = experience;
            this.unitSize = unitSize;
            this.size = unitSize.dice.ToString();
            foreach(Trait trait in this.ancestry.traits)
            {
                this.traits.Add(trait.name);
            }
        }

        public void totals()
        {
            this.attack = this.ancestry.attack + this.experience.attack + this.equipment.attack + this.unitType.attack;
            this.power = this.ancestry.power + this.experience.power + this.equipment.power + this.unitType.power;
            this.defense = this.ancestry.defense + this.experience.defense + this.equipment.defense + this.unitType.defense;
            this.toughness = this.ancestry.toughness + this.experience.toughness + this.equipment.toughness + this.unitType.toughness;
            this.morale = this.ancestry.morale + this.experience.morale + this.equipment.morale + this.unitType.morale;
            this.trait_cost = this.ancestry.trait_cost;
            this.cost_mod = this.unitSize.mod * this.unitType.mod;
        }
        public void calc_cost()
        {
            double total = (this.attack + this.defense + this.power + this.toughness) + 2 * this.morale;
            total = total * this.cost_mod * 10;
            total += this.trait_cost + 30;
            this.cost = total;
        }
    }
}
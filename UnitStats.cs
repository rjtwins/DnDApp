using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;

namespace DnDApp2
{
    public class Unit
    {
        private DataRow ancestry;
        private DataRow unitType;
        private DataRow equipment;
        private DataRow experience;
        private DataRow unitSize;
        public string ancestryName { get; private set; }
        public string unitTypeName { get; private set; }
        public string equipmentName { get; private set; }
        public string experienceName { get; private set; }
        public int attack { get; private set; } = 0;
        public int power { get; private set; } = 0;
        public int defense { get; private set; } = 0;
        public int toughness { get; private set; } = 0;
        public int morale { get; private set; } = 0;
        public string size { get; private set; } = "";
        private int trait_cost { get; set; } = 0;
        public string[] traits { get; private set; }
        public double cost { get; private set; } = 0;
        private double cost_mod;

        public Unit(DataRow ancestry, DataRow unitType, DataRow equipment, DataRow experience, DataRow unitSize)
        {

            this.ancestry = ancestry;
            this.unitType = unitType;
            this.equipment = equipment;
            this.experience = experience;
            this.unitSize = unitSize;
            this.size = (string)unitSize["size"];
            string traitsString = (string)ancestry["traits"];
            this.traits = traitsString.Split('\n');

            this.ancestryName = (string)ancestry["name"];
            this.unitTypeName = (string)unitType["name"];
            this.equipmentName = (string)equipment["name"];
            this.experienceName = (string)experience["name"];
        }

        public void totals()
        {
            this.attack = Int32.Parse((string)this.ancestry["attack"]) + 
                Int32.Parse((string)this.experience["attack"]) + 
                Int32.Parse((string)this.equipment["attack"]) + 
                Int32.Parse((string)this.unitType["attack"]);

            this.power = Int32.Parse((string)this.ancestry["power"]) +
                Int32.Parse((string)this.experience["power"]) +
                Int32.Parse((string)this.equipment["power"]) +
                Int32.Parse((string)this.unitType["power"]);

            this.defense = Int32.Parse((string)this.ancestry["defense"]) +
                Int32.Parse((string)this.experience["defense"]) +
                Int32.Parse((string)this.equipment["defense"]) +
                Int32.Parse((string)this.unitType["defense"]);

            this.toughness = Int32.Parse((string)this.ancestry["toughness"]) +
                Int32.Parse((string)this.experience["toughness"]) +
                Int32.Parse((string)this.equipment["toughness"]) +
                Int32.Parse((string)this.unitType["toughness"]);

            this.morale = Int32.Parse((string)this.ancestry["morale"]) +
                Int32.Parse((string)this.experience["morale"]) +
                Int32.Parse((string)this.equipment["morale"]) +
                Int32.Parse((string)this.unitType["morale"]);

            this.morale = Int32.Parse((string)this.ancestry["morale"]) +
                Int32.Parse((string)this.experience["morale"]) +
                Int32.Parse((string)this.equipment["morale"]) +
                Int32.Parse((string)this.unitType["morale"]);

            this.trait_cost = Int32.Parse((string)this.ancestry["traitsCost"]);
            this.cost_mod = (Double.Parse((string)this.unitSize["costmod"])/100) * (Double.Parse((string)this.unitType["costmod"])/100);
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
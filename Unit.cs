using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;

namespace DnDApp2
{

    /// <summary> 
    /// Unit class, represenation of a Unit, calculates costs internally
    /// </summary> 
    /// TODO:
    /// Change some vars to setters and getters with logic.
    public class Unit
    {
        private object[] ancestry;
        private object[] unitType;
        private object[] equipment;
        private object[] experience;
        private object[] unitSize;
        public string name { get; set; }
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

        /// <summary> 
        /// Constructor takes object arrays with information about units. 
        /// </summary> 
        /// <param name="unit name"></param> 
        /// <param ancestry="array with unit ancestry object"></param> 
        /// <param unitType="array with unit type objects"></param> 
        /// <param equipment="array with unit equipment objects"></param> 
        /// <param experience="array with unit experience object"></param> 
        /// <param unitSize="array with unit size objects"></param> 
        public Unit(string name, object[] ancestry, object[] unitType, object[] equipment, object[] experience, object[] unitSize)
        {
            this.name = name;
            this.ancestry = ancestry;
            this.unitType = unitType;
            this.equipment = equipment;
            this.experience = experience;
            this.unitSize = unitSize;
            this.size = (string)unitSize[0];
            string traitsString = (string)ancestry[6];
            this.traits = traitsString.Split('\n');

            this.ancestryName = (string)ancestry[0];
            this.unitTypeName = (string)unitType[0];
            this.equipmentName = (string)equipment[0];
            this.experienceName = (string)experience[0];
        }


        /// <summary> 
        /// Calculates totals of unit stats.
        /// </summary> 
        public void totals()
        {
            this.attack = Int32.Parse((string)this.ancestry[1]) + 
                Int32.Parse((string)this.experience[1]) + 
                Int32.Parse((string)this.equipment[1]) + 
                Int32.Parse((string)this.unitType[1]);

            this.power = Int32.Parse((string)this.ancestry[2]) +
                Int32.Parse((string)this.experience[2]) +
                Int32.Parse((string)this.equipment[2]) +
                Int32.Parse((string)this.unitType[2]);

            this.defense = Int32.Parse((string)this.ancestry[3]) +
                Int32.Parse((string)this.experience[3]) +
                Int32.Parse((string)this.equipment[3]) +
                Int32.Parse((string)this.unitType[3]);

            this.toughness = Int32.Parse((string)this.ancestry[4]) +
                Int32.Parse((string)this.experience[4]) +
                Int32.Parse((string)this.equipment[4]) +
                Int32.Parse((string)this.unitType[4]);

            this.morale = Int32.Parse((string)this.ancestry[5]) +
                Int32.Parse((string)this.experience[5]) +
                Int32.Parse((string)this.equipment[5]) +
                Int32.Parse((string)this.unitType[5]);


            this.trait_cost = Int32.Parse((string)this.ancestry[7]);
            this.cost_mod = (Double.Parse((string)this.unitSize[1])/100) * (Double.Parse((string)this.unitType[6])/100);
        }

        /// <summary> 
        /// calculate total cost of unit based on stats and traits.
        /// </summary> 
        public void calc_cost()
        {
            double total = (this.attack + this.defense + this.power + this.toughness) + this.morale*2;
            total = Math.Max(total, 0) * this.cost_mod * 10;
            total += this.trait_cost + 30;
            this.cost = total;
        }
    }
}
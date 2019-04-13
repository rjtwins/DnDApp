using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DnDApp2
{
    public partial class DnDUnitCalc : Form
    {
        private DataManager dataManager;

        public DnDUnitCalc(DataManager dataManager)
        {
            this.dataManager = dataManager;
            InitializeComponent();
        }

        public void updateBoxes()
        {
            this.ancestryBox.Items.Clear();
            this.equipmentBox.Items.Clear();
            this.experienceBox.Items.Clear();
            this.typeBox.Items.Clear();
            this.sizeBox.Items.Clear();
            foreach (KeyValuePair<string, UnitAncestry> entry in dataManager.ancestories)
            {
                this.ancestryBox.Items.Add(entry.Key);
            }
            foreach (KeyValuePair<string, UnitEquipment> entry in dataManager.equipment)
            {
                this.equipmentBox.Items.Add(entry.Key);
            }
            foreach (KeyValuePair<string, UnitExperience> entry in dataManager.experiences)
            {
                this.experienceBox.Items.Add(entry.Key);
            }
            foreach (KeyValuePair<string, UnitType> entry in dataManager.types)
            {
                this.typeBox.Items.Add(entry.Key);
            }
            foreach (KeyValuePair<string, UnitSize> entry in dataManager.sizes)
            {
                this.sizeBox.Items.Add(entry.Key);
            }
        }

        private void AncestryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AncestryAdd dialog = new AncestryAdd(dataManager, this);
            dialog.ShowDialog();
        }

        private void TraidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraitAdd dialog = new TraitAdd(dataManager, this);
            dialog.ShowDialog();
        }

        private void ExperienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpAdd expAdd = new ExpAdd(dataManager, this);
            expAdd.ShowDialog();
        }

        private void EquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipAdd equipAdd = new EquipAdd(dataManager, this);
            equipAdd.ShowDialog();
        }

        private void TypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeAdd typeAdd = new TypeAdd(dataManager, this);
            typeAdd.ShowDialog();
        }

        private void SizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeAdd sizeAdd = new SizeAdd(dataManager, this);
            sizeAdd.ShowDialog();
        }

        private void updateOutput(object sender, EventArgs e)
        {
            try
            {
                dataManager.makeUnit(this.ancestryBox.Text, this.equipmentBox.Text, this.experienceBox.Text, this.sizeBox.Text, this.typeBox.Text);
            }
            catch (KeyNotFoundException)
            {
                return;
            }
            this.attacko.Text = dataManager.unit.attack.ToString();
            this.powero.Text = dataManager.unit.power.ToString();
            this.defenseo.Text = dataManager.unit.defense.ToString();
            this.toughnesso.Text = dataManager.unit.toughness.ToString();
            this.moraleo.Text = dataManager.unit.morale.ToString();
            this.sizeo.Text = dataManager.unit.size.ToString();
            this.costo.Text = dataManager.unit.cost.ToString();
            this.traitsOutput.Items.Clear();
            foreach (string trait in dataManager.unit.traits)
            {
                this.traitsOutput.Items.Add(trait);
            }
        }

        private void ExportTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataManager.SerializeNow();
        }

        private void ImportTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataManager.DeSerializeNow();
            this.updateBoxes();
            updateOutput(null, null);
        }
    }
}
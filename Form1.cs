using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            updateBoxes();
        }

        public void updateBoxes()
        {
            this.ancestryBox.Items.Clear();
            this.equipmentBox.Items.Clear();
            this.experienceBox.Items.Clear();
            this.typeBox.Items.Clear();
            this.sizeBox.Items.Clear();
            foreach (DataRow entry in dataManager.ancestories)
            {
                this.ancestryBox.Items.Add((string)entry["name"]);
            }
            foreach (DataRow entry in dataManager.equipment)
            {
                this.equipmentBox.Items.Add((string)entry["name"]);
            }
            foreach (DataRow entry in dataManager.experiences)
            {
                this.experienceBox.Items.Add((string)entry["name"]);
            }
            foreach (DataRow entry in dataManager.types)
            {
                this.typeBox.Items.Add((string)entry["name"]);
            }
            foreach (DataRow entry in dataManager.sizes)
            {
                this.sizeBox.Items.Add((string)entry["size"]);
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

            dataManager.makeUnit(this.ancestryBox.Text, this.equipmentBox.Text, this.experienceBox.Text, this.sizeBox.Text, this.typeBox.Text);
            if (dataManager.unit == null)
                return;

            this.cardName.Text = String.Format("{0} {1} {2} {3}", 
            dataManager.unit.experienceName, 
            dataManager.unit.equipmentName, 
            dataManager.unit.ancestryName, 
            dataManager.unit.unitTypeName);
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
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "data file|*.dat";
            saveFileDialog1.Title = "Save unit atributes.";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                dataManager.SerializeNow(saveFileDialog1.FileName);
            }
        }

        private void ImportTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "WARNING";
            string caption = "Importing will override any unsaved data, continue?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show(caption, message, buttons) == System.Windows.Forms.DialogResult.No)
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "data files|*.dat";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;
                dataManager.DeSerializeNow(filePath);
            }
            this.updateBoxes();
            updateOutput(null, null);
        }

        private void TraitsOutput_DoubleClick(object sender, EventArgs e)
        {
            if (this.traitsOutput.SelectedItem != null)
            {
                string selected = this.traitsOutput.SelectedItem.ToString();
                DataRow trait = this.dataManager.traitsDict.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == selected);

                string desc = (string)trait["desc"];
                MessageBox.Show(desc, selected);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataManager.generateCard();
        }
    }
}
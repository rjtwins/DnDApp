using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            this.unitLibraryBox.Items.Clear();
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
            foreach (DataRow entry in dataManager.units)
            {
                this.unitLibraryBox.Items.Add((string)entry["name"]);
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

            dataManager.makeUnit(this.nameInputBox.Text, this.ancestryBox.Text, this.equipmentBox.Text, this.experienceBox.Text, this.sizeBox.Text, this.typeBox.Text);
            if (dataManager.unit == null)
                return;

            this.nameInputBox.Text = dataManager.unit.name;
            this.cardName.Text = String.Format("{0} {1} {2} {3}", 
            dataManager.unit.experienceName,
            dataManager.unit.equipmentName,
            dataManager.unit.ancestryName,
            dataManager.unit.unitTypeName);
            this.attacko.Text = dataManager.unit.attack.ToString();
            this.powero.Text = dataManager.unit.power.ToString();
            this.defenseo.Text = (Int32.Parse(dataManager.unit.defense.ToString()) + 10).ToString();
            this.toughnesso.Text = (Int32.Parse(dataManager.unit.toughness.ToString()) + 10).ToString();
            this.moraleo.Text = dataManager.unit.morale.ToString();
            this.sizeo.Text = dataManager.unit.size.ToString();
            this.costo.Text = dataManager.unit.cost.ToString();
            this.traitsOutputText.Text = "";
            string traitsText = "";
            foreach (string trait in dataManager.unit.traits)
            {
                DataRow traitRow = this.dataManager.traitsDict.AsEnumerable()
                    .SingleOrDefault(r => r.Field<string>("name") == trait);

                if (traitRow == null)
                    return;

                traitsText +=  trait + "\n" + (string)traitRow["desc"] + "\n\n";
            }
            this.traitsOutputText.Text = traitsText;
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
                dataManager.exportTables(saveFileDialog1.FileName);

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
                dataManager.importTables(filePath);
            }
            this.updateBoxes();
            updateOutput(null, null);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = this.panel1;
            var bmp = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "png|*.png";
            saveFileDialog1.Title = "Save card as PNG";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                string filePath = saveFileDialog1.FileName;
                dataManager.generateCard(bmp, filePath);
            }
        }

        private void AncestryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOutput(sender, e);
        }

        private void EquipmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOutput(sender, e);
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOutput(sender, e);
        }

        private void ExperienceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOutput(sender, e);
        }

        private void SizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOutput(sender, e);
        }

        private void SaveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "unit library files|*.ulib";
            saveFileDialog1.Title = "Save unit card library.";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                dataManager.exportLibrary(saveFileDialog1.FileName);

            }
        }

        private void UnitLibraryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataManager.loadUnit((string)this.unitLibraryBox.Text);
            this.ancestryBox.SelectedIndex = this.ancestryBox.FindStringExact(dataManager.unit.ancestryName);
            this.equipmentBox.SelectedIndex = this.equipmentBox.FindStringExact(dataManager.unit.equipmentName);
            this.experienceBox.SelectedIndex = this.experienceBox.FindStringExact(dataManager.unit.experienceName);
            this.typeBox.SelectedIndex = this.typeBox.FindStringExact(dataManager.unit.unitTypeName);
            this.sizeBox.SelectedIndex = this.sizeBox.FindStringExact(dataManager.unit.size);
            //I realzize we are making a unit we just made in the update output but I'm to lazy to change this.
            updateOutput(sender, e);
        }

        private void SaveUnitButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataManager.unit.name = (string)this.nameInputBox.Text;
                this.dataManager.saveUnit();
                this.updateBoxes();
            }
            catch (ConstraintException)
            {
                string message = "Allready excists.";
                string caption = "Please remove unit first or choose a different name.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(caption, message, buttons);
            }
        }

        private void RemoveUnit_Click(object sender, EventArgs e)
        {
            this.dataManager.removeUnit();
            this.updateBoxes();
        }

        private void LoadLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "WARNING";
            string caption = "Importing will override any unsaved data, continue?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show(caption, message, buttons) == System.Windows.Forms.DialogResult.No)
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "unit library files|*.ulib";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = openFileDialog.FileName;
                dataManager.importLibrary(filePath);
            }
            this.updateBoxes();
            updateOutput(null, null);
        }
    }
}
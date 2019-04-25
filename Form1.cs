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
            foreach (string entry in dataManager.getAncestryNames())
            {
                this.ancestryBox.Items.Add(entry);
            }
            foreach (string entry in dataManager.getEquipmentNames())
            {
                this.equipmentBox.Items.Add(entry);
            }
            foreach (string entry in dataManager.getExperienceNames())
            {
                this.experienceBox.Items.Add(entry);
            }
            foreach (string entry in dataManager.getTypeNames())
            {
                this.typeBox.Items.Add(entry);
            }
            foreach (string entry in dataManager.getSizeNames())
            {
                this.sizeBox.Items.Add(entry);
            }
            foreach (string entry in dataManager.getUnitNames())
            {
                this.unitLibraryBox.Items.Add(entry);
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
            if (dataManager.checkUnit() == false)
                return;

            this.nameInputBox.Text = dataManager.unitName();
            this.cardName.Text = String.Format("{0} {1} {2} {3}", 
            dataManager.unitAncestry(),
            dataManager.unitEquipment(),
            dataManager.unitExperience(),
            dataManager.unitType());
            this.attacko.Text = dataManager.unitAttack();
            this.powero.Text = dataManager.unitPower();
            this.defenseo.Text = dataManager.unitDefense();
            this.toughnesso.Text = dataManager.unitToughness();
            this.moraleo.Text = dataManager.unitMorale();
            this.sizeo.Text = dataManager.unitSize();
            this.costo.Text = dataManager.unitCost();
            this.traitsOutputText.Text = "";
            string traitsText = "";
            foreach (string trait in dataManager.unitTraits())
            {
                if (trait == null || trait == "")
                    break;
                traitsText +=  trait + "\n" + dataManager.traitDesc(trait) + "\n\n";
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
                dataManager.saveImage(bmp, filePath);
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
            this.ancestryBox.SelectedIndex = this.ancestryBox.FindStringExact(dataManager.unitAncestry());
            this.equipmentBox.SelectedIndex = this.equipmentBox.FindStringExact(dataManager.unitEquipment());
            this.experienceBox.SelectedIndex = this.experienceBox.FindStringExact(dataManager.unitExperience());
            this.typeBox.SelectedIndex = this.typeBox.FindStringExact(dataManager.unitType());
            this.sizeBox.SelectedIndex = this.sizeBox.FindStringExact(dataManager.unitSize());
            //I realzize we are making a unit we just made in the update output but I'm to lazy to change this.
            updateOutput(sender, e);
        }

        private void SaveUnitButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataManager.setUnitName((string)this.nameInputBox.Text);
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
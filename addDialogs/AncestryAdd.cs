using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DnDApp2
{
    public partial class AncestryAdd : Form
    {
        private DataManager dataManager;
        private DnDUnitCalc caller;
        public AncestryAdd(DataManager dataManager, DnDUnitCalc caller)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            foreach (string entry in dataManager.getTraitNames())
            {
                this.traitscbox.Items.Add(entry);
            }
            this.caller = caller;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            List<string> traits = new List<string>();
            foreach (var item in this.traitsdisplay.Items)
            {
                traits.Add(item.ToString());
            }
            try
            {
                dataManager.addAncestory(this.name.Text,
            Int32.Parse(this.attack.Text),
            Int32.Parse(this.power.Text),
            Int32.Parse(this.defense.Text),
            Int32.Parse(this.toughness.Text),
            Int32.Parse(this.morale.Text),
            traits);
            }
            catch (System.Data.ConstraintException)
            {
                string message = "Allready excists.";
                string caption = "Would you like to override?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(caption, message, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    dataManager.addAncestory(this.name.Text,
                        Int32.Parse(this.attack.Text),
                        Int32.Parse(this.power.Text),
                        Int32.Parse(this.defense.Text),
                        Int32.Parse(this.toughness.Text),
                        Int32.Parse(this.morale.Text),
                        traits, true);
                }
            }
            this.caller.updateBoxes();

        }

        private void AddTrait_Click(object sender, EventArgs e)
        {
            this.traitsdisplay.Items.Add(this.traitscbox.SelectedItem);
        }

        private void RemoveTrait_Click(object sender, EventArgs e)
        {
            this.traitsdisplay.Items.Remove(this.traitsdisplay.SelectedItem);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
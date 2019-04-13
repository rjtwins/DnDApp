using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (KeyValuePair<string, Trait> entry in dataManager.traitsDict)
            {
                this.traitscbox.Items.Add(entry.Key);
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
            dataManager.addAncestory(this.name.Text,
                Int32.Parse(this.attack.Text),
                Int32.Parse(this.power.Text),
                Int32.Parse(this.defense.Text),
                Int32.Parse(this.toughness.Text),
                Int32.Parse(this.morale.Text),
                traits);
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

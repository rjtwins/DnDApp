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
    public partial class EquipAdd: Form
    {
        private DataManager dataManager;
        private DnDUnitCalc caller;
        public EquipAdd(DataManager dataManager, DnDUnitCalc caller)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            this.caller = caller;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                dataManager.addEquipment(this.name.Text,
            Int32.Parse(this.attack.Text),
            Int32.Parse(this.power.Text),
            Int32.Parse(this.defense.Text),
            Int32.Parse(this.toughness.Text),
            Int32.Parse(this.morale.Text));
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
                    dataManager.addEquipment(this.name.Text,
                    Int32.Parse(this.attack.Text),
                    Int32.Parse(this.power.Text),
                    Int32.Parse(this.defense.Text),
                    Int32.Parse(this.toughness.Text),
                    Int32.Parse(this.morale.Text), true);
                }
            }

            caller.updateBoxes();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class TraitAdd : Form
    {
        private DataManager dataManager;
        private DnDUnitCalc caller;
        public TraitAdd(DataManager dataManager, DnDUnitCalc caller)
        {
            this.caller = caller;
            InitializeComponent();
            this.dataManager = dataManager;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataManager.addTrait(this.name.Text, this.descBox.Text, Int32.Parse(this.cost.Text));

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
                    this.dataManager.addTrait(this.name.Text, this.descBox.Text, Int32.Parse(this.cost.Text), true);
                }
            }

            this.caller.updateBoxes();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

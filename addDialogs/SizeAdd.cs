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
    public partial class SizeAdd : Form
    {
        private DataManager dataManager;
        private DnDUnitCalc caller;
        public SizeAdd(DataManager dataManager, DnDUnitCalc caller)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            this.caller = caller;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string costmod = this.costMod.Text.Replace(',', '.');
            string dice = this.befored.Text + 'd' + this.afterd.Text;
            try
            {
                dataManager.addSize(dice, Double.Parse(costmod));
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
                    dataManager.addSize(dice, Double.Parse(costmod), true);
                }
            }
            this.caller.updateBoxes();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

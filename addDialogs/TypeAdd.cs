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
    public partial class TypeAdd : Form
    {
        private DataManager dataManager;
        private DnDUnitCalc caller;
        public TypeAdd(DataManager dataManager, DnDUnitCalc caller)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            this.caller = caller;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Grose c# why you do this to me
            string costmod = this.costMod.Text.Replace(',', '.');

            try
            {
                dataManager.addType(this.name.Text,
            Int32.Parse(this.attack.Text),
            Int32.Parse(this.power.Text),
            Int32.Parse(this.defense.Text),
            Int32.Parse(this.toughness.Text),
            Int32.Parse(this.morale.Text),
            Double.Parse(costmod));
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
                    dataManager.addType(this.name.Text,
                        Int32.Parse(this.attack.Text),
                        Int32.Parse(this.power.Text),
                        Int32.Parse(this.defense.Text),
                        Int32.Parse(this.toughness.Text),
                        Int32.Parse(this.morale.Text),
                        Double.Parse(costmod), true);
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

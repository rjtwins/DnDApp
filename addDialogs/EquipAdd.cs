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
            dataManager.addEquipment(this.name.Text,
                Int32.Parse(this.attack.Text),
                Int32.Parse(this.power.Text),
                Int32.Parse(this.defense.Text),
                Int32.Parse(this.toughness.Text),
                Int32.Parse(this.morale.Text));
            caller.updateBoxes();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

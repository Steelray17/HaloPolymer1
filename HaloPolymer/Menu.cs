using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloPolymer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenCeh_Click(object sender, EventArgs e)
        {
            Form formCeh = new FormCeh();
            formCeh.Show();
        }

        private void buttonOpenASYTP_Click(object sender, EventArgs e)
        {
            Form formASYTP = new FormASYTP();
            formASYTP.Show();
        }

        private void buttonOpenEquipment_Click(object sender, EventArgs e)
        {
            Form formEquipment = new FormEquipment();
            formEquipment.Show();
        }

        private void buttonOpenDB_Click(object sender, EventArgs e)
        {
            Form formDB = new FormDB();
            formDB.Show();
        }
    }
}

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
    public partial class FormASYTP : Form
    {
        public FormASYTP()
        {
            InitializeComponent();
            ShowASYTP();
        }

        void ShowASYTP()
        {
            listViewASYTP.Items.Clear();
            foreach (ASYTP asytpSet in Program.HaloPolymer.ASYTP)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        asytpSet.Name_ASYTP
                    });
                item.Tag = asytpSet;
                listViewASYTP.Items.Add(item);
            }
            listViewASYTP.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ASYTP asytpSet = new ASYTP();
            asytpSet.Name_ASYTP = textBoxASYTP.Text;
            Program.HaloPolymer.ASYTP.Add(asytpSet);
            Program.HaloPolymer.SaveChanges();
            ShowASYTP();
        }

        private void listViewASYTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewASYTP.SelectedItems.Count == 1)
            {
                ASYTP asytpSet = listViewASYTP.SelectedItems[0].Tag as ASYTP;
                textBoxASYTP.Text = asytpSet.Name_ASYTP;
            }
            else
            {
                textBoxASYTP.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewASYTP.SelectedItems.Count == 1)
            {
                ASYTP asytpSet = listViewASYTP.SelectedItems[0].Tag as ASYTP;
                asytpSet.Name_ASYTP = textBoxASYTP.Text;
                Program.HaloPolymer.SaveChanges();
                ShowASYTP();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewASYTP.SelectedItems.Count == 1)
                {
                    ASYTP asytpSet = listViewASYTP.SelectedItems[0].Tag as ASYTP;
                    Program.HaloPolymer.ASYTP.Remove(asytpSet);
                    Program.HaloPolymer.SaveChanges();
                    ShowASYTP();
                }
                textBoxASYTP.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

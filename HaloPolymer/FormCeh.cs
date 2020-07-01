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
    public partial class FormCeh : Form
    {
        public FormCeh()
        {
            InitializeComponent();
            ShowCeh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Ceh cehSet = new Ceh();
            cehSet.Name_ceha = textBoxNameCeha.Text;
            cehSet.Number_ceha = Convert.ToInt32(textBoxNumberCeha.Text);
            Program.HaloPolymer.Ceh.Add(cehSet);
            Program.HaloPolymer.SaveChanges();
            ShowCeh();
        }

        void ShowCeh()
        {
            listViewCeh.Items.Clear();
            foreach (Ceh cehSet in Program.HaloPolymer.Ceh)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        cehSet.Name_ceha,
                        cehSet.Number_ceha.ToString()
                    });
                item.Tag = cehSet;
                listViewCeh.Items.Add(item);
            }
            listViewCeh.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewCeh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCeh.SelectedItems.Count == 1)
            {
                Ceh cehSet = listViewCeh.SelectedItems[0].Tag as Ceh;
                textBoxNameCeha.Text = cehSet.Name_ceha;
                textBoxNumberCeha.Text = cehSet.Number_ceha.ToString();
            }
            else
            {
                textBoxNameCeha.Text = "";
                textBoxNumberCeha.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCeh.SelectedItems.Count == 1)
            {
                Ceh cehSet = listViewCeh.SelectedItems[0].Tag as Ceh;
                cehSet.Name_ceha = textBoxNameCeha.Text;
                cehSet.Number_ceha = Convert.ToInt32(textBoxNumberCeha.Text);
                Program.HaloPolymer.SaveChanges();
                ShowCeh();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCeh.SelectedItems.Count == 1)
                {
                    Ceh cehSet = listViewCeh.SelectedItems[0].Tag as Ceh;
                    Program.HaloPolymer.Ceh.Remove(cehSet);
                    Program.HaloPolymer.SaveChanges();
                    ShowCeh();
                }
                textBoxNameCeha.Text = "";
                textBoxNumberCeha.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

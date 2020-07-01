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
    public partial class FormEquipment : Form
    {
        public FormEquipment()
        {
            InitializeComponent();
            ShowEquipment();
        }

        void ShowEquipment()
        {
            listViewEquipment.Items.Clear();
            foreach (EquipmentType equipmentSet in Program.HaloPolymer.EquipmentType)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        equipmentSet.Type
                    });
                item.Tag = equipmentSet;
                listViewEquipment.Items.Add(item);
            }
            listViewEquipment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EquipmentType equipmentSet = new EquipmentType();
            equipmentSet.Type = textBoxNameEquipment.Text;
            Program.HaloPolymer.EquipmentType.Add(equipmentSet);
            Program.HaloPolymer.SaveChanges();
            ShowEquipment();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEquipment.SelectedItems.Count == 1)
            {
                EquipmentType equipmentSet = listViewEquipment.SelectedItems[0].Tag as EquipmentType;
                equipmentSet.Type = textBoxNameEquipment.Text;
                Program.HaloPolymer.SaveChanges();
                ShowEquipment();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEquipment.SelectedItems.Count == 1)
                {
                    EquipmentType equipmentSet = listViewEquipment.SelectedItems[0].Tag as EquipmentType;
                    Program.HaloPolymer.EquipmentType.Remove(equipmentSet);
                    Program.HaloPolymer.SaveChanges();
                    ShowEquipment();
                }
                textBoxNameEquipment.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEquipment.SelectedItems.Count == 1)
            {
                EquipmentType equipmentSet = listViewEquipment.SelectedItems[0].Tag as EquipmentType;
                textBoxNameEquipment.Text = equipmentSet.Type;
            }
            else
            {
                textBoxNameEquipment.Text = "";
            }
        }
    }
}

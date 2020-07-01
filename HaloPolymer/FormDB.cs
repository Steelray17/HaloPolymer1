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
    public partial class FormDB : Form
    {
        public FormDB()
        {
            InitializeComponent();
            ShowCeh();
            ShowASYTP();
            ShowEquipment();
            ShowDB();
        }

        void ShowCeh()
        {
            comboBoxCeh.Items.Clear();
            foreach (Ceh cehSet in Program.HaloPolymer.Ceh)
            {
                string[] item = { cehSet.id.ToString() + ".", cehSet.Number_ceha.ToString() };
                comboBoxCeh.Items.Add(string.Join(" ", item));
            }
        }

        void ShowASYTP()
        {
            comboBoxASYTP.Items.Clear();
            foreach (ASYTP asytpSet in Program.HaloPolymer.ASYTP)
            {
                string[] item = { asytpSet.id.ToString() + ".", asytpSet.Name_ASYTP };
                comboBoxASYTP.Items.Add(string.Join(" ", item));
            }
        }

        void ShowEquipment()
        {
            comboBoxEquipment.Items.Clear();
            foreach (EquipmentType equipmentSet in Program.HaloPolymer.EquipmentType)
            {
                string[] item = { equipmentSet.id.ToString() + ".", equipmentSet.Type };
                comboBoxEquipment.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDB()
        {
            listViewDB.Items.Clear();

            foreach (DataBase datebaseSet in Program.HaloPolymer.DataBase)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        datebaseSet.Ceh.Number_ceha.ToString(),
                        datebaseSet.ASYTP.Name_ASYTP,
                        datebaseSet.EquipmentType.Type,
                        datebaseSet.Name_Equipment,
                        datebaseSet.Name_Network,
                        datebaseSet.Number_Serial,
                        datebaseSet.Number_Inventory,
                        datebaseSet.IP_address,
                        datebaseSet.Time_Synchron,
                        datebaseSet.Mac_address,
                        datebaseSet.VLAN,
                        datebaseSet.Manufacturer,
                        datebaseSet.Network_card
            });
                item.Tag = datebaseSet;
                listViewDB.Items.Add(item);
            }
            listViewDB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }



        private void listViewDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDB.SelectedItems.Count == 1)
            {
                DataBase datebaseSet = listViewDB.SelectedItems[0].Tag as DataBase;

                comboBoxCeh.SelectedIndex = comboBoxCeh.FindString(datebaseSet.idCeh.ToString());
                comboBoxASYTP.SelectedIndex = comboBoxASYTP.FindString(datebaseSet.idASYTP.ToString());
                comboBoxEquipment.SelectedIndex = comboBoxEquipment.FindString(datebaseSet.idEquipmentType.ToString());
                textBox1.Text = datebaseSet.Name_Equipment;
                textBox2.Text = datebaseSet.Name_Network;
                textBox3.Text = datebaseSet.Number_Serial;
                textBox4.Text = datebaseSet.Number_Inventory.ToString();
                textBox5.Text = datebaseSet.IP_address;
                textBox6.Text = datebaseSet.Time_Synchron;
                textBox7.Text = datebaseSet.Mac_address;
                textBox8.Text = datebaseSet.VLAN.ToString();
                textBox9.Text = datebaseSet.Manufacturer;
                textBox10.Text = datebaseSet.Network_card;
            }
            else
            {
                comboBoxCeh.SelectedItem = null;
                comboBoxASYTP.SelectedItem = null;
                comboBoxEquipment.SelectedItem = null;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCeh.SelectedItem != null && comboBoxASYTP.SelectedItem != null && comboBoxEquipment != null && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "") 
            {
                DataBase datebaseSet = new DataBase();

                datebaseSet.idCeh = Convert.ToInt32(comboBoxCeh.SelectedItem.ToString().Split('.')[0]);
                datebaseSet.idASYTP = Convert.ToInt32(comboBoxASYTP.SelectedItem.ToString().Split('.')[0]);
                datebaseSet.idEquipmentType = Convert.ToInt32(comboBoxEquipment.SelectedItem.ToString().Split('.')[0]);
                datebaseSet.Name_Equipment = textBox1.Text;
                datebaseSet.Name_Network = textBox2.Text;
                datebaseSet.Number_Serial = textBox3.Text;
                datebaseSet.Number_Inventory = textBox4.Text;
                datebaseSet.IP_address = textBox5.Text;
                datebaseSet.Time_Synchron = textBox6.Text;
                datebaseSet.Mac_address = textBox7.Text;
                datebaseSet.VLAN = textBox8.Text;
                datebaseSet.Manufacturer = textBox9.Text;
                datebaseSet.Network_card = textBox10.Text;

                Program.HaloPolymer.DataBase.Add(datebaseSet);
                Program.HaloPolymer.SaveChanges();
                ShowDB();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDB.SelectedItems.Count == 1)
                {
                    DataBase datebaseSet = listViewDB.SelectedItems[0].Tag as DataBase;
                    Program.HaloPolymer.DataBase.Remove(datebaseSet);
                    Program.HaloPolymer.SaveChanges();
                    ShowDB();
                }
                comboBoxCeh.SelectedItem = null;
                comboBoxASYTP.SelectedItem = null;
                comboBoxEquipment.SelectedItem = null;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDB.SelectedItems.Count == 1)
            {
                DataBase datebaseSet = listViewDB.SelectedItems[0].Tag as DataBase;

                datebaseSet.idCeh = Convert.ToInt32(comboBoxCeh.SelectedItem.ToString().Split('.')[0]);
                datebaseSet.idASYTP = Convert.ToInt32(comboBoxASYTP.SelectedItem.ToString().Split('.')[0]);
                datebaseSet.idEquipmentType = Convert.ToInt32(comboBoxEquipment.SelectedItem.ToString().Split('.')[0]);
                datebaseSet.Name_Equipment = textBox1.Text;
                datebaseSet.Name_Network = textBox2.Text;
                datebaseSet.Number_Serial = textBox3.Text;
                datebaseSet.Number_Inventory = textBox4.Text;
                datebaseSet.IP_address = textBox5.Text;
                datebaseSet.Time_Synchron = textBox6.Text;
                datebaseSet.Mac_address = textBox7.Text;
                datebaseSet.VLAN = textBox8.Text;
                datebaseSet.Manufacturer = textBox9.Text;
                datebaseSet.Network_card = textBox10.Text;
                Program.HaloPolymer.SaveChanges();
                ShowDB();
            }
        }

        private void FormDB_Load(object sender, EventArgs e)
        {

        }
    }
}

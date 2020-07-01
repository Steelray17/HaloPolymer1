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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                Users users = new Users();
                users.Login = textBoxLogin.Text;
                users.Password = textBoxPassword.Text;
                users.Type = comboBoxType.Text;
                Program.HaloPolymer.Users.Add(users);
                Program.HaloPolymer.SaveChanges();
            }

            MessageBox.Show("Успешно!", "Вы успешно зарегистрировались", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form formAuthorization = new FormAuthorization();
            this.Hide();
            formAuthorization.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

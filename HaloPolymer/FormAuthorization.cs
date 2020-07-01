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
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAuthorization : Form
    {
        public static User users = new User();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.HaloPolymer.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        user.Login = user.Login;
                        user.Password = user.Password;
                        user.Type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Form formregistration = new FormRegistration();
            formregistration.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

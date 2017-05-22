using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BL;

namespace Tema1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            User user;
            String role;
            AdminForm adminForm;
            CashierForm cashierForm;

            user = userService.login(textBoxUsername.Text, textBoxPassword.Text);
            textBoxUsername.Clear();
            textBoxPassword.Clear();           

            if (user != null)
            {
                role = user.Role;

                if ("admin".Equals(role) || "Admin".Equals(role) )
                {
                    adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if ("casier".Equals(role) || "Casier".Equals(role))
                {
                    cashierForm = new CashierForm();
                    cashierForm.Show();
                }
            }
            else
            {
                lblMessage.Text = "Utilizatorul sau parola sunt gresite!";
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

            var random = new Random();
            int l = random.Next(4, 16);
            string password = PasswordGenerator.GetUniqueKey(l);

            string username = textBoxUsername.Text;

            
            if( UserService.resetPassword(username, password))
            {
                MessageBox.Show(password);
            }
        }
    }
}

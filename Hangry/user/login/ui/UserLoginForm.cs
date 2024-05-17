using Hangry.administrator.login.data.models;
using Hangry.administrator.main.ui;
using Hangry.user.login.data.datasources;
using Hangry.user.main.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangry.user.login.ui
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            UserDataSource userDataSource = new UserLocalDataSource();
            var credentials = new data.models.Credentials(
                usernameTextBox.Text,
                passwordTextBox.Text
            );
            var user = userDataSource.Get(credentials);
            if(user == null)
            {
                MessageBox.Show(
                    "Логін або пароль невірний!", "Помилка входу",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
            var mainForm = new MainForm(user);
            mainForm.Show();
            Close();
        }

        private void noAccountButton_Click(object sender, EventArgs e)
        {
            var userRegistrationForm = new UserRegistrationForm();
            userRegistrationForm.Show();
            Close();
        }
    }
}

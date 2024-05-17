using Hangry.user.login.data.datasources;
using Hangry.user.login.data.models;
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
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(addressTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty || usernameTextBox.Text == string.Empty)
            {
                MessageBox.Show(
                    "Не всі поля заповнено!", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
            UserDataSource userDataSource = new UserLocalDataSource();
            var user = new User(
                new Random().Next(),
                usernameTextBox.Text,
                addressTextBox.Text,
                passwordTextBox.Text
            );
            userDataSource.Add(user);

            var userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            Close();
        }

        private void haveAccountButton_Click(object sender, EventArgs e)
        {
            var userLoginForm = new UserLoginForm();
            userLoginForm.Show();
            Close();
        }
    }
}

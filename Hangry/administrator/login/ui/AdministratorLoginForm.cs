using Hangry.administrator.login.data;
using Hangry.administrator.login.data.datasources;
using Hangry.administrator.main.ui;
using Hangry.user.login.data.datasources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangry
{
    public partial class AdministratorLoginForm : Form
    {
        public AdministratorLoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            ICredentialsDataSource credentialsDataSource = new CredentialsLocalDataSource();
            var expectedPassword = credentialsDataSource.GetCredentials().Password;
            var actualPassword = passwordTextBox.Text;
            if (expectedPassword != actualPassword)
            {
                MessageBox.Show(
                    "Пароль невірний!", "Помилка входу",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }

            var mainForm = new EstablishmentsForm();
            mainForm.Show();
            Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

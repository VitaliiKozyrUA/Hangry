using Hangry.user.login.ui;

namespace Hangry
{
    public partial class UserTypeForm : Form
    {
        AdministratorLoginForm administratorForm;
        UserLoginForm userLoginForm;

        public UserTypeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administratorButton_Click(object sender, EventArgs e)
        {
            if (administratorForm == null || administratorForm.IsDisposed)
            {
                administratorForm = new AdministratorLoginForm();
            }
            administratorForm.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if (userLoginForm == null || userLoginForm.IsDisposed)
            {
                userLoginForm = new UserLoginForm();
            }
            userLoginForm.Show();
        }
    }
}

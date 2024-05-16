namespace Hangry
{
    public partial class UserTypeForm : Form
    {
        public UserTypeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administratorButton_Click(object sender, EventArgs e)
        {
            var administratorForm = new AdministratorLoginForm();
            administratorForm.Show();
            Hide();
        }
    }
}

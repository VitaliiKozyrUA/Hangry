namespace Hangry
{
    public partial class UserTypeForm : Form
    {
        AdministratorLoginForm administratorForm;

        public UserTypeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administratorButton_Click(object sender, EventArgs e) {
            if(administratorForm == null || administratorForm.IsDisposed) { 
                administratorForm = new AdministratorLoginForm();
            }
            administratorForm.Show();
        }
    }
}

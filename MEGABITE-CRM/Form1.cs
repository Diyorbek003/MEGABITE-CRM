namespace MEGABITE_CRM
{
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            signinform obj = new signinform();
            this.Hide();
            obj.Show();   
        }

        private void signupform_Load(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            var obj = new WelcomeForm();
            this.Hide();
            obj.Show();
        }
    }
}
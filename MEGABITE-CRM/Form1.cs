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
    }
}
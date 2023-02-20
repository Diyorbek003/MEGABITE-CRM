using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGABITE_CRM
{
    public partial class signinform : Form
    {
        public signinform()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            signupform obj = new signupform();
            this.Hide();
            obj.Show();
        }
    }
}

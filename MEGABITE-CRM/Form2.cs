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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new signinform();
            this.Hide();
            obj.Show();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            var obj = new signinform();
            this.Hide();
            obj.Show();
        }
    }
}

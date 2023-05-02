using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class UserPannel : Form
        
    {
        PayForm pf = new PayForm();
       public LoginForm lf;
   
        public UserPannel()
        {
            InitializeComponent();
            pf.userpannel = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pf.Show();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            hider();
        }

        private void UserPannel_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            hider();
        }
        private void hider()
        {
            this.Hide();
            lf.Show();
        }
        ExitCheckForm ExitApp = new ExitCheckForm();
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitApp.Show();
        }
    }
}

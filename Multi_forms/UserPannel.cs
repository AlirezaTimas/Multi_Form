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
        SearchForm sf = new SearchForm(); 
       public LoginForm lf;
   
        public UserPannel()
        {
            InitializeComponent();
            pf.userpannel = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pf.textBox1.Text = "توجه : تنها مجاز به استفاده از اعداد هستید";
            pf.textBox2.Text = "توجه : تنها مجاز به استفاده از اعداد هستید";
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
          
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Menu")
                    Application.OpenForms[i].Hide();
            }
            lf.UsernameTextBox.Text = "نام کاربری خود را وارد کنید";
            lf.PasswordTextBox.Text = "رمزعبور خود را وارد کنید";
            lf.ActiveControl = lf.EnterButton;
            lf.Show();
 
        }
        ExitCheckForm ExitApp = new ExitCheckForm();
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitApp.Show();
        }
    }
}

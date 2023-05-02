using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
            form1.lf = this;
        }
       
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes; //changing direction of textboxes to RTL , because placeholders are written in Farsi.
            PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            UsernameTextBox.Text = "نام کاربری خود را وارد کنید";
            PasswordTextBox.Text = "رمزعبور خود را وارد کنید";
            this.ActiveControl = label3; //setting starting focus(when form loads) on label3, so placeholders are shown correctly.
            this.AcceptButton = EnterButton;

        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "نام کاربری خود را وارد کنید")
            {
                UsernameTextBox.Text = "";
            }
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {

            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "نام کاربری خود را وارد کنید";
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "رمزعبور خود را وارد کنید")
            {
                PasswordTextBox.Text = "";
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "رمزعبور خود را وارد کنید";
            }
        }
        // above codes are placeholder codes ,written in order to reduce the number of labels in login form
        UserPannel form1 = new UserPannel();

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "admin" && UsernameTextBox.Text == "admin") //if user enters username first and password after
            {
                form1.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e) // this button is created for situations that user closes Userpannel and wants to enter again without entering username and pass again 
        {
            if (PasswordTextBox.Text == "admin" && UsernameTextBox.Text == "admin")
            {
                form1.Show();
                this.Hide();

            }
            else if (UsernameTextBox.Text == "نام کاربری خود را وارد کنید" && PasswordTextBox.Text == "رمزعبور خود را وارد کنید")
            {
                MessageBox.Show("برای ورود باید نام کاربری و رمزعبور خود را وارد کنید");
            }
            else if (UsernameTextBox.Text == "admin" && PasswordTextBox.Text != "admin")
            {
                MessageBox.Show("رمزعبور اشتباه است", "رمزعبور اشتباه است");

            }
            else if (PasswordTextBox.Text == "admin" && UsernameTextBox.Text != "admin")
            {
                MessageBox.Show("نام کاربری اشتباه است", "نام کاربری اشتباه است");
            }
            else
            {
                MessageBox.Show("نام کاربری و رمزعبور اشتباه است", "نام کاربری و رمزعبور اشتباه است");
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e) //if user enters password first and username after
        {
            if (PasswordTextBox.Text == "admin" && UsernameTextBox.Text == "admin")
            {
                form1.Show();
            }
        }
        ExitCheckForm check = new ExitCheckForm();
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            check.Show();

        }
    }
}

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
    public partial class SearchForm : Form
    {
        public PayForm pf;
        public UserPannel up;
        public string[] NamesArray = { "علی", "رضا", "محمد", "امید", "برسام", "دانیال" };


        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("برای پیدا کردن شماره دانشجویی باید یکی از اسامی مجاز را وارد کنید");
            }
            else if (textBox1.Text != NamesArray[0] && textBox1.Text != NamesArray[1] && textBox1.Text != NamesArray[2] && textBox1.Text != NamesArray[3] && textBox1.Text != NamesArray[4])
            {
                MessageBox.Show("لطفا تنها از اسامی مجاز موجود در لیست استفاده کنید");
            }

            else if (textBox1.Text == NamesArray[0])
            {
                pf.textBox1.Text = "14001123";
                this.Hide();
            }
            else if (textBox1.Text == NamesArray[1])
            {
                pf.textBox1.Text = "14001345";
                this.Hide();
            }
            else if (textBox1.Text == NamesArray[2])
            {
                pf.textBox1.Text = "14001965";
                this.Hide();
            }
            else if (textBox1.Text == NamesArray[3])
            {
                pf.textBox1.Text = "14001785";
                this.Hide();
            }
            else if (textBox1.Text == NamesArray[4])
            {
                pf.textBox1.Text = "14001321";
                this.Hide();
            }
            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            NamesBox.Items.Add(NamesArray[0]);
            NamesBox.Items.Add(NamesArray[1]);
            NamesBox.Items.Add(NamesArray[2]);
            NamesBox.Items.Add(NamesArray[3]);
            NamesBox.Items.Add(NamesArray[4]);
        }
    }
}

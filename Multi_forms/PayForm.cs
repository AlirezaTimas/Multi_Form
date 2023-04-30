using System;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
        public UserPannel userpannel;
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();
        }
        public void button1_Click(object sender, EventArgs e)
        { 
        string username = textBox1.Text;
            string amount = textBox2.Text;
            string datetime = DateTime.Now.ToString();
            userpannel.PaymentsListBox.Items.Add("پرداخت با شماره دانشجویی : " + " " + username + " " + "به مبلغ: " + " " + " " + amount + " " + "در تاریخ: " + " " + datetime + " " + "با موفقیت انجام شد.");
        }
        public void PayForm_Load(object sender, EventArgs e)
        {
        }
    }
}

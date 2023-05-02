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
            textBox1.ShortcutsEnabled = false;
            textBox2.ShortcutsEnabled = false;
          

        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            sf.Hide();
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

            if (username == "" || username == "توجه : تنها مجاز به استفاده از اعداد هستید" && amount == "" || amount == "توجه : تنها مجاز به استفاده از اعداد هستید")
            {
                if (username == "توجه : تنها مجاز به استفاده از اعداد هستید" && amount == "توجه : تنها مجاز به استفاده از اعداد هستید")
                {
                    MessageBox.Show("کادرها را خالی نگذارید ، جهت پرداخت باید شماره دانشجویی و مبلغ را وارد کنید!", "مبلغ و شماره دانشجویی را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                }
                else if (username != "" && username != "توجه : تنها مجاز به استفاده از اعداد هستید" && amount == "" || amount == "توجه : تنها مجاز به استفاده از اعداد هستید")
                {
                    MessageBox.Show("لطفا مبلغ را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
                else
                    MessageBox.Show("کادرها را خالی نگذارید ، جهت پرداخت باید شماره دانشجویی و مبلغ را وارد کنید!", "مبلغ و شماره دانشجویی را وارد کنید", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            else if (username == "" || username == "توجه : تنها مجاز به استفاده از اعداد هستید" && amount != "" && amount != "توجه : تنها مجاز به استفاده از اعداد هستید")
            {
                MessageBox.Show("لطفا شماره دانشجویی را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
            else
            {
                userpannel.PaymentsListBox.Items.Add("پرداخت با شماره دانشجویی : " + " " + username + " " + "به مبلغ: " + " " + " " + amount + " " + "در تاریخ: " + " " + datetime + " " + "با موفقیت انجام شد.");
                this.Hide();
                sf.Hide();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "توجه : تنها مجاز به استفاده از اعداد هستید")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "توجه : تنها مجاز به استفاده از اعداد هستید";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "توجه : تنها مجاز به استفاده از اعداد هستید")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                textBox1.Text = "توجه : تنها مجاز به استفاده از اعداد هستید";
            }
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
        }
    }
}

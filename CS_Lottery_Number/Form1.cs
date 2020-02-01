using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Lottery_Number
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int iStore;
        DialogResult iExit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer7.Enabled = true;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
            iStore = 20;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            iExit = MessageBox.Show("Confirm if you want to exit", "Lottery Number Generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num1;
            num1 = rnd.Next(1, 59);
            txtLotto1.Text = Convert.ToString(num1);

            if (txtLotto1.Text == "0")
            {
                int num7;
                num7 = rnd.Next(1, 59);
                txtLotto1.Text = Convert.ToString(num7);
            }
            if (txtLotto1.Text == txtLotto2.Text || txtLotto1.Text == txtLotto3.Text || txtLotto1.Text == txtLotto4.Text ||
                txtLotto1.Text == txtLotto5.Text || txtLotto1.Text == txtLotto6.Text)
            {
                num1 = rnd.Next(1, 59);
                txtLotto1.Text = Convert.ToString(num1);
            }
            txtLotto1.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            iStore = iStore - 1;

            if (iStore == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int num2;
            num2 = rnd.Next(1, 59);
            txtLotto2.Text = Convert.ToString(num2);

            if (txtLotto2.Text == "0")
            {
                num2 = rnd.Next(1, 59);
                txtLotto1.Text = Convert.ToString(num2);
                
            }
            if (txtLotto2.Text == txtLotto1.Text || txtLotto2.Text == txtLotto2.Text || txtLotto2.Text == txtLotto3.Text ||
                txtLotto2.Text == txtLotto4.Text || txtLotto2.Text == txtLotto5.Text)
            {
                int num7;
                num7 = rnd.Next(1, 59);
                txtLotto2.Text = Convert.ToString(num7);
            }
            txtLotto2.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int num3;
            num3 = rnd.Next(1, 59);
            txtLotto3.Text = Convert.ToString(num3);

            if (txtLotto3.Text == "0")
            {
                num3 = rnd.Next(1, 59);
                txtLotto1.Text = Convert.ToString(num3);
                
            }
            if (txtLotto3.Text == txtLotto1.Text || txtLotto3.Text == txtLotto2.Text || txtLotto3.Text == txtLotto3.Text ||
                txtLotto3.Text == txtLotto4.Text || txtLotto3.Text == txtLotto5.Text)
            {
                int num7;
                num7 = rnd.Next(1, 59);
                txtLotto3.Text = Convert.ToString(num7);
            }
            txtLotto3.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int num4;
            num4 = rnd.Next(1, 59);
            txtLotto4.Text = Convert.ToString(num4);

            if (txtLotto4.Text == "0")
            {
                num4 = rnd.Next(1, 59);
                txtLotto1.Text = Convert.ToString(num4);
                
            }
            if (txtLotto4.Text == txtLotto1.Text || txtLotto4.Text == txtLotto2.Text || txtLotto4.Text == txtLotto3.Text ||
                txtLotto4.Text == txtLotto4.Text || txtLotto4.Text == txtLotto5.Text)
            {
                int num7;
                num7 = rnd.Next(1, 59);
                txtLotto4.Text = Convert.ToString(num7);
            }
            txtLotto4.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int num5;
            num5 = rnd.Next(1, 59);
            txtLotto5.Text = Convert.ToString(num5);

            if (txtLotto5.Text == "0")
            {
                num5 = rnd.Next(1, 59);
                txtLotto5.Text = Convert.ToString(num5);
               
            }
            if (txtLotto5.Text == txtLotto1.Text || txtLotto5.Text == txtLotto2.Text || txtLotto5.Text == txtLotto3.Text ||
                txtLotto5.Text == txtLotto4.Text || txtLotto5.Text == txtLotto5.Text)
            {
                int num7;
                num7 = rnd.Next(1, 59);
                txtLotto5.Text = Convert.ToString(num7);
            }
            txtLotto5.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int num6;
            num6 = rnd.Next(1, 59);
            txtLotto6.Text = Convert.ToString(num6);

            if (txtLotto6.Text == "0")
            {
                num6 = rnd.Next(1, 59);
                txtLotto6.Text = Convert.ToString(num6);
               
            }
            if (txtLotto6.Text == txtLotto1.Text || txtLotto6.Text == txtLotto2.Text || txtLotto6.Text == txtLotto3.Text ||
                txtLotto6.Text == txtLotto4.Text || txtLotto6.Text == txtLotto5.Text)
            {
                int num7;
                num7 = rnd.Next(1, 59);
                txtLotto6.Text = Convert.ToString(num7);
            }
            txtLotto6.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label1.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
            btnExit.BackColor = BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
            btnLottery.BackColor = BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
            btnLottery.ForeColor = BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
            btnExit.ForeColor = BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.BackColor = BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
    }
}

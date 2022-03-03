using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh3
{
    public partial class giaiptbac2 : Form
    {
        public giaiptbac2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_A.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập không để trống Hệ Số A !");
                }
                else if((txt_B.Text == ""))
                    {
                    MessageBox.Show("Vui lòng nhập không để trống Hệ Số B !");
                }
                else if ((txt_C.Text == ""))
                {
                    MessageBox.Show("Vui lòng nhập không để trống Hệ Số C !");
                }
                else
                { 
                double Delta, X1, X2;
                int A, B, C;
                A = Convert.ToInt16(txt_A.Text);
                B = Convert.ToInt16(txt_B.Text);
                C = Convert.ToInt16(txt_C.Text);
                Delta = B * B - 4 * A * C;
                if (Delta > 0)
                {
                    X1 = (-B - Math.Sqrt(Delta)) / (2 * A);
                    X2 = (-B + Math.Sqrt(Delta)) / (2 * A);
                    txt_X1.Text = X1.ToString();
                    txt_X2.Text = X2.ToString();
                }
                else if (Delta == 0)
                {
                    X1 = X2 = -B / (2 * A);
                    txt_X1.Text = X1.ToString();
                    txt_X2.Text = X2.ToString();
                }
                else
                {
                    MessageBox.Show("PTVN");
                    txt_X1.Text = "";
                    txt_X2.Text = "";
                }

            }}
            catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập cho đúng chữ số");
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}

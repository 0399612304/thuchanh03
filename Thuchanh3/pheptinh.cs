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
    public partial class pheptinh : Form
    {
        public pheptinh()
        {
            InitializeComponent();
        }

        private void cong_Click(object sender, EventArgs e)
        {
            try
            {
                soa.Text = (Convert.ToDouble(soa.Text)).ToString();
                sob.Text = (Convert.ToDouble(sob.Text)).ToString();
                kq.Text = (Convert.ToDouble(soa.Text) + Convert.ToDouble(sob.Text)).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập cho đúng chữ số");
            }
        }

        private void tru_Click(object sender, EventArgs e)
        {
            try
            {
                soa.Text = (Convert.ToDouble(soa.Text)).ToString();
                sob.Text = (Convert.ToDouble(sob.Text)).ToString();
                kq.Text = (Convert.ToDouble(soa.Text) - Convert.ToDouble(sob.Text)).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Vui lòng nhập cho đúng chữ số");
            }
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            try
            {
                soa.Text = (Convert.ToDouble(soa.Text)).ToString();
                sob.Text = (Convert.ToDouble(sob.Text)).ToString();
                kq.Text = (Convert.ToDouble(soa.Text) * Convert.ToDouble(sob.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập cho đúng chữ số");
            }
        }

            private void chia_Click(object sender, EventArgs e)
        {
            try
            {
                soa.Text = (Convert.ToDouble(soa.Text)).ToString();
            sob.Text = (Convert.ToDouble(sob.Text)).ToString();
            kq.Text = (Convert.ToDouble(soa.Text) / Convert.ToDouble(sob.Text)).ToString();
            }
            catch (Exception ex)
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

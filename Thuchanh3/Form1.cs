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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nguyễnThanhTuânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giaiptbac2 form1 = new giaiptbac2();
            this.Hide();
            form1.ShowDialog();
        }

        private void trầnThanhHoàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pheptinh form2 = new pheptinh();
            this.Hide();
            form2.ShowDialog();
        }
    }
}

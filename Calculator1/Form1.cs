using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a,b);
            int kq = c.Execute("+");
            txtKq.Text = kq.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            int kq = c.Execute("-");
            txtKq.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            int kq = c.Execute("*");
            txtKq.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            Calculation c = new Calculation(a, b);
            int kq = c.Execute("/");
            txtKq.Text = kq.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "金額";
            label2.Text = "税込み金額";
            label3.Text = "円";
            labelAddTax.Text = "0円";
            buttonAddTax.Text = "消費税追加";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPrice.Text = "税抜き価格";
            labelNumOfPeople.Text = "人数";
            label3.Text = "円";
            label4.Text = "人";

            labelDividedPrice.Text = "一人あたり";
            labelOverPrice.Text = "余り";
            label7.Text = "** 円";
            label8.Text = "** 円";

            buttonForCalc.Text = "計算する";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Text = "チェックボックス";
            radioButton1.Text = "ラジオボタン1";
            radioButton2.Text = "ラジオボタン2";
            label1.Text = "ニューメリックアップダウン";

            labelCheckBox.Text = "チェックボックス： " + checkBox1.Checked;
            labelRadioButton1.Text = "ラジオボタン1： " + radioButton1.Checked;
            labelRadioButton2.Text = "ラジオボタン2： " + radioButton2.Checked;
            labelNumericUpDown.Text = "数値： " + "0";
        }
    }
}

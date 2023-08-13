using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ウィンドウのデフォルト値
        private void Form1_Load(object sender, EventArgs e)
        {
            //各科目の合否判定部分
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";

            //各科目の平均点との比較部分
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }
    }
}

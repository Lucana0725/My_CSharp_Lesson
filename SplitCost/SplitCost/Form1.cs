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

        // ウィンドウのデフォルト値
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

        // ボタンをクリックしたときの処理
        private void buttonForCalc_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBoxPrice.Text);  // 税抜き価格
            int people = int.Parse(textBoxNumOfPeople.Text);  // 人数

            const double tax = 0.08;  // 税率
            double priceAddedTax = price * (1 + tax);  // 税込価格(double型)

            int devidedPrice = (int)priceAddedTax / people;  // 一人あたりの税込み価格(int型)
            double overPrice =(int) priceAddedTax % people;  // 余り金額

            label7.Text = devidedPrice + " 円";
            label8.Text = overPrice + "円";
        }
    }
}

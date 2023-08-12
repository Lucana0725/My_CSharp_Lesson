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

        //ウィンドウのデフォルト値
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "金額";
            label2.Text = "税込み金額";
            label3.Text = "円";
            labelAddTax.Text = "0円";
            buttonAddTax.Text = "消費税追加";
        }

        //ボタンをクリックしたときの処理
        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBoxMoney.Text);  // 金額の入力値
            const double tax = 0.08;  // 税率

            double priceAddedTax = price * (1 + tax);  // 税込価格の計算
            int taxInPrice = (int)priceAddedTax;
            labelAddTax.Text = taxInPrice + " 円";
        }
    }
}

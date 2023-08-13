using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        ////ボタンをクリックしたときの処理
        //private void buttonAddTax_Click(object sender, EventArgs e)
        //{
        //    // 自分の回答

        //    //int price = int.Parse(textBoxMoney.Text);  // 金額の入力値
        //    //const double tax = 0.08;  // 税率

        //    //double priceAddedTax = price * (1 + tax);  // 税込価格の計算
        //    //int taxInPrice = (int)priceAddedTax;
        //    //labelAddTax.Text = taxInPrice + " 円";



        //    // 模範解答
        //    int money;
        //    double addTax;
        //    const double tax = 0.08;

        //    money = int.Parse(textBoxMoney.Text);
        //    addTax = money;
        //    addTax *= (1 + tax);
        //    money = (int)addTax;

        //    labelAddTax.Text = money + " 円";

        //}



        ////(模範解答の修正分)1
        ////ボタンをクリックしたときの処理
        //private void buttonAddTax_Click(object sender, EventArgs e)
        //{
        //    int money;
        //    try
        //    {
        //        money = int.Parse(textBoxMoney.Text);
        //        money = addTax(money);
        //        labelAddTax.Text = money + "円";
        //    }
        //    catch (FormatException ex)
        //    {
        //        labelAddTax.Text = ex.Message;
        //    }

        //    //元の処理。これらが、例外が発生しうるということでtryの中に移動した。
        //    //money = int.Parse(textBoxMoney.Text);
        //    //money = addTax(money);
        //    //labelAddTax.Text = money + "円";

        //}

        //// 税込金額算出処理
        //private int addTax(int m)
        //{
        //    const double tax = 0.08;
        //    return (int)(m * (1 + tax));
        //}



        //(模範解答の修正分)2
        //ボタンをクリックしたときの処理
        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            int money;

            if (int.TryParse(textBoxMoney.Text, out money))
            {
                money = addTax(money);
                labelAddTax.Text = money + " 円";
            }
            else
            {
                labelAddTax.Text = "入力文字列の形式が正しくありません";
            }
        }

        private int addTax(int m)
        {
            const double tax = 0.08;
            return (int)(m * (1 + tax));
        }
    }
}

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

        // 変換ボタンをクリックしたときの処理
        private void buttonJudge_Click(object sender, EventArgs e)
        {

        }


        // テキストを浮動小数点値に変換するメソッド
        // (仮引数)text : 変換する文字列  val : 変換した浮動小数点値
        // (返却値(return))なし
        private void textToValue(string text, double val)
        {
            if (double.TryParse(text, out val) == false)
            {
                val = -1.0;
            }
        }

        // テキストを整数値に変換するメソッド
        // (仮引数)text : 変換する文字列  val : 変換した整数値
        // returnなし
        // ※上のtextToValueをオーバーロードしている(仮引数double val ←→ int val)
        private void textToValue(string text, out int val)
        {
            if (int.TryParse(text, out val))
            {
                val = -1;
            }
        }
    }
}

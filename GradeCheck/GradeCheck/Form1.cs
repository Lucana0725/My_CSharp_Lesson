using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            // 出席率を浮動小数点値に変換
            double AttendanceM, AttendanceP, AttendanceE;
            textToValue(textBoxAttendanceM.Text, out AttendanceM);
            textToValue(textBoxAttendanceP.Text, out AttendanceP);
            textToValue(textBoxAttendanceE.Text, out AttendanceE);

            // 点数を整数値に変換
            int scoreM, scoreP, scoreE;
            textToValue(textBoxScoreM.Text, out scoreM);
            textToValue(textBoxScoreP.Text, out scoreP);
            textToValue(textBoxScoreE.Text, out scoreE);

            // 点数を判定する
            labelResultM.Text = scoreJudge(AttendanceM, scoreM);
            labelResultP.Text = scoreJudge(AttendanceP, scoreP);
            labelResultE.Text = scoreJudge(AttendanceE, scoreE);

            // 平均値以上か未満かを判定する
            labelCompAvgM.Text = averageJudge(scoreM, 1);
            labelCompAvgP.Text = averageJudge(scoreP, 2);
            labelCompAvgE.Text = averageJudge(scoreE, 3);
        }


        // テキストを浮動小数点値に変換するメソッド
        // (仮引数)text : 変換する文字列  val : 変換した浮動小数点値
        // (返却値(return))なし
        private void textToValue(string text, out double val)
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
            if (int.TryParse(text, out val) == false)
            {
                val = -1;
            }
        }


        // 成績判定メソッド
        // (仮引数) Attendance : 出席率  score : 得点
        // return : 判定結果
        private string scoreJudge(double Attendance, int score)
        {
            string result;  // 結果

            // エラー条件の洗い出し
            if (Attendance < 0.0 || Attendance > 100.0 || score < 0 || score > 100)
            
                result = "error";
            
            else if (Attendance >= 80.0)
            {
                if (score >= 80)
                
                    result = "A判定";
                
                else if (score >= 70)
                
                    result = "B判定";
                
                else if(score >= 60)
                
                    result = "C判定";
                
                else
                
                    result = "不合格";
                
            }
            else
            
                result = "不合格";
            
            return result;
        }


        // 平均点判定メソッド
        // (仮引数) score : 得点,  subject : 科目(1:数学, 2:物理, 3:英語)
        // return : 判定結果
        private string averageJudge(int score, int subject)
        {
            string result;  // 結果
            int average;  //平均値

            // 得点が0未満または100を超える場合はエラーに
            if (score < 0 || score > 100)
                return "エラー";

            // 平均点との比較
            switch (subject)
            {
                case 1:
                    average = 73;  // 数学の平均点は73点
                    break;
                case 2:
                    average = 65;  // 物理の平均点は65点
                    break;
                case 3:
                    average = 77;
                    break;
                default:
                    return "エラー";
            }

            // 実際に得点が平均値と比較してどうかをみる実行部分
            if (score >= average)
                result = "平均点以上";
            else
                result = "平均点未満";

            return result;  // 結果を返す

        }

        // リセットボタンを押したときの処理
        private void buttonReset_Click(object sender, EventArgs e)
        {
            // 出席率を0.0に
            textBoxAttendanceM.Text = "0.0";
            textBoxAttendanceP.Text = "0.0";
            textBoxAttendanceE.Text = "0.0";

            // 得点を0.0に
            textBoxScoreM.Text = "0.0";
            textBoxScoreP.Text = "0.0";
            textBoxScoreE.Text = "0.0";

            // ラベルを空文字に
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";

        }
    }
}

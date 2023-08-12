namespace SplitCost
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelNumOfPeople = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDividedPrice = new System.Windows.Forms.Label();
            this.labelOverPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonForCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(30, 26);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 12);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "label1";
            // 
            // labelNumOfPeople
            // 
            this.labelNumOfPeople.AutoSize = true;
            this.labelNumOfPeople.Location = new System.Drawing.Point(226, 26);
            this.labelNumOfPeople.Name = "labelNumOfPeople";
            this.labelNumOfPeople.Size = new System.Drawing.Size(35, 12);
            this.labelNumOfPeople.TabIndex = 1;
            this.labelNumOfPeople.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // labelDividedPrice
            // 
            this.labelDividedPrice.AutoSize = true;
            this.labelDividedPrice.Location = new System.Drawing.Point(30, 103);
            this.labelDividedPrice.Name = "labelDividedPrice";
            this.labelDividedPrice.Size = new System.Drawing.Size(35, 12);
            this.labelDividedPrice.TabIndex = 6;
            this.labelDividedPrice.Text = "label5";
            // 
            // labelOverPrice
            // 
            this.labelOverPrice.AutoSize = true;
            this.labelOverPrice.Location = new System.Drawing.Point(226, 103);
            this.labelOverPrice.Name = "labelOverPrice";
            this.labelOverPrice.Size = new System.Drawing.Size(35, 12);
            this.labelOverPrice.TabIndex = 7;
            this.labelOverPrice.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // buttonForCalc
            // 
            this.buttonForCalc.Location = new System.Drawing.Point(32, 174);
            this.buttonForCalc.Name = "buttonForCalc";
            this.buttonForCalc.Size = new System.Drawing.Size(337, 23);
            this.buttonForCalc.TabIndex = 10;
            this.buttonForCalc.Text = "button1";
            this.buttonForCalc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 228);
            this.Controls.Add(this.buttonForCalc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOverPrice);
            this.Controls.Add(this.labelDividedPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNumOfPeople);
            this.Controls.Add(this.labelPrice);
            this.Name = "Form1";
            this.Text = "割り勘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelNumOfPeople;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDividedPrice;
        private System.Windows.Forms.Label labelOverPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonForCalc;
    }
}


namespace ContractWithYubaba
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inkPicture1 = new Microsoft.Ink.InkPicture();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonInk = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelSigned = new System.Windows.Forms.Label();
            this.labelNameRecognized = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inkPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // inkPicture1
            // 
            this.inkPicture1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inkPicture1.Location = new System.Drawing.Point(12, 283);
            this.inkPicture1.MarginX = -2147483648;
            this.inkPicture1.MarginY = -2147483648;
            this.inkPicture1.Name = "inkPicture1";
            this.inkPicture1.Size = new System.Drawing.Size(639, 195);
            this.inkPicture1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelName.Location = new System.Drawing.Point(12, 262);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 18);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "名前";
            // 
            // buttonInk
            // 
            this.buttonInk.Location = new System.Drawing.Point(308, 495);
            this.buttonInk.Name = "buttonInk";
            this.buttonInk.Size = new System.Drawing.Size(172, 53);
            this.buttonInk.TabIndex = 3;
            this.buttonInk.Text = "インク（文字を書く）";
            this.buttonInk.UseVisualStyleBackColor = true;
            this.buttonInk.Click += new System.EventHandler(this.buttonInk_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(630, 585);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 84);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(633, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "手書き認識エンジン";
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(496, 495);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(203, 53);
            this.buttonErase.TabIndex = 6;
            this.buttonErase.Text = "消しゴム（文字を消す）";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Location = new System.Drawing.Point(308, 562);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(172, 53);
            this.buttonRecognize.TabIndex = 7;
            this.buttonRecognize.Text = "認識";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(496, 564);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(116, 49);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelSigned
            // 
            this.labelSigned.AutoSize = true;
            this.labelSigned.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelSigned.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSigned.ForeColor = System.Drawing.Color.Blue;
            this.labelSigned.Location = new System.Drawing.Point(469, 698);
            this.labelSigned.Name = "labelSigned";
            this.labelSigned.Size = new System.Drawing.Size(143, 24);
            this.labelSigned.TabIndex = 9;
            this.labelSigned.Text = "サインしました";
            this.labelSigned.Visible = false;
            // 
            // labelNameRecognized
            // 
            this.labelNameRecognized.AutoSize = true;
            this.labelNameRecognized.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNameRecognized.Location = new System.Drawing.Point(314, 647);
            this.labelNameRecognized.Name = "labelNameRecognized";
            this.labelNameRecognized.Size = new System.Drawing.Size(79, 22);
            this.labelNameRecognized.TabIndex = 10;
            this.labelNameRecognized.Text = "？？？";
            this.labelNameRecognized.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.labelNameRecognized);
            this.Controls.Add(this.labelSigned);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonRecognize);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonInk);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.inkPicture1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "契約書";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inkPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Ink.InkPicture inkPicture1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonInk;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelSigned;
        private System.Windows.Forms.Label labelNameRecognized;
    }
}


namespace TestToolGoodWords
{
    partial class frmWordHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrc = new System.Windows.Forms.RichTextBox();
            this.txtDest = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJ2F = new System.Windows.Forms.Button();
            this.btnF2J = new System.Windows.Forms.Button();
            this.btn2QJ = new System.Windows.Forms.Button();
            this.btn2BJ = new System.Windows.Forms.Button();
            this.btn2No = new System.Windows.Forms.Button();
            this.btn2ZW = new System.Windows.Forms.Button();
            this.btn2PinY = new System.Windows.Forms.Button();
            this.cbAutoSpeak = new System.Windows.Forms.CheckBox();
            this.btnContentCheck = new System.Windows.Forms.Button();
            this.cbTone = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文本";
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(12, 32);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(306, 299);
            this.txtSrc.TabIndex = 1;
            this.txtSrc.Text = "";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(482, 32);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(306, 299);
            this.txtDest.TabIndex = 3;
            this.txtDest.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标文本";
            // 
            // btnJ2F
            // 
            this.btnJ2F.Location = new System.Drawing.Point(324, 51);
            this.btnJ2F.Name = "btnJ2F";
            this.btnJ2F.Size = new System.Drawing.Size(152, 29);
            this.btnJ2F.TabIndex = 4;
            this.btnJ2F.Text = "简变繁=>";
            this.btnJ2F.UseVisualStyleBackColor = true;
            this.btnJ2F.Click += new System.EventHandler(this.btnJ2F_Click);
            // 
            // btnF2J
            // 
            this.btnF2J.Location = new System.Drawing.Point(324, 86);
            this.btnF2J.Name = "btnF2J";
            this.btnF2J.Size = new System.Drawing.Size(152, 29);
            this.btnF2J.TabIndex = 4;
            this.btnF2J.Text = "繁变简=>";
            this.btnF2J.UseVisualStyleBackColor = true;
            this.btnF2J.Click += new System.EventHandler(this.btnF2J_Click);
            // 
            // btn2QJ
            // 
            this.btn2QJ.Location = new System.Drawing.Point(324, 121);
            this.btn2QJ.Name = "btn2QJ";
            this.btn2QJ.Size = new System.Drawing.Size(152, 29);
            this.btn2QJ.TabIndex = 4;
            this.btn2QJ.Text = "转全角=>";
            this.btn2QJ.UseVisualStyleBackColor = true;
            this.btn2QJ.Click += new System.EventHandler(this.btn2QJ_Click);
            // 
            // btn2BJ
            // 
            this.btn2BJ.Location = new System.Drawing.Point(324, 156);
            this.btn2BJ.Name = "btn2BJ";
            this.btn2BJ.Size = new System.Drawing.Size(152, 29);
            this.btn2BJ.TabIndex = 5;
            this.btn2BJ.Text = "转半角=>";
            this.btn2BJ.UseVisualStyleBackColor = true;
            this.btn2BJ.Click += new System.EventHandler(this.btn2BJ_Click);
            // 
            // btn2No
            // 
            this.btn2No.Location = new System.Drawing.Point(324, 191);
            this.btn2No.Name = "btn2No";
            this.btn2No.Size = new System.Drawing.Size(152, 29);
            this.btn2No.TabIndex = 6;
            this.btn2No.Text = "中文转数字=>";
            this.btn2No.UseVisualStyleBackColor = true;
            this.btn2No.Click += new System.EventHandler(this.btn2No_Click);
            // 
            // btn2ZW
            // 
            this.btn2ZW.Location = new System.Drawing.Point(324, 226);
            this.btn2ZW.Name = "btn2ZW";
            this.btn2ZW.Size = new System.Drawing.Size(152, 29);
            this.btn2ZW.TabIndex = 6;
            this.btn2ZW.Text = "数字转中文=>";
            this.btn2ZW.UseVisualStyleBackColor = true;
            this.btn2ZW.Click += new System.EventHandler(this.btn2ZW_Click);
            // 
            // btn2PinY
            // 
            this.btn2PinY.Location = new System.Drawing.Point(324, 261);
            this.btn2PinY.Name = "btn2PinY";
            this.btn2PinY.Size = new System.Drawing.Size(152, 29);
            this.btn2PinY.TabIndex = 7;
            this.btn2PinY.Text = "中文转拼音=>";
            this.btn2PinY.UseVisualStyleBackColor = true;
            this.btn2PinY.Click += new System.EventHandler(this.btn2PinY_Click);
            // 
            // cbAutoSpeak
            // 
            this.cbAutoSpeak.AutoSize = true;
            this.cbAutoSpeak.Checked = true;
            this.cbAutoSpeak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoSpeak.Location = new System.Drawing.Point(17, 419);
            this.cbAutoSpeak.Name = "cbAutoSpeak";
            this.cbAutoSpeak.Size = new System.Drawing.Size(181, 24);
            this.cbAutoSpeak.TabIndex = 8;
            this.cbAutoSpeak.Text = "中文转拼音后自动朗读";
            this.cbAutoSpeak.UseVisualStyleBackColor = true;
            // 
            // btnContentCheck
            // 
            this.btnContentCheck.Location = new System.Drawing.Point(16, 348);
            this.btnContentCheck.Name = "btnContentCheck";
            this.btnContentCheck.Size = new System.Drawing.Size(94, 29);
            this.btnContentCheck.TabIndex = 9;
            this.btnContentCheck.Text = "内容检查";
            this.btnContentCheck.UseVisualStyleBackColor = true;
            this.btnContentCheck.Click += new System.EventHandler(this.btnContentCheck_Click);
            // 
            // cbTone
            // 
            this.cbTone.AutoSize = true;
            this.cbTone.Checked = true;
            this.cbTone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTone.Location = new System.Drawing.Point(214, 419);
            this.cbTone.Name = "cbTone";
            this.cbTone.Size = new System.Drawing.Size(166, 24);
            this.cbTone.TabIndex = 10;
            this.cbTone.Text = "中文转拼音后带声调";
            this.cbTone.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "中文首字母=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmWordHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTone);
            this.Controls.Add(this.btnContentCheck);
            this.Controls.Add(this.cbAutoSpeak);
            this.Controls.Add(this.btn2PinY);
            this.Controls.Add(this.btn2ZW);
            this.Controls.Add(this.btn2No);
            this.Controls.Add(this.btn2BJ);
            this.Controls.Add(this.btn2QJ);
            this.Controls.Add(this.btnF2J);
            this.Controls.Add(this.btnJ2F);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSrc);
            this.Controls.Add(this.label1);
            this.Name = "frmWordHelper";
            this.Text = "WordsHelper测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox txtSrc;
        private RichTextBox txtDest;
        private Label label2;
        private Button btnJ2F;
        private Button btnF2J;
        private Button btn2QJ;
        private Button btn2BJ;
        private Button btn2No;
        private Button btn2ZW;
        private Button btn2PinY;
        private CheckBox cbAutoSpeak;
        private Button btnContentCheck;
        private CheckBox cbTone;
        private Button button1;
    }
}
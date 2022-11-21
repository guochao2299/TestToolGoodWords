namespace TestToolGoodWords
{
    partial class frmFFWords
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbSkip = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlackList = new System.Windows.Forms.TextBox();
            this.txtSkipWords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIngoreCase = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResearchWord = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lstResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.cbCF = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbCF);
            this.splitContainer1.Panel1.Controls.Add(this.cbSkip);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtBlackList);
            this.splitContainer1.Panel1.Controls.Add(this.txtSkipWords);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbIngoreCase);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtResearchWord);
            this.splitContainer1.Panel1.Controls.Add(this.txtFile);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelectFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(990, 549);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbSkip
            // 
            this.cbSkip.AutoSize = true;
            this.cbSkip.Checked = true;
            this.cbSkip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSkip.Location = new System.Drawing.Point(145, 156);
            this.cbSkip.Name = "cbSkip";
            this.cbSkip.Size = new System.Drawing.Size(61, 24);
            this.cbSkip.TabIndex = 9;
            this.cbSkip.Text = "跳词";
            this.cbSkip.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "设置黑名单：";
            // 
            // txtBlackList
            // 
            this.txtBlackList.Location = new System.Drawing.Point(118, 85);
            this.txtBlackList.Name = "txtBlackList";
            this.txtBlackList.Size = new System.Drawing.Size(791, 27);
            this.txtBlackList.TabIndex = 7;
            // 
            // txtSkipWords
            // 
            this.txtSkipWords.Location = new System.Drawing.Point(118, 118);
            this.txtSkipWords.Name = "txtSkipWords";
            this.txtSkipWords.Size = new System.Drawing.Size(791, 27);
            this.txtSkipWords.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "设置跳词：";
            // 
            // cbIngoreCase
            // 
            this.cbIngoreCase.AutoSize = true;
            this.cbIngoreCase.Checked = true;
            this.cbIngoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIngoreCase.Location = new System.Drawing.Point(22, 156);
            this.cbIngoreCase.Name = "cbIngoreCase";
            this.cbIngoreCase.Size = new System.Drawing.Size(106, 24);
            this.cbIngoreCase.TabIndex = 4;
            this.cbIngoreCase.Text = "忽略大小写";
            this.cbIngoreCase.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(919, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 63);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "设置搜索词：";
            // 
            // txtResearchWord
            // 
            this.txtResearchWord.Location = new System.Drawing.Point(118, 47);
            this.txtResearchWord.Name = "txtResearchWord";
            this.txtResearchWord.Size = new System.Drawing.Size(791, 27);
            this.txtResearchWord.TabIndex = 1;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(118, 11);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(791, 27);
            this.txtFile.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(18, 11);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(94, 29);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "选择文件：";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstResult);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtContent);
            this.splitContainer2.Size = new System.Drawing.Size(990, 349);
            this.splitContainer2.SplitterDistance = 270;
            this.splitContainer2.TabIndex = 0;
            // 
            // lstResult
            // 
            this.lstResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.lstResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstResult.FullRowSelect = true;
            this.lstResult.Location = new System.Drawing.Point(0, 0);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(270, 349);
            this.lstResult.TabIndex = 0;
            this.lstResult.UseCompatibleStateImageBehavior = false;
            this.lstResult.View = System.Windows.Forms.View.Details;
            this.lstResult.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "匹配项";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "位置";
            this.columnHeader2.Width = 100;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Cornsilk;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(716, 349);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // cbCF
            // 
            this.cbCF.AutoSize = true;
            this.cbCF.Checked = true;
            this.cbCF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCF.Location = new System.Drawing.Point(222, 156);
            this.cbCF.Name = "cbCF";
            this.cbCF.Size = new System.Drawing.Size(106, 24);
            this.cbCF.TabIndex = 9;
            this.cbCF.Text = "重复词过滤";
            this.cbCF.UseVisualStyleBackColor = true;
            // 
            // frmFFWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmFFWords";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private RichTextBox txtContent;
        private Button btnSearch;
        private Label label1;
        private TextBox txtResearchWord;
        private TextBox txtFile;
        private Button btnSelectFile;
        private ListView lstResult;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private CheckBox cbIngoreCase;
        private TextBox txtSkipWords;
        private Label label2;
        private Label label3;
        private TextBox txtBlackList;
        private CheckBox cbSkip;
        private CheckBox cbCF;
    }
}
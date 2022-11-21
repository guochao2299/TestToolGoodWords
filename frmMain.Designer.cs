namespace TestToolGoodWords
{
    partial class frmMain
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
            this.btnFFC = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnFFC);
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
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnFFC
            // 
            this.btnFFC.Location = new System.Drawing.Point(785, 45);
            this.btnFFC.Name = "btnFFC";
            this.btnFFC.Size = new System.Drawing.Size(94, 29);
            this.btnFFC.TabIndex = 4;
            this.btnFFC.Text = "文本转换";
            this.btnFFC.UseVisualStyleBackColor = true;
            this.btnFFC.Click += new System.EventHandler(this.btnFFC_Click);
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
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "设置搜索词：";
            // 
            // txtResearchWord
            // 
            this.txtResearchWord.Location = new System.Drawing.Point(118, 47);
            this.txtResearchWord.Name = "txtResearchWord";
            this.txtResearchWord.Size = new System.Drawing.Size(621, 27);
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
            this.splitContainer2.Size = new System.Drawing.Size(990, 462);
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
            this.lstResult.Size = new System.Drawing.Size(270, 462);
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
            this.txtContent.Size = new System.Drawing.Size(716, 462);
            this.txtContent.TabIndex = 0;
            this.txtContent.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 549);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
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
        private Button btnFFC;
    }
}
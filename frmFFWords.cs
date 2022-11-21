using ToolGood.Words;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TestToolGoodWords
{
    public partial class frmFFWords : Form
    {
        public frmFFWords()
        {
            InitializeComponent();
        }

        private void ResetSelectTextFormat()
        {
            if (lstResult.Items.Count <= 0)
            {
                return;
            }

            foreach(ListViewItem lvi in lstResult.Items)
            {
                IllegalWordsSearchResult result = lvi.Tag as IllegalWordsSearchResult;

                txtContent.Select(result.Start, result.End - result.Start + 1);
                txtContent.SelectionFont = txtContent.Font;
                txtContent.SelectionBackColor = txtContent.BackColor;
            }
        }

        private List<string> m_blackList = new List<string>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetSelectTextFormat();
            lstResult.Items.Clear();
            m_blackList.Clear();

            IllegalWordsSearch ws = new IllegalWordsSearch();            
            ws.UseIgnoreCase = cbIngoreCase.Checked;
            ws.UseSkipWordFilter = cbSkip.Checked;
            ws.UseDuplicateWordFilter = cbCF.Checked;
            ws.SetKeywords(txtResearchWord.Text.Split(';', '£»'));
            ws.SetSkipWords(txtSkipWords.Text);
            if(!string.IsNullOrEmpty(txtBlackList.Text))
            {
                m_blackList.AddRange(txtBlackList.Text.Split(';', '£»'));
                List<int> blackListType = new List<int>();
                for(int i=0;i<m_blackList.Count;i++)
                {
                    blackListType.Add(i);
                }

                ws.SetBlacklist(blackListType.ToArray());
            }
            
            List<IllegalWordsSearchResult> results = ws.FindAll(txtContent.Text);

            for(int i=0;i<results.Count;i++)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(i + 1));
                lvi.SubItems.Add(results[i].MatchKeyword);
                //lvi.SubItems.Add(string.Format("Î»ÖÃ£º{0}~{1}", results[i].Start, results[i].End));
                lvi.SubItems.Add(m_blackList[results[i].BlacklistType]);
                lvi.Tag = results[i];
                lstResult.Items.Add(lvi);

                txtContent.Select(results[i].Start, results[i].End-results[i].Start+1);
                txtContent.SelectionFont = new Font(txtContent.SelectionFont,FontStyle.Underline|FontStyle.Bold);
                txtContent.SelectionBackColor = Color.LightBlue;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                txtFile.Text = ofd.FileName;
                lstResult.Items.Clear();
                txtContent.Text = String.Empty;

                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        txtContent.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstResult.SelectedItems.Count<=0)
            {
                return;
            }

            IllegalWordsSearchResult result = lstResult.SelectedItems[0].Tag as IllegalWordsSearchResult;
            txtContent.SelectionStart = result.Start;
            txtContent.ScrollToCaret();
        }
    }
}
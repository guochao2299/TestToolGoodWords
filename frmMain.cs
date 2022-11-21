using ToolGood.Words;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TestToolGoodWords
{
    public partial class frmMain : Form
    {
        public frmMain()
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
                WordsSearchResult result = lvi.Tag as WordsSearchResult;

                txtContent.Select(result.Start, result.End - result.Start + 1);
                txtContent.SelectionFont = txtContent.Font;
                txtContent.SelectionBackColor = txtContent.BackColor;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetSelectTextFormat();
            lstResult.Items.Clear();            

            WordsSearch ws = new WordsSearch();
            ws.SetKeywords(txtResearchWord.Text.Split(';','£»'));
            List<WordsSearchResult> results = ws.FindAll(txtContent.Text);

            for(int i=0;i<results.Count;i++)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(i + 1));
                lvi.SubItems.Add(results[i].MatchKeyword);
                lvi.SubItems.Add(string.Format("Î»ÖÃ£º{0}~{1}", results[i].Start, results[i].End));
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

            WordsSearchResult result = lstResult.SelectedItems[0].Tag as WordsSearchResult;
            txtContent.SelectionStart = result.Start;
            txtContent.ScrollToCaret();
        }

        private void btnFFC_Click(object sender, EventArgs e)
        {
            frmWordHelper fw = new frmWordHelper();
            fw.Show();
        }
    }
}
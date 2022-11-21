using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolGood.Words;

using System.Speech.Synthesis;


namespace TestToolGoodWords
{
    public partial class frmWordHelper : Form
    {
        public frmWordHelper()
        {
            InitializeComponent();
        }

        private void btnJ2F_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.ToTraditionalChinese(txtSrc.Text);
        }

        private void btnF2J_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.ToSimplifiedChinese(txtSrc.Text);
        }

        private void btn2QJ_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.ToSBC(txtSrc.Text);
        }

        private void btn2BJ_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.ToDBC(txtSrc.Text);
        }

        private void btn2No_Click(object sender, EventArgs e)
        {
            txtDest.Text = Convert.ToString(WordsHelper.ToNumber(txtSrc.Text));
        }

        private void btn2ZW_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.ToChineseRMB(double.Parse(txtSrc.Text));
        }

        private void btn2PinY_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.GetPinyin(txtSrc.Text,cbTone.Checked);            

            // 实例化 SpeechSynthesizer.  
            if (cbAutoSpeak.Checked)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.SpeakAsync(txtSrc.Text);
            }            
        }

        private void btnContentCheck_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("全部英语：" + (WordsHelper.IsAllEnglish(txtSrc.Text) ? "√" : "×"));
            sb.AppendLine("含有英语：" + (WordsHelper.HasEnglish(txtSrc.Text) ? "√" : "×"));
            sb.AppendLine("全为中文：" + (WordsHelper.IsAllChinese(txtSrc.Text) ? "√" : "×"));
            sb.AppendLine("含有中文：" + (WordsHelper.HasChinese(txtSrc.Text) ? "√" : "×"));

            MessageBox.Show(sb.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDest.Text = WordsHelper.GetFirstPinyin(txtSrc.Text);
        }
    }
}

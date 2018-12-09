using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Ruby_Tool
{
    public partial class FrmMain : Form
    {
        Encoding curEncoding;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CBEncoding.SelectedIndex = 0;
        }

        private void CBEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            curEncoding = Encoding.GetEncoding(CBEncoding.SelectedItem.ToString());
            string rubyText = GenerateRubyFormatText();
            TBOutput.Text = rubyText;
        }

        private void TBRuby_TextChanged(object sender, EventArgs e)
        {
            string rubyText = GenerateRubyFormatText();
            TBOutput.Text = rubyText;
        }

        private void TBText_TextChanged(object sender, EventArgs e)
        {
            string rubyText = GenerateRubyFormatText();
            TBOutput.Text = rubyText;
        }

        private void CBTop_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
                TopMost = true;
            else
                TopMost = false;
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode== Keys.C)
            {
                CopyTextOutput();
            }
        }

        private void TBOutput_TextChanged(object sender, EventArgs e)
        {
            CopyTextOutput();
        }

        private void BtnCpy_Click(object sender, EventArgs e)
        {
            CopyTextOutput();
        }

        private void CopyTextOutput()
        {
            try
            {
                Clipboard.SetText(TBOutput.Text);
                LblInfo.ForeColor = System.Drawing.Color.Black;
                LblInfo.Text = "复制到剪切板成功";
            }
            catch(Exception ex)
            {
                LblInfo.ForeColor = System.Drawing.Color.Red;
                LblInfo.Text = "复制到剪切板失败";
            }
        }

        public string GenerateRubyFormatText()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

            binaryWriter.Write((short)curEncoding.GetByteCount(TBText.Text));
            binaryWriter.Write((short)curEncoding.GetByteCount(TBRuby.Text));
            binaryWriter.Write(curEncoding.GetBytes(TBRuby.Text));
            
            var data = BitConverter.ToString(memoryStream.ToArray()).Replace("-", "");
            var result = TBFmt.Text
                .Replace("{class}", TBClassName.Text)
                .Replace("{group}", TBGroupName.Text)
                .Replace("{data}", data);
            return result;
        }

        private void BtnExchange_Click(object sender, EventArgs e)
        {
            var tmp = TBRuby.Text;
            TBRuby.Text = TBText.Text;
            TBText.Text = tmp;
        }
    }
}

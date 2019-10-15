using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VijinerTableSymbl_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string FName = openFileDialog1.FileName;

            CodeTB.Text = "";
            DecodeTB.Text = "";
            
            int LengthF = System.IO.File.ReadAllLines(FName).Length;
            for (int i = 0; i < LengthF; i++)
            {
                string temp = System.IO.File.ReadLines(FName).Skip(i).FirstOrDefault();
                if (FName[FName.Length - 5] == 'd')
                {
                    DecodeTB.Text += temp;
                }
                else if (FName[FName.Length - 5] == 'c')
                {
                    CodeTB.Text += temp;
                }
                else return;
            }
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            string DecodeText = DecodeTB.Text;
            int DecodeTextLength = DecodeText.Length;

            string KeyText = KeyTB.Text;
            int n = KeyTB.Text.Length;
            
            if (DecodeTextLength % n != 0)
            {
                int addSpace = n - DecodeTextLength % n;
                for(int i = 0; i < addSpace; ++i)
                {
                    DecodeTB.Text += ' ';
                }
            }

            for (int i = 0; i < DecodeTextLength - 1; i += n)
            {
                for (int j = 0; j < n; j++)
                {
                    int NewChar = (Convert.ToInt32(DecodeText[i + j]) + Convert.ToInt32(KeyText[j])) % 65536;
                    CodeTB.Text += Convert.ToChar(NewChar);
                }
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            string CodeText = CodeTB.Text;
            int CodeTextLength = CodeText.Length;

            string KeyText = KeyTB.Text;
            int n = KeyTB.Text.Length;

            if (CodeTextLength % n != 0)
            {
                int addSpace = n - CodeTextLength % n;
                for (int i = 0; i < addSpace; ++i)
                {
                    CodeTB.Text += ' ';
                }
            }

            for (int i = 0; i < CodeTextLength - 1; i += n)
            {
                for (int j = 0; j < n; j++)
                {
                    int NewChar = (Convert.ToInt32(CodeText[i + j]) - Convert.ToInt32(KeyText[j]));
                    if (NewChar < 0) NewChar += 65536;
                    DecodeTB.Text += Convert.ToChar(NewChar);
                }
            }
        }
    }
}

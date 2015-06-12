using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyDiary
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {
        }

        // 次を検索
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string inputText = form1.richTextBox1.Text;
            string findText = textBox1.Text;
            if (checkBox1.Checked == true)
            {
                // 大文字小文字を区別する
                int findIndex = inputText.IndexOf(findText);
                while (findIndex >= 0)
                {
                    form1.richTextBox1.SelectionStart = findIndex;
                    int nextIndex = findIndex + findText.Length;
                    if (nextIndex < inputText.Length)
                    {
                        findIndex = inputText.IndexOf(findText, nextIndex);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                // 区別しない
                int findIndex = inputText.IndexOf(findText, StringComparison.OrdinalIgnoreCase);
                while (findIndex >= 0)
                {
                    form1.richTextBox1.SelectionStart = findIndex;
                    int nextIndex = findIndex + findText.Length;
                    if (nextIndex < inputText.Length)
                    {
                        findIndex = inputText.IndexOf(findText, nextIndex, StringComparison.OrdinalIgnoreCase);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //MessageBox.Show(findText + " が見つかりません。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 出すタイミングが分からない
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        // キャンセル
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

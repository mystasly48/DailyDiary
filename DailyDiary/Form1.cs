using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;

namespace DailyDiary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime dtNow = DateTime.Now;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 新規作成だけじゃなくて確認や保存も必要みたいなのであとで
        }

        private void 開くCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "テキストファイル|*.txt|全てのファイル|*.*";
            openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 開き直すRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 履歴を保存する処理とか追加する必要があるからかなりあとでの実装になる
        }

        private void 再読み込みLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // リフレッシュでいいかな
            richTextBox1.Refresh();
        }

        private void 上書き保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 上書きってどうやるんですか
        }

        private void 名前を付けて保存AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.DefaultExt = "+.txt";
            saveFileDialog1.Filter = "テキストファイル|*.txt|全てのファイル|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void ページ設定UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog(); //たぶんこれだけじゃダメ
        }

        private void 印刷PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog(); //たぶんこれだけじゃダメ
        }

        private void 印刷プレビューToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog(); //たぶんこれだけじゃダメ
        }

        private void 保存して終了EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 保存の処理が必要
            Application.Exit();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 確認の処理が必要
            Application.Exit();
        }

        private void 元に戻すUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void やり直しRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 切り取りTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼り付けPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 削除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void すべて選択AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 日付と時刻DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += dtNow;
        }

        private void 検索FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Findフォームで検索内容を取得して検索の処理を行う
            Find findForm = new Find();
            findForm.Show();
            //this.Enabled = false; //trueに戻すタイミングが分からない
        }

        private void 次を検索NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 検索と同じような仕組みで
            //FindNext.ShowDialog();
        }

        private void 置換RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 検索と同じような仕組みで
            //Replace.ShowDialog();
        }

        private void 行へ移動GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 検索と同じような仕組みで
            //GoTo.ShowDialog();
        }

        private void 右端で折り返すWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (右端で折り返すWToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = false;
                右端で折り返すWToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                右端で折り返すWToolStripMenuItem.Checked = true;
            }
        }

        private void フォントFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void ヘルプの表示HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // オンラインヘルプの提供場所がない
            Process.Start("");
        }

        private void 作者のHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://mystasly48.web.fc2.com/");
        }

        private void 作者のBlogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://mystasly.blog.jp/");
        }

        private void 作者のTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/30msl");
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mystasly48");
        }

        private void バージョン情報AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

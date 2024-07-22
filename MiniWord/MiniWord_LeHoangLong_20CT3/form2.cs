using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWord_LeHoangLong_20CT3
{
    public partial class form2 : Form
    {
        private RichTextBox rtxbContent;
        private int startIndex = 0;

        public form2(RichTextBox rtxbContent)
        {
            InitializeComponent();
            this.rtxbContent = rtxbContent;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = cbFind.Text;

            // Thực hiện tìm kiếm trong RichTextBox
            if (!string.IsNullOrEmpty(keyword))
            {
                int index = rtxbContent.Find(keyword, startIndex, RichTextBoxFinds.MatchCase);

                if (index != -1)
                {
                    // Highlight từ khóa tìm kiếm nếu được tìm thấy
                    rtxbContent.SelectionStart = index;
                    rtxbContent.SelectionLength = keyword.Length;
                    rtxbContent.Focus();
                    startIndex = index + keyword.Length;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy từ khóa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string keyword = cbFind.Text;
            string replaceText = cbReplace.Text;

            // Thực hiện tìm kiếm trong RichTextBox
            if (!string.IsNullOrEmpty(keyword))
            {
                int index = rtxbContent.Find(keyword, startIndex, RichTextBoxFinds.MatchCase);

                if (index != -1)
                {
                    // Highlight từ khóa tìm kiếm nếu được tìm thấy
                    rtxbContent.SelectionStart = index;
                    rtxbContent.SelectionLength = keyword.Length;
                    rtxbContent.SelectedText = replaceText;
                    rtxbContent.Focus();
                    startIndex = index + keyword.Length;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy từ khóa.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            startIndex = 0;
            string keyword = cbFind.Text;
            string replaceText = cbReplace.Text;

            // Thực hiện tìm kiếm trong RichTextBox
            if (!string.IsNullOrEmpty(keyword))
            {
                while (true)
                {
                    int index = rtxbContent.Find(keyword, startIndex, RichTextBoxFinds.MatchCase);

                    if (index != -1)
                    {
                        // Highlight từ khóa tìm kiếm nếu được tìm thấy
                        rtxbContent.SelectionStart = index;
                        rtxbContent.SelectionLength = keyword.Length;
                        rtxbContent.SelectedText = replaceText;
                        rtxbContent.Focus();
                        startIndex = index + keyword.Length;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy từ khóa.");
                    }

                    if (startIndex > rtxbContent.TextLength)
                        return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

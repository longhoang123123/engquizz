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
    public partial class FrmLong : Form
    {
        string filePath = "";

        public FrmLong()
        {
            InitializeComponent();
        }

        private void InitializeUI()
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Copy();
        }

        private void pasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Paste();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Redo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Cut();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                rtxbContent.Font = f.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                rtxbContent.ForeColor = c.Color;
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtxbContent.WordWrap == true)
            {
                wordWrapToolStripMenuItem.Checked = false;
                rtxbContent.WordWrap = false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                rtxbContent.WordWrap = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLong frmLong = new FrmLong();
            frmLong.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                rtxbContent.LoadFile(filePath, RichTextBoxStreamType.RichText);
            }
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                rtxbContent.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Visible = false;
            closeToolStripMenuItem. Enabled = false;
            saveASToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem. Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            fontToolStripMenuItem.Enabled = false;
            colorToolStripMenuItem.Enabled = false;
            wordWrapToolStripMenuItem.Enabled = false;
            toolStrip1.Enabled = false;
            tsbEmoji.Enabled = false;
            toolStripButton11.Enabled = false;


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            save();
            
        }

        private void save()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                saveAs();
            }
            else
            {
                rtxbContent.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
        }

        private void FrmLong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu lại thay đổi hay không ?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                save();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtxbContent.SelectionColor = colorDialog.Color;
            }    
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Image image = Image.FromFile(filePath);
                insertImage(image);
            }
        }

        private void insertImage(Image image)
        {
            Clipboard.SetImage(image);
            rtxbContent.Paste();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            rtxbContent.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtxbContent.SelectionBackColor = colorDialog.Color;
            }
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxbContent.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxbContent.Redo();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxbContent.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtxbContent.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxbContent.Paste();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            form2 findAndReplaceForm = new form2(rtxbContent);
            findAndReplaceForm.StartPosition = FormStartPosition.CenterScreen;
            findAndReplaceForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void tsbZoomIn_Click(object sender, EventArgs e)
        {
            float fontSize = rtxbContent.SelectionFont.Size;
            fontSize += 2; // Increase the font size by 2 points
            UpdateFontSize(fontSize);
        }

        private void tsbZoomOut_Click(object sender, EventArgs e)
        {
            float fontSize = rtxbContent.SelectionFont.Size;
            if (fontSize > 2)
            {
                fontSize -= 2; // Decrease the font size by 2 points
                UpdateFontSize(fontSize);
            }
        }

        private void UpdateFontSize(float fontSize)
        {
            rtxbContent.Font = new System.Drawing.Font("Arial", fontSize);
        }

        private void tsbEmoji_Click(object sender, EventArgs e)
        {
            pnlEmoji.Visible = !pnlEmoji.Visible;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Image image = button.BackgroundImage;
            insertImage(image);
        }
    }
}

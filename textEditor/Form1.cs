using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace textEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }
        }

        private void fontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            }
        }

        private void textColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.ForeColor = colorDialog.Color;
            }
        }

        private void cutClipboardOp_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void copyClipboardOp_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void pasteClipboardOp_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
          
        }

        private void OpenStripLabel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveStripLabel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }

        }

        private void CutStripLabel_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void copyStripLabel_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void pasteStripLabel_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void fontStripLabel_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog.Font;
            }
        }

        private void colorStripLabel_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtEditor.ForeColor = colorDialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEditor.TextChanged += new EventHandler(txtEditor_TextChanged);
            statusLabel.Text = "Words : 0";
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            string text = txtEditor.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                statusLabel.Text = "Words: 0";
                return;
            }
            int wordCount = txtEditor.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            statusLabel.Text = "Words: " + wordCount.ToString();
        }

        private void newFileDialog_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }
    }
}

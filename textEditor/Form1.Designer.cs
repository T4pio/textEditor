namespace textEditor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFileDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutClipboardOp = new System.Windows.Forms.ToolStripMenuItem();
            this.copyClipboardOp = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteClipboardOp = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.SaveStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.CutStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.copyStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pasteStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.colorStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileDialog,
            this.openFileDialog,
            this.saveFileDialog,
            this.printDialog,
            this.exitFileDialog});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileDialog
            // 
            this.newFileDialog.Name = "newFileDialog";
            this.newFileDialog.Size = new System.Drawing.Size(180, 22);
            this.newFileDialog.Text = "New";
            this.newFileDialog.Click += new System.EventHandler(this.newFileDialog_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Name = "openFileDialog";
            this.openFileDialog.Size = new System.Drawing.Size(180, 22);
            this.openFileDialog.Text = "Open";
            this.openFileDialog.Click += new System.EventHandler(this.openFileDialog_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Name = "saveFileDialog";
            this.saveFileDialog.Size = new System.Drawing.Size(180, 22);
            this.saveFileDialog.Text = "Save";
            this.saveFileDialog.Click += new System.EventHandler(this.saveFileDialog_Click);
            // 
            // printDialog
            // 
            this.printDialog.Name = "printDialog";
            this.printDialog.Size = new System.Drawing.Size(180, 22);
            this.printDialog.Text = "Print";
            // 
            // exitFileDialog
            // 
            this.exitFileDialog.Name = "exitFileDialog";
            this.exitFileDialog.Size = new System.Drawing.Size(180, 22);
            this.exitFileDialog.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutClipboardOp,
            this.copyClipboardOp,
            this.pasteClipboardOp});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutClipboardOp
            // 
            this.cutClipboardOp.Name = "cutClipboardOp";
            this.cutClipboardOp.Size = new System.Drawing.Size(102, 22);
            this.cutClipboardOp.Text = "Cut";
            this.cutClipboardOp.Click += new System.EventHandler(this.cutClipboardOp_Click);
            // 
            // copyClipboardOp
            // 
            this.copyClipboardOp.Name = "copyClipboardOp";
            this.copyClipboardOp.Size = new System.Drawing.Size(102, 22);
            this.copyClipboardOp.Text = "Copy";
            this.copyClipboardOp.Click += new System.EventHandler(this.copyClipboardOp_Click);
            // 
            // pasteClipboardOp
            // 
            this.pasteClipboardOp.Name = "pasteClipboardOp";
            this.pasteClipboardOp.Size = new System.Drawing.Size(102, 22);
            this.pasteClipboardOp.Text = "Paste";
            this.pasteClipboardOp.Click += new System.EventHandler(this.pasteClipboardOp_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontDialog,
            this.textColorDialog});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontDialog
            // 
            this.fontDialog.Name = "fontDialog";
            this.fontDialog.Size = new System.Drawing.Size(127, 22);
            this.fontDialog.Text = "Font";
            this.fontDialog.Click += new System.EventHandler(this.fontDialog_Click);
            // 
            // textColorDialog
            // 
            this.textColorDialog.Name = "textColorDialog";
            this.textColorDialog.Size = new System.Drawing.Size(127, 22);
            this.textColorDialog.Text = "Text Color";
            this.textColorDialog.Click += new System.EventHandler(this.textColorDialog_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStripLabel,
            this.SaveStripLabel,
            this.CutStripLabel,
            this.copyStripLabel,
            this.pasteStripLabel,
            this.fontStripLabel,
            this.colorStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(668, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(61, 426);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenStripLabel
            // 
            this.OpenStripLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.OpenStripLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenStripLabel.Name = "OpenStripLabel";
            this.OpenStripLabel.Size = new System.Drawing.Size(58, 15);
            this.OpenStripLabel.Text = "Open";
            this.OpenStripLabel.Click += new System.EventHandler(this.OpenStripLabel_Click);
            // 
            // SaveStripLabel
            // 
            this.SaveStripLabel.Name = "SaveStripLabel";
            this.SaveStripLabel.Size = new System.Drawing.Size(58, 15);
            this.SaveStripLabel.Text = "Save";
            this.SaveStripLabel.Click += new System.EventHandler(this.SaveStripLabel_Click);
            // 
            // CutStripLabel
            // 
            this.CutStripLabel.Name = "CutStripLabel";
            this.CutStripLabel.Size = new System.Drawing.Size(58, 15);
            this.CutStripLabel.Text = "Cut";
            this.CutStripLabel.Click += new System.EventHandler(this.CutStripLabel_Click);
            // 
            // copyStripLabel
            // 
            this.copyStripLabel.Name = "copyStripLabel";
            this.copyStripLabel.Size = new System.Drawing.Size(58, 15);
            this.copyStripLabel.Text = "Copy";
            this.copyStripLabel.Click += new System.EventHandler(this.copyStripLabel_Click);
            // 
            // pasteStripLabel
            // 
            this.pasteStripLabel.Name = "pasteStripLabel";
            this.pasteStripLabel.Size = new System.Drawing.Size(58, 15);
            this.pasteStripLabel.Text = "Paste";
            this.pasteStripLabel.Click += new System.EventHandler(this.pasteStripLabel_Click);
            // 
            // fontStripLabel
            // 
            this.fontStripLabel.Name = "fontStripLabel";
            this.fontStripLabel.Size = new System.Drawing.Size(58, 15);
            this.fontStripLabel.Text = "Font";
            this.fontStripLabel.Click += new System.EventHandler(this.fontStripLabel_Click);
            // 
            // colorStripLabel
            // 
            this.colorStripLabel.Name = "colorStripLabel";
            this.colorStripLabel.Size = new System.Drawing.Size(58, 15);
            this.colorStripLabel.Text = "Text Color";
            this.colorStripLabel.Click += new System.EventHandler(this.colorStripLabel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(199, 17);
            this.statusLabel.Text = "safasfsaf";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 24);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(668, 404);
            this.txtEditor.TabIndex = 3;
            this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem printDialog;
        private System.Windows.Forms.ToolStripMenuItem exitFileDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutClipboardOp;
        private System.Windows.Forms.ToolStripMenuItem copyClipboardOp;
        private System.Windows.Forms.ToolStripMenuItem pasteClipboardOp;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontDialog;
        private System.Windows.Forms.ToolStripMenuItem textColorDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel OpenStripLabel;
        private System.Windows.Forms.ToolStripLabel SaveStripLabel;
        private System.Windows.Forms.ToolStripLabel CutStripLabel;
        private System.Windows.Forms.ToolStripLabel copyStripLabel;
        private System.Windows.Forms.ToolStripLabel pasteStripLabel;
        private System.Windows.Forms.ToolStripLabel fontStripLabel;
        private System.Windows.Forms.ToolStripLabel colorStripLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}


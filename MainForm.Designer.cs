namespace Syllabr
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.clipboardLabel = new System.Windows.Forms.Label();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.countSyllabcesButton = new System.Windows.Forms.ToolStripButton();
            this.countSymbolsButton = new System.Windows.Forms.ToolStripButton();
            this.clipboardMonitor1 = new Syllabr.ClipboardMonitor();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // clipboardLabel
            // 
            this.clipboardLabel.AutoSize = true;
            this.clipboardLabel.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardLabel.Location = new System.Drawing.Point(22, 43);
            this.clipboardLabel.Name = "clipboardLabel";
            this.clipboardLabel.Size = new System.Drawing.Size(140, 43);
            this.clipboardLabel.TabIndex = 0;
            this.clipboardLabel.Text = "No text";
            this.clipboardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countSyllabcesButton,
            this.countSymbolsButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolStrip.Size = new System.Drawing.Size(235, 31);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // countSyllabcesButton
            // 
            this.countSyllabcesButton.Checked = true;
            this.countSyllabcesButton.CheckOnClick = true;
            this.countSyllabcesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countSyllabcesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.countSyllabcesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSyllabcesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countSyllabcesButton.Margin = new System.Windows.Forms.Padding(0, 2, 4, 4);
            this.countSyllabcesButton.Name = "countSyllabcesButton";
            this.countSyllabcesButton.Size = new System.Drawing.Size(56, 25);
            this.countSyllabcesButton.Text = "Слоги";
            this.countSyllabcesButton.Click += new System.EventHandler(this.countSyllabcesButton_Click);
            // 
            // countSymbolsButton
            // 
            this.countSymbolsButton.CheckOnClick = true;
            this.countSymbolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.countSymbolsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSymbolsButton.Image = ((System.Drawing.Image)(resources.GetObject("countSymbolsButton.Image")));
            this.countSymbolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countSymbolsButton.Margin = new System.Windows.Forms.Padding(0, 2, 0, 4);
            this.countSymbolsButton.Name = "countSymbolsButton";
            this.countSymbolsButton.Size = new System.Drawing.Size(80, 25);
            this.countSymbolsButton.Text = "Символы";
            this.countSymbolsButton.Click += new System.EventHandler(this.countSymbolsButton_Click);
            // 
            // clipboardMonitor1
            // 
            this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
            this.clipboardMonitor1.Location = new System.Drawing.Point(160, 63);
            this.clipboardMonitor1.Name = "clipboardMonitor1";
            this.clipboardMonitor1.Size = new System.Drawing.Size(75, 23);
            this.clipboardMonitor1.TabIndex = 1;
            this.clipboardMonitor1.Text = "clipboardMonitor1";
            this.clipboardMonitor1.Visible = false;
            this.clipboardMonitor1.ClipboardChanged += new System.EventHandler<Syllabr.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 97);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.clipboardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Syllabr";
            this.TopMost = true;
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clipboardLabel;
        private ClipboardMonitor clipboardMonitor1;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton countSyllabcesButton;
        private System.Windows.Forms.ToolStripButton countSymbolsButton;
    }
}


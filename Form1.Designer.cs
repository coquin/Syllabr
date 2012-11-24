namespace Syllabr
{
    partial class Form1
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
            this.clipboardLabel = new System.Windows.Forms.Label();
            this.clipboardMonitor1 = new Syllabr.ClipboardMonitor();
            this.SuspendLayout();
            // 
            // clipboardLabel
            // 
            this.clipboardLabel.AutoSize = true;
            this.clipboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardLabel.Location = new System.Drawing.Point(24, 28);
            this.clipboardLabel.Name = "clipboardLabel";
            this.clipboardLabel.Size = new System.Drawing.Size(187, 26);
            this.clipboardLabel.TabIndex = 0;
            this.clipboardLabel.Text = "No text captured";
            this.clipboardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clipboardMonitor1
            // 
            this.clipboardMonitor1.BackColor = System.Drawing.Color.Red;
            this.clipboardMonitor1.Location = new System.Drawing.Point(27, 63);
            this.clipboardMonitor1.Name = "clipboardMonitor1";
            this.clipboardMonitor1.Size = new System.Drawing.Size(75, 23);
            this.clipboardMonitor1.TabIndex = 1;
            this.clipboardMonitor1.Text = "clipboardMonitor1";
            this.clipboardMonitor1.Visible = false;
            this.clipboardMonitor1.ClipboardChanged += new System.EventHandler<Syllabr.ClipboardChangedEventArgs>(this.clipboardMonitor1_ClipboardChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 97);
            this.Controls.Add(this.clipboardMonitor1);
            this.Controls.Add(this.clipboardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Syllabr";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clipboardLabel;
        private ClipboardMonitor clipboardMonitor1;
    }
}


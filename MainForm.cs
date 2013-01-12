using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syllabr
{
    public partial class MainForm : Form
    {
        private SyllableCounter syllableCounter = new SyllableCounter();

        public MainForm()
        {
            InitializeComponent();
            setLabelText(Clipboard.GetText(TextDataFormat.UnicodeText));
        }

        private void setLabelText(string txt="")
        {
            int count;

            try
            {
                if (txt.Length > 0)
                {
                    count = syllableCounter.count(txt);

                    clipboardLabel.Text = syllableCounter.language + ": " + count.ToString();
                }
                else
                {
                    clipboardLabel.Text = "No text captured!";
                }
            }
            catch (Exception)
            {
                clipboardLabel.Text = "No text captured!";
            }
        }

        private void clipboardMonitor1_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.UnicodeText))
            {
                setLabelText((string)e.DataObject.GetData(DataFormats.UnicodeText));
            }
            else
            {
                clipboardLabel.Text = "No text captured!";
            }
        }
    }
}

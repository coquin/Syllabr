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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setLabelText(Clipboard.GetText());
        }

        private void setLabelText(string txt="")
        {
            if (txt != null && txt.Length > 0)
            {
                clipboardLabel.Text = txt;
            }
            else
            {
                clipboardLabel.Text = "No text captured";
            }
        }

        private void clipboardMonitor1_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            setLabelText((string)e.DataObject.GetData(DataFormats.Text));
        }
    }
}

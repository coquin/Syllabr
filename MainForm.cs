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
        private IStringCounter counter;
        private SyllableCounter syllableCounter = new SyllableCounter();
        private SymbolCounter symbolCounter = new SymbolCounter();
        private string text = "";

        private const string noTextMessage = "No text";

        public MainForm()
        {
            counter = syllableCounter;

            InitializeComponent();
            text = Clipboard.GetText(TextDataFormat.UnicodeText);
            setLabelText();
        }

        private void setLabelText()
        {
            int count;

            try
            {
                if (text.Length > 0)
                {
                    count = counter.count(text);

                    clipboardLabel.Text = counter.language + ": " + count.ToString();
                }
                else
                {
                    clipboardLabel.Text = noTextMessage;
                }
            }
            catch (Exception)
            {
                clipboardLabel.Text = noTextMessage;
            }
        }

        private void clipboardMonitor1_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.UnicodeText))
            {
                text = (string)e.DataObject.GetData(DataFormats.UnicodeText);
                setLabelText();
            }
            else
            {
                text = "";
                clipboardLabel.Text = noTextMessage;
            }
        }

        private void countSyllabcesButton_Click(object sender, EventArgs e)
        {
            countSymbolsButton.Checked = false;
            counter = syllableCounter;
            setLabelText();
        }

        private void countSymbolsButton_Click(object sender, EventArgs e)
        {
            countSyllabcesButton.Checked = false;
            counter = symbolCounter;
            setLabelText();
        }
    }
}

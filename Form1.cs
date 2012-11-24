using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syllabr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setLabelText(Clipboard.GetText(TextDataFormat.UnicodeText));
        }

        private void setLabelText(string txt="")
        {
            if (txt != null && txt.Length > 0)
            {
                clipboardLabel.Text = detectLanguage(txt);
            }
            else
            {
                clipboardLabel.Text = "No text captured";
            }
        }

        // Определяет язык текстового фрагмента
        // Пока по тупому ищет гласные русского языка, если находит, то считает,
        // что имеет дело с русским языком, в противном случае - с английским
        private string detectLanguage(string txt)
        {
            Regex rgx = new Regex(@"[аеёиоуыэюя]", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if (rgx.IsMatch(txt))
            {
                return "RUS";
            }
            else
            {
                return "ENG";
            }
        }

        private void clipboardMonitor1_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            setLabelText((string)e.DataObject.GetData(DataFormats.UnicodeText));
        }
    }
}

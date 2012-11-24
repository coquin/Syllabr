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
            string lng;
            int count;

            try
            {
                if (txt.Length > 0)
                {
                    lng = detectLanguage(txt);

                    if (lng == "RUS")
                    {
                        count = countRus(txt);
                    }
                    else
                    {
                        count = countEng(txt);
                    }

                    clipboardLabel.Text = lng + ": " + count.ToString();
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

        // Вычисляет число слогов в русском тексте
        // Просто считает число гласных
        private int countRus(string txt)
        {
            Regex rgx = new Regex(@"[аеёиоуыэюя]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(txt);
            return matches.Count;
        }

        // Вычисляет число слогов в английском тексте
        private int countEng(string txt)
        {
            Regex replaceRgx = new Regex(@"\by", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex syllabesRgx = new Regex(@"cion|tion|sion|eau|iou|ae|ai|ay|au|ee|ea|ei|eu|ey|ie|oa|oe|oi|oo|ou|oy|ue|ui|[aueioy]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex eAtEndRgx = new Regex(@"e\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex wordsRgx = new Regex(@"\b[wbmhnrs]e\b|\bthe\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            txt = replaceRgx.Replace(txt, "");

            MatchCollection syllabesMatches = syllabesRgx.Matches(txt);
            MatchCollection eAtEndMatches = eAtEndRgx.Matches(txt);
            MatchCollection wordsMatches = wordsRgx.Matches(txt);

            return syllabesMatches.Count - eAtEndMatches.Count + wordsMatches.Count;
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

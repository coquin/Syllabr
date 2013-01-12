﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            setLabelText(Clipboard.GetText(TextDataFormat.UnicodeText));
        }

        private SyllableCounterRUS counterRUS = new SyllableCounterRUS();
        private SyllableCounterENG counterENG = new SyllableCounterENG();

        private ISyllableCounter counter;

        private void setLabelText(string txt="")
        {
            string lng;

            try
            {
                if (txt.Length > 0)
                {
                    lng = detectLanguage(txt);

                    if (lng == "RUS")
                    {
                        counter = counterRUS;
                    }
                    else
                    {
                        counter = counterENG;
                    }

                    clipboardLabel.Text = lng + ": " + counter.count(txt).ToString();
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

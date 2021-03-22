using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Balgaran
{
    public partial class Index : Form
    {
        Dictionary<string, string> letters = new Dictionary<string, string>();

        string title = string.Empty;
        string author = string.Empty;
        string publisher = string.Empty;
        string year = string.Empty;
        string pagesCount = string.Empty;
        string isbn = string.Empty;
        string input = string.Empty;

        public Index()
        {
            InitializeComponent();

            letters.Add("а", "a");
            letters.Add("б", "b");
            letters.Add("в", "v");
            letters.Add("г", "g");
            letters.Add("д", "d");
            letters.Add("е", "e");
            letters.Add("ё", "yo");
            letters.Add("ж", "zh");
            letters.Add("з", "z");
            letters.Add("и", "i");
            letters.Add("й", "j");
            letters.Add("к", "k");
            letters.Add("л", "l");
            letters.Add("м", "m");
            letters.Add("н", "n");
            letters.Add("о", "o");
            letters.Add("п", "p");
            letters.Add("р", "r");
            letters.Add("с", "s");
            letters.Add("т", "t");
            letters.Add("у", "u");
            letters.Add("ф", "f");
            letters.Add("х", "h");
            letters.Add("ц", "c");
            letters.Add("ч", "ch");
            letters.Add("ш", "sh");
            letters.Add("щ", "sch");
            letters.Add("ъ", "j");
            letters.Add("ы", "i");
            letters.Add("ь", "j");
            letters.Add("э", "e");
            letters.Add("ю", "yu");
            letters.Add("я", "ya");
            letters.Add(" ", "-");
            letters.Add("\"", "");
            letters.Add(".", "");
            letters.Add(",", "");
            letters.Add("(", "");
            letters.Add(")", "");
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var bookInfo = "\n\n";

            if (title != string.Empty)
            {
                SetURL();
            }

            if (author != string.Empty)
            {
                bookInfo = bookInfo + "Автор: " + author + Environment.NewLine;
            }

            if (publisher != string.Empty)
            {
                bookInfo = bookInfo + "Издателство: " + publisher + Environment.NewLine;
            }

            if (year != string.Empty)
            {
                bookInfo = bookInfo + "Година: " + year + Environment.NewLine;
            }

            if (pagesCount != string.Empty)
            {
                bookInfo = bookInfo + "Брой страници: " + pagesCount + Environment.NewLine;
            }

            if (comboBoxCover != null)
            {
                bookInfo = bookInfo + "Корица: " + comboBoxCover.SelectedItem.ToString() + Environment.NewLine;
            }

            if (isbn != string.Empty)
            {
                bookInfo = bookInfo + "ISBN: " + isbn + Environment.NewLine;
            }

            var shopInfo = "Поръчайте книгата \"" + title + "\" на издателство " + publisher + " доставка в чужбина на balgaran.co.uk. Открийте най-големия каталог от книги на български език с доставка в цял свят.";

            buttonCopyBookInfo.Text = bookInfo;
            buttonCopyShopInfo.Text = shopInfo;
            buttonCopyISBN.Text = isbn;
            buttonPublisher.Text = publisher;

            buttonSetTitle.Text = "Заглавие";
            buttonSetAuthor.Text = "Автор";
            buttonSetPublisher.Text = "Издателство";
            buttonSetYear.Text = "Година";
            buttonSetPagesCount.Text = "Страници";
            comboBoxCover.ResetText();
            buttonISBN.Text = "ISBN";

            title = string.Empty;
            author = string.Empty;
            publisher = string.Empty;
            year = string.Empty;
            pagesCount = string.Empty;
            isbn = string.Empty;

            Clipboard.SetText(buttonCopyBookInfo.Text);
        }

        private void SetURL()
        {
            var url = title;
            url += author;
            url += comboBoxCover.SelectedItem.ToString();
            url = url.ToLower();

            foreach (KeyValuePair<string, string> pair in letters)
            {
                url = url.Replace(pair.Key, pair.Value);
            }

            buttonURL.Text = url;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCopyBookInfo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonCopyBookInfo.Text);
        }

        private void buttonCopyShopInfo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonCopyShopInfo.Text);
        }

        private void richTextBoxShopInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCopyISBN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonCopyISBN.Text);
        }

        private void buttonPublisher_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonPublisher.Text);
        }

        private void buttonCopyHS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonCopyHS.Text);
        }

        private void richTextBoxBookInfoScanner_TextChanged(object sender, EventArgs e)
        {
            var text = richTextBoxBookInfoScanner.Text.Split(Environment.NewLine, StringSplitOptions.None);

            var textCopy = richTextBoxBookInfoScanner.Text.Split('\n');

            title = textCopy[0];
            buttonSetTitle.Text = textCopy[0];

            if (!textCopy[1].Contains("Цена"))
            {
                author = textCopy[1];
                buttonSetAuthor.Text = textCopy[1];
            }

            foreach (var line in textCopy)
            {
                SetPublisher(line);

                SetCover(line);

                SetPrice(line);

                SetWeight(line);
            }

            foreach (var line in text)
            {

                // Year
                string patternYear = @"\W*((?i)Издадена(?-i))\W*((?i)[0-9-]*(?-i))";
                var matchYear = Regex.Match(line, patternYear);
                year = matchYear.Groups[2].Value;
                buttonSetYear.Text = year;

                // PagesCount
                string patternPagesCount = @"(Страници)(\s+)([0-9-]*)";
                var matchPagesCount = Regex.Match(line, patternPagesCount);
                pagesCount = matchPagesCount.Groups[3].Value;
                buttonSetPagesCount.Text = pagesCount;

                // ISBN
                string patternISBN = @"(ISBN)(\s+)([0-9-]*)";
                var matchISBN = Regex.Match(line, patternISBN);
                isbn = matchISBN.Groups[3].Value;
                buttonISBN.Text = isbn;
            }
        }

        private void SetWeight(string line)
        {
            if (line.Contains("Тегло"))
            {
                var weightString = line;

                var forbiddenSymbol = new[]
                {
                        "Тегло\t\t",
                        " kg",
                    };

                foreach (var symbol in forbiddenSymbol)
                {
                    weightString = weightString.Replace(symbol, string.Empty);
                }

                var weight = Convert.ToDouble(weightString, CultureInfo.InvariantCulture) + 0.05;

                buttonWeightCopy.Text = weight.ToString(new CultureInfo("en-US"));
            }
        }

        private void SetPrice(string line)
        {
            var forbiddenSymbol = new[]
            {
                "Стандартна цена ",
                "Цена: ",
                " лв.",
            };

            if (richTextBoxBookInfoScanner.Text.Contains(forbiddenSymbol[0]) && line.Contains(forbiddenSymbol[0]))
            {
                var price = line;

                foreach (var symbol in forbiddenSymbol)
                {
                    price = price.Replace(symbol, string.Empty);
                }

                buttonPrice.Text = price;
            }

            if (line.Contains("Цена") && !richTextBoxBookInfoScanner.Text.Contains(forbiddenSymbol[0]) && !line.Contains("доставка"))
            {
                var price = line;

                foreach (var symbol in forbiddenSymbol)
                {
                    price = price.Replace(symbol, string.Empty);
                }

                buttonPrice.Text = price;
            }
        }

        private void SetCover(string line)
        {
            if (line.Contains("Корица"))
            {
                var cover = line.Replace("Корица\t\t", string.Empty);

                comboBoxCover.Text = cover;
            }
        }

        private void SetPublisher(string line)
        {
            if (line.Contains("Издателство"))
            {
                publisher = line.Replace("Издателство\t\t", string.Empty);

                buttonSetPublisher.Text = publisher;
            }
        }

        private void buttonPasteInfo_Click(object sender, EventArgs e)
        {
            richTextBoxBookInfoScanner.Text = Clipboard.GetText();
        }

        private void buttonWeightCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonWeightCopy.Text);

            buttonWeightCopy.Text = "Тегло";
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonPrice.Text);
            buttonPrice.Text = "Цена";
        }

        private void buttonURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonURL.Text);
            buttonURL.Text = "Адрес";
        }

        private void buttonSetTitle_Click(object sender, EventArgs e)
        {
            title = Clipboard.GetText();
            buttonSetTitle.Text = title;
        }

        private void buttonSetAuthor_Click(object sender, EventArgs e)
        {
            author = Clipboard.GetText();
            buttonSetAuthor.Text = author;
        }

        private void buttonSetPublisher_Click(object sender, EventArgs e)
        {
            publisher = Clipboard.GetText();
            buttonSetPublisher.Text = publisher;
        }

        private void buttonSetYear_Click(object sender, EventArgs e)
        {
            year = Clipboard.GetText();
            buttonSetYear.Text = year;
        }

        private void buttonSetPagesCount_Click(object sender, EventArgs e)
        {
            pagesCount = Clipboard.GetText();
            buttonSetPagesCount.Text = pagesCount;
        }

        private void buttonISBN_Click(object sender, EventArgs e)
        {
            isbn = Clipboard.GetText();
            buttonISBN.Text = isbn;
        }
    }
}

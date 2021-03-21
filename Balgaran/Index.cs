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
            var bookInfo = string.Empty;

            if (textBoxTitle.Text != null)
            {
                SetURL();
            }

            if (textBoxAuthor.Text != null)
            {
                bookInfo = bookInfo + "Автор: " + textBoxAuthor.Text + Environment.NewLine;
            }

            if (textBoxPublisher.Text != null)
            {
                bookInfo = bookInfo + "Издателство: " + textBoxPublisher.Text + Environment.NewLine;
            }

            if (textBoxYear.Text != null)
            {
                bookInfo = bookInfo + "Година: " + textBoxYear.Text + Environment.NewLine;
            }

            if (textBoxPagesCount != null)
            {
                bookInfo = bookInfo + "Брой страници: " + textBoxPagesCount.Text + Environment.NewLine;
            }

            if (comboBoxCover != null)
            {
                bookInfo = bookInfo + "Корица: " + comboBoxCover.SelectedItem.ToString() + Environment.NewLine;
            }

            if (textBoxISBN != null)
            {
                bookInfo = bookInfo + "ISBN: " + textBoxISBN.Text + Environment.NewLine;
            }

            var shopInfo = "Поръчайте книгата \"" + textBoxTitle.Text + "\" на издателство " + textBoxPublisher.Text + " доставка в чужбина на balgaran.co.uk. Открийте най-големия каталог от книги на български език с доставка в цял свят.";

            richTextBoxBookInfo.Text = bookInfo;
            richTextBoxShopInfo.Text = shopInfo;
            textBoxISBNCopy.Text = textBoxISBN.Text;
            textBoxPublisherCopy.Text = textBoxPublisher.Text;

            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxPublisher.Clear();
            textBoxYear.Clear();
            textBoxPagesCount.Clear();
            comboBoxCover.ResetText();
            textBoxISBN.Clear();

            Clipboard.SetText(richTextBoxBookInfo.Text);
        }

        private void SetURL()
        {
            var url = textBoxTitle.Text;
            url += " " + textBoxAuthor.Text;
            url += " " + comboBoxCover.SelectedItem.ToString();
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
            Clipboard.SetText(richTextBoxBookInfo.Text);
        }

        private void buttonCopyShopInfo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxShopInfo.Text);
        }

        private void richTextBoxShopInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCopyISBN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxISBNCopy.Text);
        }

        private void buttonPublisher_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxPublisherCopy.Text);
        }

        private void buttonCopyHS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttonCopyHS.Text);
        }

        private void richTextBoxBookInfoScanner_TextChanged(object sender, EventArgs e)
        {
            var text = richTextBoxBookInfoScanner.Text.Split(Environment.NewLine, StringSplitOptions.None);

            var textCopy = richTextBoxBookInfoScanner.Text.Split('\n');

            textBoxTitle.Text = textCopy[0];

            if (!textCopy[1].Contains("Цена"))
            {
                textBoxAuthor.Text = textCopy[1];
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
                textBoxYear.Text = matchYear.Groups[2].Value;

                // PagesCount
                string patternPagesCount = @"(Страници)(\s+)([0-9-]*)";
                var matchPagesCount = Regex.Match(line, patternPagesCount);
                textBoxPagesCount.Text = matchPagesCount.Groups[3].Value;

                // ISBN
                string patternISBN = @"(ISBN)(\s+)([0-9-]*)";
                var matchISBN = Regex.Match(line, patternISBN);
                textBoxISBN.Text = matchISBN.Groups[3].Value;

                // Weight
                //string patternWeight = @"(Тегло)(\s+)([0-9.-]*)";
                //var matchWeight = Regex.Match(line, patternWeight);

                //var weight = Convert.ToDouble(matchWeight.Groups[3].Value, CultureInfo.InvariantCulture) + 0.05;

                //textBoxWeight.Text = weight.ToString(new CultureInfo("en-US"));

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
                var publisher = line.Replace("Издателство\t\t", string.Empty);

                textBoxPublisher.Text = publisher;
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
    }
}

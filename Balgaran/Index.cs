using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Balgaran
{
    public partial class Index : Form
    {

        public Index()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var bookInfo = string.Empty;

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
                bookInfo = bookInfo + "Корица: " + comboBoxCover.Text + Environment.NewLine;
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
            textBoxISBN.Clear();
            richTextBoxBookInfoScanner.Clear();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            textBoxHS.Text = "490199";
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
            Clipboard.SetText(textBoxHS.Text);
        }

        private void richTextBoxBookInfoScanner_TextChanged(object sender, EventArgs e)
        {
            var text = richTextBoxBookInfoScanner.Text.Split(Environment.NewLine, StringSplitOptions.None);

            foreach (var line in text)
            {
                if (line.Contains(" Издателство"))
                {
                    // Publisher
                    string patternPublisher = @"(Издателство)(\s+)(\W*)";
                    var matchPublisher = Regex.Match(line, patternPublisher);
                    textBoxPublisher.Text = matchPublisher.Groups[3].Value;
                }

                    

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
                string patternWeight = @"(Тегло)(\s+)([0-9.-]*)";
                var matchWeight = Regex.Match(line, patternWeight);

                var weight = Convert.ToDouble(matchWeight.Groups[3].Value, CultureInfo.InvariantCulture) + 0.05;

                textBoxWeight.Text = weight.ToString(new CultureInfo("en-US"));

            }        
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBoxBookInfoScanner.Text = Clipboard.GetText();
        }
    }
}

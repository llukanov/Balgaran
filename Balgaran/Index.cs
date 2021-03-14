using System;
using System.Windows.Forms;

namespace Balgaran
{
    public partial class INdex : Form
    {
        public INdex()
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

            if (textBoxCover != null)
            {
                bookInfo = bookInfo + "Корица: " + textBoxCover.Text + Environment.NewLine;
            }

            if (textBoxISBN != null)
            {
                bookInfo = bookInfo + "ISBN: " + textBoxISBN.Text + Environment.NewLine;
            }

            var shopInfo = "Поръчайте книгата \"" + textBoxTitle.Text + "\" на издателство " + textBoxPublisher.Text + " доставка в чужбина на balgaran.co.uk. Открийте най-големия каталог от книги на български език с доставка в цял свят.";

            richTextBoxBookInfo.Text = bookInfo;
            richTextBoxShopInfo.Text = shopInfo;

            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxPublisher.Clear();
            textBoxYear.Clear();
            textBoxPagesCount.Clear();
            textBoxCover.Clear();
            textBoxISBN.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}

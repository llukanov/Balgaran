
namespace Balgaran
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopyBookInfo = new System.Windows.Forms.Button();
            this.buttonCopyShopInfo = new System.Windows.Forms.Button();
            this.buttonCopyISBN = new System.Windows.Forms.Button();
            this.buttonPublisher = new System.Windows.Forms.Button();
            this.buttonCopyHS = new System.Windows.Forms.Button();
            this.richTextBoxBookInfoScanner = new System.Windows.Forms.RichTextBox();
            this.buttonWeightCopy = new System.Windows.Forms.Button();
            this.comboBoxCover = new System.Windows.Forms.ComboBox();
            this.buttonPasteInfo = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.buttonURL = new System.Windows.Forms.Button();
            this.buttonSetTitle = new System.Windows.Forms.Button();
            this.buttonSetAuthor = new System.Windows.Forms.Button();
            this.buttonSetPublisher = new System.Windows.Forms.Button();
            this.buttonSetYear = new System.Windows.Forms.Button();
            this.buttonSetPagesCount = new System.Windows.Forms.Button();
            this.buttonISBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonGenerate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(94, 276);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(129, 38);
            this.buttonGenerate.TabIndex = 12;
            this.buttonGenerate.Text = "Генерирай";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCopyBookInfo
            // 
            this.buttonCopyBookInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCopyBookInfo.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyBookInfo.Location = new System.Drawing.Point(241, 9);
            this.buttonCopyBookInfo.Name = "buttonCopyBookInfo";
            this.buttonCopyBookInfo.Size = new System.Drawing.Size(238, 115);
            this.buttonCopyBookInfo.TabIndex = 17;
            this.buttonCopyBookInfo.Text = "Описание";
            this.buttonCopyBookInfo.UseVisualStyleBackColor = false;
            this.buttonCopyBookInfo.Click += new System.EventHandler(this.buttonCopyBookInfo_Click);
            // 
            // buttonCopyShopInfo
            // 
            this.buttonCopyShopInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCopyShopInfo.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyShopInfo.Location = new System.Drawing.Point(241, 225);
            this.buttonCopyShopInfo.Name = "buttonCopyShopInfo";
            this.buttonCopyShopInfo.Size = new System.Drawing.Size(238, 68);
            this.buttonCopyShopInfo.TabIndex = 18;
            this.buttonCopyShopInfo.Text = "Поръчайте";
            this.buttonCopyShopInfo.UseVisualStyleBackColor = false;
            this.buttonCopyShopInfo.Click += new System.EventHandler(this.buttonCopyShopInfo_Click);
            // 
            // buttonCopyISBN
            // 
            this.buttonCopyISBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCopyISBN.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyISBN.Location = new System.Drawing.Point(323, 130);
            this.buttonCopyISBN.Name = "buttonCopyISBN";
            this.buttonCopyISBN.Size = new System.Drawing.Size(156, 40);
            this.buttonCopyISBN.TabIndex = 20;
            this.buttonCopyISBN.Text = "ISBN";
            this.buttonCopyISBN.UseVisualStyleBackColor = false;
            this.buttonCopyISBN.Click += new System.EventHandler(this.buttonCopyISBN_Click);
            // 
            // buttonPublisher
            // 
            this.buttonPublisher.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPublisher.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPublisher.Location = new System.Drawing.Point(241, 348);
            this.buttonPublisher.Name = "buttonPublisher";
            this.buttonPublisher.Size = new System.Drawing.Size(238, 37);
            this.buttonPublisher.TabIndex = 22;
            this.buttonPublisher.Text = "Издателство";
            this.buttonPublisher.UseVisualStyleBackColor = false;
            this.buttonPublisher.Click += new System.EventHandler(this.buttonPublisher_Click);
            // 
            // buttonCopyHS
            // 
            this.buttonCopyHS.BackColor = System.Drawing.Color.Chocolate;
            this.buttonCopyHS.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyHS.Location = new System.Drawing.Point(340, 180);
            this.buttonCopyHS.Name = "buttonCopyHS";
            this.buttonCopyHS.Size = new System.Drawing.Size(139, 39);
            this.buttonCopyHS.TabIndex = 24;
            this.buttonCopyHS.Text = "490199";
            this.buttonCopyHS.UseVisualStyleBackColor = false;
            this.buttonCopyHS.Click += new System.EventHandler(this.buttonCopyHS_Click);
            // 
            // richTextBoxBookInfoScanner
            // 
            this.richTextBoxBookInfoScanner.Location = new System.Drawing.Point(12, 321);
            this.richTextBoxBookInfoScanner.Name = "richTextBoxBookInfoScanner";
            this.richTextBoxBookInfoScanner.Size = new System.Drawing.Size(211, 64);
            this.richTextBoxBookInfoScanner.TabIndex = 25;
            this.richTextBoxBookInfoScanner.Text = "";
            this.richTextBoxBookInfoScanner.TextChanged += new System.EventHandler(this.richTextBoxBookInfoScanner_TextChanged);
            // 
            // buttonWeightCopy
            // 
            this.buttonWeightCopy.BackColor = System.Drawing.Color.Aqua;
            this.buttonWeightCopy.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWeightCopy.Location = new System.Drawing.Point(241, 179);
            this.buttonWeightCopy.Name = "buttonWeightCopy";
            this.buttonWeightCopy.Size = new System.Drawing.Size(93, 40);
            this.buttonWeightCopy.TabIndex = 27;
            this.buttonWeightCopy.Text = "Тегло";
            this.buttonWeightCopy.UseVisualStyleBackColor = false;
            this.buttonWeightCopy.Click += new System.EventHandler(this.buttonWeightCopy_Click);
            // 
            // comboBoxCover
            // 
            this.comboBoxCover.FormattingEnabled = true;
            this.comboBoxCover.Items.AddRange(new object[] {
            "Мека",
            "Твърда"});
            this.comboBoxCover.Location = new System.Drawing.Point(11, 188);
            this.comboBoxCover.Name = "comboBoxCover";
            this.comboBoxCover.Size = new System.Drawing.Size(212, 28);
            this.comboBoxCover.TabIndex = 28;
            // 
            // buttonPasteInfo
            // 
            this.buttonPasteInfo.BackColor = System.Drawing.Color.Crimson;
            this.buttonPasteInfo.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPasteInfo.Location = new System.Drawing.Point(14, 276);
            this.buttonPasteInfo.Name = "buttonPasteInfo";
            this.buttonPasteInfo.Size = new System.Drawing.Size(74, 39);
            this.buttonPasteInfo.TabIndex = 29;
            this.buttonPasteInfo.Text = "Store";
            this.buttonPasteInfo.UseVisualStyleBackColor = false;
            this.buttonPasteInfo.Click += new System.EventHandler(this.buttonPasteInfo_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonPrice.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPrice.Location = new System.Drawing.Point(241, 130);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(76, 40);
            this.buttonPrice.TabIndex = 31;
            this.buttonPrice.Text = "Цена";
            this.buttonPrice.UseVisualStyleBackColor = false;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonURL
            // 
            this.buttonURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonURL.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonURL.Location = new System.Drawing.Point(241, 299);
            this.buttonURL.Name = "buttonURL";
            this.buttonURL.Size = new System.Drawing.Size(238, 39);
            this.buttonURL.TabIndex = 32;
            this.buttonURL.Text = "Адрес";
            this.buttonURL.UseVisualStyleBackColor = false;
            this.buttonURL.Click += new System.EventHandler(this.buttonURL_Click);
            // 
            // buttonSetTitle
            // 
            this.buttonSetTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetTitle.Location = new System.Drawing.Point(10, 5);
            this.buttonSetTitle.Name = "buttonSetTitle";
            this.buttonSetTitle.Size = new System.Drawing.Size(213, 36);
            this.buttonSetTitle.TabIndex = 33;
            this.buttonSetTitle.Text = "Заглавие";
            this.buttonSetTitle.UseVisualStyleBackColor = false;
            this.buttonSetTitle.Click += new System.EventHandler(this.buttonSetTitle_Click);
            // 
            // buttonSetAuthor
            // 
            this.buttonSetAuthor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetAuthor.Location = new System.Drawing.Point(11, 45);
            this.buttonSetAuthor.Name = "buttonSetAuthor";
            this.buttonSetAuthor.Size = new System.Drawing.Size(212, 29);
            this.buttonSetAuthor.TabIndex = 34;
            this.buttonSetAuthor.Text = "Автор";
            this.buttonSetAuthor.UseVisualStyleBackColor = false;
            this.buttonSetAuthor.Click += new System.EventHandler(this.buttonSetAuthor_Click);
            // 
            // buttonSetPublisher
            // 
            this.buttonSetPublisher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetPublisher.Location = new System.Drawing.Point(12, 80);
            this.buttonSetPublisher.Name = "buttonSetPublisher";
            this.buttonSetPublisher.Size = new System.Drawing.Size(211, 32);
            this.buttonSetPublisher.TabIndex = 35;
            this.buttonSetPublisher.Text = "Издателство";
            this.buttonSetPublisher.UseVisualStyleBackColor = false;
            this.buttonSetPublisher.Click += new System.EventHandler(this.buttonSetPublisher_Click);
            // 
            // buttonSetYear
            // 
            this.buttonSetYear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetYear.Location = new System.Drawing.Point(12, 115);
            this.buttonSetYear.Name = "buttonSetYear";
            this.buttonSetYear.Size = new System.Drawing.Size(211, 32);
            this.buttonSetYear.TabIndex = 36;
            this.buttonSetYear.Text = "Година";
            this.buttonSetYear.UseVisualStyleBackColor = false;
            this.buttonSetYear.Click += new System.EventHandler(this.buttonSetYear_Click);
            // 
            // buttonSetPagesCount
            // 
            this.buttonSetPagesCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetPagesCount.Location = new System.Drawing.Point(12, 153);
            this.buttonSetPagesCount.Name = "buttonSetPagesCount";
            this.buttonSetPagesCount.Size = new System.Drawing.Size(211, 29);
            this.buttonSetPagesCount.TabIndex = 37;
            this.buttonSetPagesCount.Text = "Страници";
            this.buttonSetPagesCount.UseVisualStyleBackColor = false;
            this.buttonSetPagesCount.Click += new System.EventHandler(this.buttonSetPagesCount_Click);
            // 
            // buttonISBN
            // 
            this.buttonISBN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonISBN.Location = new System.Drawing.Point(12, 223);
            this.buttonISBN.Name = "buttonISBN";
            this.buttonISBN.Size = new System.Drawing.Size(211, 38);
            this.buttonISBN.TabIndex = 38;
            this.buttonISBN.Text = "ISBN";
            this.buttonISBN.UseVisualStyleBackColor = false;
            this.buttonISBN.Click += new System.EventHandler(this.buttonISBN_Click);
            // 
            // Index
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 394);
            this.Controls.Add(this.buttonISBN);
            this.Controls.Add(this.buttonSetPagesCount);
            this.Controls.Add(this.buttonSetYear);
            this.Controls.Add(this.buttonSetPublisher);
            this.Controls.Add(this.buttonSetAuthor);
            this.Controls.Add(this.buttonSetTitle);
            this.Controls.Add(this.buttonURL);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.buttonPasteInfo);
            this.Controls.Add(this.comboBoxCover);
            this.Controls.Add(this.buttonWeightCopy);
            this.Controls.Add(this.richTextBoxBookInfoScanner);
            this.Controls.Add(this.buttonCopyHS);
            this.Controls.Add(this.buttonPublisher);
            this.Controls.Add(this.buttonCopyISBN);
            this.Controls.Add(this.buttonCopyShopInfo);
            this.Controls.Add(this.buttonCopyBookInfo);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "Index";
            this.Text = "z";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopyBookInfo;
        private System.Windows.Forms.Button buttonCopyShopInfo;
        private System.Windows.Forms.Button buttonCopyISBN;
        private System.Windows.Forms.Button buttonPublisher;
        private System.Windows.Forms.Button buttonCopyHS;
        private System.Windows.Forms.RichTextBox richTextBoxBookInfoScanner;
        private System.Windows.Forms.Button buttonWeightCopy;
        private System.Windows.Forms.ComboBox comboBoxCover;
        private System.Windows.Forms.Button buttonPasteInfo;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.Button buttonURL;
        private System.Windows.Forms.Button buttonSetTitle;
        private System.Windows.Forms.Button buttonSetAuthor;
        private System.Windows.Forms.Button buttonSetPublisher;
        private System.Windows.Forms.Button buttonSetYear;
        private System.Windows.Forms.Button buttonSetPagesCount;
        private System.Windows.Forms.Button buttonISBN;
    }
}


namespace lab8
{
	partial class Form1
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
            txtISBN = new TextBox();
            label1 = new Label();
            btnFetchBook = new Button();
            txtBookDetails = new TextBox();
            btnSearchAuthor = new Button();
            txtAuthorSearch = new TextBox();
            listBoxBooks = new ListBox();
            btnPrevApiPage = new Button();
            btnNextApiPage = new Button();
            lblPageNumber = new Label();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Anchor = AnchorStyles.None;
            txtISBN.Location = new Point(12, 33);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(159, 23);
            txtISBN.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "ISBN:";
            // 
            // btnFetchBook
            // 
            btnFetchBook.Anchor = AnchorStyles.None;
            btnFetchBook.Location = new Point(177, 33);
            btnFetchBook.Name = "btnFetchBook";
            btnFetchBook.Size = new Size(95, 23);
            btnFetchBook.TabIndex = 2;
            btnFetchBook.Text = "Fetch Book";
            btnFetchBook.UseVisualStyleBackColor = true;
            btnFetchBook.Click += btnFetchBook_Click;
            // 
            // txtBookDetails
            // 
            txtBookDetails.Anchor = AnchorStyles.None;
            txtBookDetails.Location = new Point(12, 67);
            txtBookDetails.Multiline = true;
            txtBookDetails.Name = "txtBookDetails";
            txtBookDetails.Size = new Size(260, 200);
            txtBookDetails.TabIndex = 3;
            // 
            // btnSearchAuthor
            // 
            btnSearchAuthor.Anchor = AnchorStyles.None;
            btnSearchAuthor.Location = new Point(474, 33);
            btnSearchAuthor.Name = "btnSearchAuthor";
            btnSearchAuthor.Size = new Size(95, 23);
            btnSearchAuthor.TabIndex = 5;
            btnSearchAuthor.Text = "Search Author";
            btnSearchAuthor.UseVisualStyleBackColor = true;
            btnSearchAuthor.Click += btnSearchAuthor_Click;
            // 
            // txtAuthorSearch
            // 
            txtAuthorSearch.Anchor = AnchorStyles.None;
            txtAuthorSearch.Location = new Point(309, 33);
            txtAuthorSearch.Name = "txtAuthorSearch";
            txtAuthorSearch.Size = new Size(159, 23);
            txtAuthorSearch.TabIndex = 4;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Anchor = AnchorStyles.None;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(309, 67);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(260, 199);
            listBoxBooks.TabIndex = 6;
            // 
            // btnPrevApiPage
            // 
            btnPrevApiPage.Anchor = AnchorStyles.None;
            btnPrevApiPage.Location = new Point(309, 272);
            btnPrevApiPage.Name = "btnPrevApiPage";
            btnPrevApiPage.Size = new Size(95, 23);
            btnPrevApiPage.TabIndex = 7;
            btnPrevApiPage.Text = "Previous Page";
            btnPrevApiPage.UseVisualStyleBackColor = true;
            btnPrevApiPage.Click += btnPrevApiPage_Click;
            // 
            // btnNextApiPage
            // 
            btnNextApiPage.Anchor = AnchorStyles.None;
            btnNextApiPage.Location = new Point(474, 272);
            btnNextApiPage.Name = "btnNextApiPage";
            btnNextApiPage.Size = new Size(95, 23);
            btnNextApiPage.TabIndex = 8;
            btnNextApiPage.Text = "Next Page";
            btnNextApiPage.UseVisualStyleBackColor = true;
            btnNextApiPage.Click += btnNextApiPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.Anchor = AnchorStyles.None;
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(416, 276);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(41, 15);
            lblPageNumber.TabIndex = 9;
            lblPageNumber.Text = "Page 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(577, 312);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNextApiPage);
            Controls.Add(btnPrevApiPage);
            Controls.Add(listBoxBooks);
            Controls.Add(btnSearchAuthor);
            Controls.Add(txtAuthorSearch);
            Controls.Add(txtBookDetails);
            Controls.Add(btnFetchBook);
            Controls.Add(label1);
            Controls.Add(txtISBN);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtISBN;
        private Label label1;
        private Button btnFetchBook;
        private TextBox txtBookDetails;
        private Button btnSearchAuthor;
        private TextBox txtAuthorSearch;
        private ListBox listBoxBooks;
        private Button btnPrevApiPage;
        private Button btnNextApiPage;
        private Label lblPageNumber;
    }
}

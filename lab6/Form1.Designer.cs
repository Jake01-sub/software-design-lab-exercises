namespace lab6
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
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnSearchBooks = new Button();
            txtSearchTitle = new TextBox();
            progressBar = new ProgressBar();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Anchor = AnchorStyles.None;
            btnFetchBooks.Location = new Point(81, 325);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(106, 33);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.Anchor = AnchorStyles.None;
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(12, 60);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(252, 259);
            listBoxBooks.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Anchor = AnchorStyles.None;
            txtAuthorName.Location = new Point(301, 30);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(145, 23);
            txtAuthorName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(301, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 3;
            label1.Text = "Author's Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(301, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Book Title:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Anchor = AnchorStyles.None;
            txtBookTitle.Location = new Point(301, 80);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(145, 23);
            txtBookTitle.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.None;
            btnAddBook.Location = new Point(322, 119);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(106, 33);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(301, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Book ID:";
            // 
            // txtBookID
            // 
            txtBookID.Anchor = AnchorStyles.None;
            txtBookID.Location = new Point(301, 189);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(145, 23);
            txtBookID.TabIndex = 7;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Anchor = AnchorStyles.None;
            btnSearchBooks.Location = new Point(194, 26);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(70, 27);
            btnSearchBooks.TabIndex = 9;
            btnSearchBooks.Text = "Search";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Anchor = AnchorStyles.None;
            txtSearchTitle.Location = new Point(12, 28);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(175, 23);
            txtSearchTitle.TabIndex = 10;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.None;
            progressBar.Location = new Point(12, 7);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(252, 15);
            progressBar.TabIndex = 11;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Anchor = AnchorStyles.None;
            btnUpdateBook.Location = new Point(322, 227);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(106, 33);
            btnUpdateBook.TabIndex = 12;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.None;
            btnDeleteBook.Location = new Point(322, 275);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(106, 33);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(464, 381);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(progressBar);
            Controls.Add(txtSearchTitle);
            Controls.Add(btnSearchBooks);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtBookTitle);
            Controls.Add(label1);
            Controls.Add(txtAuthorName);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private TextBox txtAuthorName;
        private Label label1;
        private Label label2;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label label3;
        private TextBox txtBookID;
        private Button btnSearchBooks;
        private TextBox txtSearchTitle;
        private ProgressBar progressBar;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
    }
}

namespace lab7
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
            listBoxBooks = new ListBox();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            lblPageNumber = new Label();
            label1 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            lbl1 = new Label();
            btnAddBook = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(12, 46);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(310, 334);
            listBoxBooks.TabIndex = 0;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(12, 386);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(101, 26);
            btnPreviousPage.TabIndex = 1;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(221, 386);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(101, 26);
            btnNextPage.TabIndex = 2;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(145, 390);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(47, 17);
            lblPageNumber.TabIndex = 3;
            lblPageNumber.Text = "Page 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Author Name:";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(342, 46);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(145, 23);
            txtAuthorName.TabIndex = 5;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(342, 99);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(145, 23);
            txtBookTitle.TabIndex = 7;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(342, 81);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(62, 15);
            lbl1.TabIndex = 6;
            lbl1.Text = "Book Title:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(369, 132);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(93, 26);
            btnAddBook.TabIndex = 8;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(630, 461);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(lbl1);
            Controls.Add(txtAuthorName);
            Controls.Add(label1);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNextPage);
            Controls.Add(btnPreviousPage);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Label lblPageNumber;
        private Label label1;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Label lbl1;
        private Button btnAddBook;
    }
}

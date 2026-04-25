namespace lab5
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
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            btnShowBooks = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            txtSearchAuthor = new TextBox();
            btnSearchBooks = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtAuthorName.Location = new Point(164, 140);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(211, 29);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtBookTitle.Location = new Point(164, 194);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(211, 29);
            txtBookTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 143);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 2;
            label1.Text = "Author's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 199);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 3;
            label2.Text = "Book Title";
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(441, 74);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(347, 364);
            listBoxBooks.TabIndex = 4;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(68, 268);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(127, 46);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowBooks.Location = new Point(216, 268);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(127, 46);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 89);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 8;
            label3.Text = "Book ID";
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtBookID.Location = new Point(164, 86);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(211, 29);
            txtBookID.TabIndex = 7;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBook.Location = new Point(68, 340);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(127, 46);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteBook.Location = new Point(216, 340);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(127, 46);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // txtSearchAuthor
            // 
            txtSearchAuthor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtSearchAuthor.Location = new Point(441, 29);
            txtSearchAuthor.Name = "txtSearchAuthor";
            txtSearchAuthor.Size = new Size(211, 29);
            txtSearchAuthor.TabIndex = 11;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBooks.Location = new Point(661, 29);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(127, 29);
            btnSearchBooks.TabIndex = 12;
            btnSearchBooks.Text = "Search by Author";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearchBooks);
            Controls.Add(txtSearchAuthor);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnShowBooks);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore System";
            Click += btnAddBook_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Label label1;
        private Label label2;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Button btnShowBooks;
        private Label label3;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private TextBox txtSearchAuthor;
        private Button btnSearchBooks;
    }
}

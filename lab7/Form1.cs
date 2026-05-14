using lab5;
using Microsoft.EntityFrameworkCore;
using static lab5.Form1;

namespace lab7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Set the number of records per page
		private const int pageSize = 10;
		private int currentPage = 1;

		// Asynchronous method to fetch a specific page of books
		public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
		{
			using (var context = new BookstoreContext())
			{
				// Skip records and take the next pageSize records for the current page
				var books = await context.Books
										 .Include(b => b.Author)
										 .OrderBy(b => b.BookID)
										 .Skip((pageNumber - 1) * pageSize)
										 .Take(pageSize)
										 .Select(b => $"{b.Title} by {b.Author.Name}")
										 .ToListAsync();
				return books;
			}
		}

		// Button click event to load the next page of books
		private async void btnNextPage_Click(object sender, EventArgs e)
		{
			currentPage++;
			var books = await GetBooksByPageAsync(currentPage);
			listBoxBooks.DataSource = books;
			lblPageNumber.Text = $"Page {currentPage}";
		}

        // Button click event to load the previous page of books
        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page {currentPage}";
            }
            else
            {
                MessageBox.Show("You are already on the first page.");
            }
        }

		// Asynchronous method to save a new book and author with error handling
		public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
		{
			try
			{
				using (var context = new BookstoreContext())
				{
					var author = new Author { Name = authorName };
					var book = new Book { Title = bookTitle, Author = author };

					context.Authors.Add(author);
					context.Books.Add(book);

					// Save changes asynchronously
					await context.SaveChangesAsync();

					MessageBox.Show("Book and Author saved successfully!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}

		// Button click event to trigger saving with error handling
		private async void btnAddBook_Click(object sender, EventArgs e)
		{
			var authorName = txtAuthorName.Text;
			var bookTitle = txtBookTitle.Text;

			await SaveBookWithHandlingAsync(bookTitle, authorName);
		}
	}
}

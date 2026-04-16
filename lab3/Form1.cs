namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - File Size MB: {FileSizeMB}";
            }

        }

        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} [Subject: {Subject}]";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} by {Author} (Narrated by {Narrator}, {Duration} hrs)";
            }
        }

        private void ProcessBooks(Book[] bookstoreInventory)
        {
            lstBookTypes.Items.Clear();

            foreach (Book item in bookstoreInventory)
            {
                lstBookTypes.Items.Add(item.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };

            MessageBox.Show(myBook.GetInfo());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Book[] myInventory = new Book[]
            {
                new Book
                {
                    Title = "Rage of Angels",
                    Author = "Sidney Sheldon"
                },

                new Magazine
                {
                    Title = "Tech Weekly",
                    Author = "John Doe",
                    IssueNumber = 45
                },

                new Ebook
                {
                    Title = "C# Programming Guide",
                    Author = "Bob Johnson",
                    FileSizeMB = 5.2
                },

                new Textbook
                {
                    Title = "Introduction to Algorithms",
                    Author = "Thomas H. Cormen",
                    Subject = "Computer Science"
                },

                new AudioBook
                {
                    Title = "Project Hail Mary",
                    Author = "Andy Weir",
                    Narrator = "Ray Porter",
                    Duration = 16.2
                }
            };

            ProcessBooks(myInventory);
        }
    }
}

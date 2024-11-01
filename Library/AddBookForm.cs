using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Form
    {
        private readonly LibraryRepository _libraryRepository;

        public AddBookForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;

            var book = new Book(id, title, author);
            _libraryRepository.AddItem(book);
            MessageBox.Show("Book added successfully.");
            this.Close();
        }
    }
}

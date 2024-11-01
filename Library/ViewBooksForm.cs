using System;
using System.Windows.Forms;

namespace Library
{
    public partial class ViewBooksForm : Form
    {
        private readonly LibraryRepository _libraryRepository;

        public ViewBooksForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = _libraryRepository.GetAllItems();
            foreach (var item in books)
            {
                if (item is Book book)
                {
                    listBoxBooks.Items.Add(book.DisplayInfo());
                }
            }
        }
    }
}

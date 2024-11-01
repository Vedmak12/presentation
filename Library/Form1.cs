using System;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        private readonly LibraryRepository _libraryRepository;

        public MainForm()
        {
            InitializeComponent();
            _libraryRepository = new LibraryRepository();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(_libraryRepository);
            addBookForm.ShowDialog();
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            var addMemberForm = new AddMemberForm(_libraryRepository);
            addMemberForm.ShowDialog();
        }

        private void buttonLoanBook_Click(object sender, EventArgs e)
        {
            var loanBookForm = new LoanBookForm(_libraryRepository);
            loanBookForm.ShowDialog();
        }

        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            var viewBooksForm = new ViewBooksForm(_libraryRepository);
            viewBooksForm.ShowDialog();
        }
    }
}

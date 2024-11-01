using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddMemberForm : Form
    {
        private readonly LibraryRepository _libraryRepository;

        public AddMemberForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxMemberId.Text);
            string name = textBoxMemberName.Text;

            var member = new Member(id, name);
            _libraryRepository.AddMember(member);
            MessageBox.Show("Member added successfully.");
            this.Close();
        }
    }
}

namespace Library
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonLoanBook;
        private System.Windows.Forms.Button buttonViewBooks;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelcopyright;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonLoanBook = new System.Windows.Forms.Button();
            this.buttonViewBooks = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(300, 20);
            this.labelTitle.Size = new System.Drawing.Size(240, 32);
            this.labelTitle.Text = "Library Management System";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            


            // buttonAddBook
            this.buttonAddBook.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonAddBook.ForeColor = System.Drawing.Color.White;
            this.buttonAddBook.Location = new System.Drawing.Point(30, 300);
            this.buttonAddBook.Size = new System.Drawing.Size(200, 50);
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);

            // buttonAddMember
            this.buttonAddMember.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.buttonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMember.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonAddMember.ForeColor = System.Drawing.Color.White;
            this.buttonAddMember.Location = new System.Drawing.Point(280, 300);
            this.buttonAddMember.Size = new System.Drawing.Size(200, 50);
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = false;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);

            // buttonLoanBook
            this.buttonLoanBook.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.buttonLoanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoanBook.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonLoanBook.ForeColor = System.Drawing.Color.White;
            this.buttonLoanBook.Location = new System.Drawing.Point(530, 300);
            this.buttonLoanBook.Size = new System.Drawing.Size(200, 50);
            this.buttonLoanBook.Text = "Loan Book";
            this.buttonLoanBook.UseVisualStyleBackColor = false;
            this.buttonLoanBook.Click += new System.EventHandler(this.buttonLoanBook_Click);

            // buttonViewBooks
            this.buttonViewBooks.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.buttonViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewBooks.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonViewBooks.ForeColor = System.Drawing.Color.White;
            this.buttonViewBooks.Location = new System.Drawing.Point(780, 300);
            this.buttonViewBooks.Size = new System.Drawing.Size(200, 50);
            this.buttonViewBooks.Text = "View Books";
            this.buttonViewBooks.UseVisualStyleBackColor = false;
            this.buttonViewBooks.Click += new System.EventHandler(this.buttonViewBooks_Click);


            //labelcopyright
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelcopyright.Location = new System.Drawing.Point(300, 60);
            this.labelcopyright.Size = new System.Drawing.Size(240, 32);
            this.labelcopyright.Text = "Ved Jay Makhijani 104762184";
            //this.labelcopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // MainForm
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonLoanBook);
            this.Controls.Add(this.buttonViewBooks);
            this.Controls.Add(this.labelcopyright); 
            this.Text = "Library Management System";
            
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

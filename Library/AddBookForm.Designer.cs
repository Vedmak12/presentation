namespace Library
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelHeader;

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
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelHeader
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(80, 20);
            this.labelHeader.Text = "Add a Book";

            // labelId
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Arial", 10F);
            this.labelId.Location = new System.Drawing.Point(20, 70);
            this.labelId.Text = "Book ID:";

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.labelTitle.Location = new System.Drawing.Point(20, 110);
            this.labelTitle.Text = "Title:";

            // labelAuthor
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Arial", 10F);
            this.labelAuthor.Location = new System.Drawing.Point(20, 150);
            this.labelAuthor.Text = "Author:";

            // textBoxId
            this.textBoxId.Location = new System.Drawing.Point(100, 70);
            this.textBoxId.Size = new System.Drawing.Size(150, 20);

            // textBoxTitle
            this.textBoxTitle.Location = new System.Drawing.Point(100, 110);
            this.textBoxTitle.Size = new System.Drawing.Size(150, 20);

            // textBoxAuthor
            this.textBoxAuthor.Location = new System.Drawing.Point(100, 150);
            this.textBoxAuthor.Size = new System.Drawing.Size(150, 20);

            // buttonAdd
            this.buttonAdd.Text = "Add Book";
            this.buttonAdd.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(100, 200);
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // AddBookForm
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.buttonAdd);
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

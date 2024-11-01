namespace Library
{
    partial class ViewBooksForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxBooks;

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
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // listBoxBooks
            this.listBoxBooks.Location = new System.Drawing.Point(20, 20);
            this.listBoxBooks.Size = new System.Drawing.Size(240, 200);

            // ViewBooksForm
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.listBoxBooks);
            this.Text = "View Books";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

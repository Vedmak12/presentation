namespace Library
{
    partial class LoanBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.Button buttonLoan;

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
            this.labelBookId = new System.Windows.Forms.Label();
            this.labelMemberId = new System.Windows.Forms.Label();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.buttonLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelBookId
            this.labelBookId.AutoSize = true;
            this.labelBookId.Text = "Book ID:";
            this.labelBookId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelBookId.Location = new System.Drawing.Point(20, 20);

            // labelMemberId
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.Text = "Member ID:";
            this.labelMemberId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMemberId.Location = new System.Drawing.Point(20, 60);

            // textBoxBookId
            this.textBoxBookId.Location = new System.Drawing.Point(100, 20);
            this.textBoxBookId.Size = new System.Drawing.Size(150, 25);
            this.textBoxBookId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxBookId.TabIndex = 0;
            

            // textBoxMemberId
            this.textBoxMemberId.Location = new System.Drawing.Point(120, 60);
            this.textBoxMemberId.Size = new System.Drawing.Size(150, 25);
            this.textBoxMemberId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMemberId.TabIndex = 1;
            

            // buttonLoan
            this.buttonLoan.Text = "Loan Book";
            this.buttonLoan.Location = new System.Drawing.Point(100, 100);
            this.buttonLoan.Size = new System.Drawing.Size(100, 30);
            this.buttonLoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLoan.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoan.Click += new System.EventHandler(this.buttonLoan_Click);

            // LoanBookForm
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.labelBookId);
            this.Controls.Add(this.labelMemberId);
            this.Controls.Add(this.textBoxBookId);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.buttonLoan);
            this.Text = "Loan Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace Library
{
    partial class AddMemberForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.TextBox textBoxMemberName;
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
            this.labelMemberId = new System.Windows.Forms.Label();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelHeader
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(80, 20);
            this.labelHeader.Text = "Add a Member";

            // labelMemberId
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.Font = new System.Drawing.Font("Arial", 10F);
            this.labelMemberId.Location = new System.Drawing.Point(20, 70);
            this.labelMemberId.Text = "Member ID:";

            // labelMemberName
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Font = new System.Drawing.Font("Arial", 10F);
            this.labelMemberName.Location = new System.Drawing.Point(20, 110);
            this.labelMemberName.Text = "Name:";

            // textBoxMemberId
            this.textBoxMemberId.Location = new System.Drawing.Point(100, 70);
            this.textBoxMemberId.Size = new System.Drawing.Size(150, 20);

            // textBoxMemberName
            this.textBoxMemberName.Location = new System.Drawing.Point(100, 110);
            this.textBoxMemberName.Size = new System.Drawing.Size(150, 20);

            // buttonAdd
            this.buttonAdd.Text = "Add Member";
            this.buttonAdd.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(100, 150);
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // AddMemberForm
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelMemberId);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.buttonAdd);
            this.Text = "Add Member";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

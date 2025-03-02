namespace tp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel;

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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // Input TextBox
            this.inputTextBox.Size = new System.Drawing.Size(250, 30);
            this.inputTextBox.Location = new System.Drawing.Point(50, 30);
            this.Controls.Add(this.inputTextBox);
            // Button Submit
            this.submitButton.Size = new System.Drawing.Size(100, 30);
            this.submitButton.Location = new System.Drawing.Point(310, 30);
            this.submitButton.Text = "Submit/Kirim";
            this.submitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.Controls.Add(this.submitButton);
            // Label Output
            this.outputLabel.Size = new System.Drawing.Size(360, 30);
            this.outputLabel.Location = new System.Drawing.Point(50, 80);
            this.outputLabel.BackColor = System.Drawing.Color.OrangeRed;
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Text = "OUTPUT";
            this.Controls.Add(this.outputLabel);
            // Form
            this.ClientSize = new System.Drawing.Size(500, 150);
            this.Text = "Form Input";
            this.BackColor = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

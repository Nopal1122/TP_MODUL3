using System;
using System.Windows.Forms;

namespace tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text.Trim(); // Mengambil teks dari TextBox

            if (!string.IsNullOrEmpty(inputText))
            {
                outputLabel.Text = "Halo " + inputText;
            }
            else
            {
                outputLabel.Text = "MASUKIN NAMA LAH BANGG JANGAN MALU MALU"; // Default jika kosong
            }
        }
    }
}

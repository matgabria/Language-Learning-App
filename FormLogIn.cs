using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_CSharp
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if(ValideazaCredentiale(username, password))
            {
                this.Hide();
                Form1 mainForm = new Form1(); 
                mainForm.Show();
            }
            else
            {
                labelError.Text = "Incorrect username or password";
                labelError.Visible = true;
                textBoxPassword.Text = "";
                textBoxUsername.Text = "";
            }
        }
        private bool ValideazaCredentiale(string username, string password)
        {
            string filePath = @"credentials.txt";

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string fileUsername = parts[0];
                        string filePassword = parts[1];

                        // Verificam credentialele introduse de utilizator cu cele din fisier
                        if (fileUsername == username && filePassword == password)
                            return true;
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("The credentials file was not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show($"An IO exception has been thrown: {e.Message}", "IO Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                // Orice alta exceptie pe care nu am anticipat-o
                MessageBox.Show($"An unexpected error occurred: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}

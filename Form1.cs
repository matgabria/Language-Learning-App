using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Proiect_CSharp
{

    public partial class Form1 : Form
    {
        public class Vocabulary
        {
            public string Word { get; set; }
            public string Meaning { get; set; }
        }

        private List<Vocabulary> vocabularies = new List<Vocabulary>();
        public Form1()
        {
            InitializeComponent();
        }

        //Vocabulary
        private void buttonAdd_Click(object sender, EventArgs e)
        {   
            //luam cuvintele din textbox
            string word = TextBoxWord.Text;
            string meaning = TextBoxMeaning.Text;

            //adaugam noul cuvant in Lista
            vocabularies.Add(new Vocabulary() { Word = word, Meaning = meaning });
            UpdateVocabularyListView();

            TextBoxWord.Text = "";
            TextBoxMeaning.Text = "";
        }

        //Update lista dupa ce dai Edit
        private void UpdateVocabularyListView()
        {
            vocabularyListView.Items.Clear();
            foreach (var vocab in vocabularies)
            {
                ListViewItem item = new ListViewItem(new[] { vocab.Word, vocab.Meaning });
                vocabularyListView.Items.Add(item); // adaugam noua pereche
            }
        }

        //Randomizarea cuvintelor din vocabular pentru QUIZZ
        private Vocabulary GetRandomVocabulary()
        {
            Random random = new Random();
            int index = random.Next(vocabularies.Count);
            return vocabularies[index];
        }

        //QUIZ
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //ne asiguram ca nu a fost inca pusa vreo intrebare
            if(quizWordLabel.Text == "")
            {
                MessageBox.Show("Va rugam incepeti testul mai intai");
                return;
            }

            Vocabulary quizWord = vocabularies.FirstOrDefault(v => v.Word == quizWordLabel.Text);
            if(quizWord != null)
            {
                string userAnswer = answerTextBox.Text;

                if(userAnswer.Equals(quizWord.Meaning, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Corect!");
                }
                else
                {
                    MessageBox.Show($"Incorect! Raspunsul corect este: {quizWord.Meaning}");
                }

                //reseteaza pentru urmatoarea intrebare
                quizWordLabel.Text = "";
                answerTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("There was an error finding the quiz word in the list.");
            }
        }

        //Vocabulary - Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (vocabularyListView.SelectedItems.Count > 0)
            {
                int index = vocabularyListView.SelectedItems[0].Index;
                vocabularies.RemoveAt(index); // Sterge din Lista
                vocabularyListView.Items.RemoveAt(index); // Sterge din ListView
            }
            else
            {
                MessageBox.Show("Please select a word to delete.");
            }
        }

        //Vocabulary - Edit
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (vocabularyListView.SelectedItems.Count > 0)
            {
                int index = vocabularyListView.SelectedItems[0].Index;
                Vocabulary selectedVocab = vocabularies[index];

                TextBoxWord.Text = selectedVocab.Word;
                TextBoxMeaning.Text = selectedVocab.Meaning;
            }
            else
            {
                MessageBox.Show("Please select a word to edit.");
            }
        }

        //Vocabulary - Update
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (vocabularyListView.SelectedItems.Count > 0)
            {
                int index = vocabularyListView.SelectedItems[0].Index;

                // Update the List
                vocabularies[index].Word = TextBoxWord.Text;
                vocabularies[index].Meaning = TextBoxMeaning.Text;

                // Update the ListView
                vocabularyListView.Items[index].SubItems[0].Text = TextBoxWord.Text;
                vocabularyListView.Items[index].SubItems[1].Text = TextBoxMeaning.Text;

                TextBoxWord.Text = "";
                TextBoxMeaning.Text = "";

                buttonAdd.Enabled = true;
                buttonEdit.Text = "Edit";
            }
        }
        
        //Quizz
        private void startQuizButton_Click(object sender, EventArgs e)
        {
            Vocabulary quizWord = GetRandomVocabulary();
            quizWordLabel.Text = quizWord.Word;
        }

        //Exit page
        private void ExitTab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == ExitTab)
            {
                SaveVocabularyToFile();
                Application.Exit();
            }
        }

        //Salveaza fisierul Text
        private void SaveVocabularyToFile()
        {
            string appDirectory = Application.StartupPath;

            string fileName = "vocabulary.txt";

            string filePath = Path.Combine(appDirectory, fileName);

            using (StreamWriter writer = new StreamWriter(filePath, false)) // 'false' to overwrite if the file already exists
            {
                foreach (Vocabulary vocab in vocabularies)
                {
                    // Scrie fiecare cuvant si meaning separate de :
                    writer.WriteLine($"{vocab.Word}:{vocab.Meaning}");
                }
            }
                        
            MessageBox.Show($"Vocabulary saved to {filePath}", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImportListButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "vocabulary.txt");

            if (File.Exists(filePath))
            {
                vocabularies.Clear();
                vocabularyListView.Items.Clear();

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string word = parts[0];
                        string meaning = parts[1];

                        string finalWord = char.ToUpper(word[0]) + word.Substring(1);
                        string finalMeaning = char.ToUpper(meaning[0]) + meaning.Substring(1);

                        //adaugam file.ul in list si listview
                        Vocabulary vocab = new Vocabulary { Word = finalWord, Meaning = finalMeaning };
                        vocabularies.Add(vocab);

                        //update the listview
                        ListViewItem item = new ListViewItem(new[] { finalWord, finalMeaning });
                        vocabularyListView.Items.Add(item);
                    }
                }

                MessageBox.Show("Lista importata cu succes!", "Import Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lista nu exista in directory", "file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

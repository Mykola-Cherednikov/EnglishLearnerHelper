using EnglishLearnerHelperAPI;

namespace EnglishLearnerHelper
{
    public partial class MainForm : Form
    {
        private readonly TranslateService translateService;

        public MainForm()
        {
            InitializeComponent();

            translateService = new TranslateService("Dictionary.txt");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TranslationTable.Columns.Add("OriginalWord", "Original");
            TranslationTable.Columns.Add("TranslatedWord", "Translated");
            TranslationTable.Columns.Add("OriginalSentence", "Original Sentence");
            TranslationTable.Columns.Add("CorrectCount", "Correct Count");
            TranslationTable.Columns.Add("WrongCount", "Wrong Count");
            TranslationTable.Columns.Add("Id", "Id");

            ShowRows();
        }

        private void ShowRows()
        {
            TranslationTable.Rows.Clear();

            var dict = translateService.GetTranslations();

            foreach (var row in dict)
            {
                TranslationTable.Rows.Add(row.OriginalWord, row.TranslatedWord, row.OriginalSentence, row.CorrectAnswers.Count, row.WrongAnswers.Count, row.Id);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TranslateSetForm form = new TranslateSetForm(this);
            form.ShowDialog();
        }

        public void AddRow(TranslateSet translateSet)
        {
            TranslationTable.Rows.Add(translateSet.OriginalWord, translateSet.TranslatedWord, translateSet.OriginalSentence, translateSet.CorrectAnswers.Count, translateSet.WrongAnswers.Count, translateSet.Id);

            translateService.AddTranslation(translateSet);
        }

        public void EditRow(TranslateSet translateSet)
        {
            foreach (DataGridViewRow row in TranslationTable.Rows)
            {
                if (row.Cells["Id"].Value.ToString() == translateSet.Id)
                {
                    row.Cells["OriginalWord"].Value = translateSet.OriginalWord;
                    row.Cells["TranslatedWord"].Value = translateSet.TranslatedWord;
                    row.Cells["OriginalSentence"].Value = translateSet.OriginalSentence;
                    break;
                }
            }

            translateService.EditTranslation(translateSet);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TranslationTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select a cell in the row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rowIndex = TranslationTable.SelectedCells[0].RowIndex;

                if (rowIndex < 0 || rowIndex >= TranslationTable.Rows.Count)
                {
                    MessageBox.Show("Invalid row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                translateService.RemoveTranslation(TranslationTable["Id", rowIndex].Value.ToString()!);

                TranslationTable.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm(translateService.GetTranslations(), int.Parse(NumOfQuestionsTextBox.Text));

            quizForm.ShowDialog();

            translateService.Save();
        }

        private void NumOfQuestionsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TranslationTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select a cell in the row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rowIndex = TranslationTable.SelectedCells[0].RowIndex;

                if (rowIndex < 0 || rowIndex >= TranslationTable.Rows.Count)
                {
                    MessageBox.Show("Invalid row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string? id = TranslationTable.Rows[rowIndex]?.Cells["Id"]?.Value?.ToString();

                if (string.IsNullOrWhiteSpace(id))
                {
                    throw new Exception();
                }

                TranslateSetForm form = new TranslateSetForm(this, translateService.GetTranslations().First(t => t.Id == id));
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        translateService.ImportTranslations(filePath);
                        ShowRows();
                        MessageBox.Show($"Import successful!", "Open File");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Import error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void resetStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to reset stats?", "Stats reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                translateService.ResetStats();

                ShowRows();
            }
        }
    }
}

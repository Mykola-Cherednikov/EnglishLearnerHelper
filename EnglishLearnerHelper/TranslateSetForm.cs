using EnglishLearnerHelperAPI;

namespace EnglishLearnerHelper
{
    public partial class TranslateSetForm : Form
    {
        private MainForm mainForm;
        private TranslateSet? translateSet;

        public TranslateSetForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.MaximizeBox = false;

            InitializeComponent();
        }

        public TranslateSetForm(MainForm mainForm, TranslateSet translateSet)
        {
            this.mainForm = mainForm;
            this.MaximizeBox = false;

            InitializeComponent();

            SetTranslateSet(translateSet);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (translateSet != null)
            {
                translateSet.OriginalWord = OriginalTextBox.Text;
                translateSet.OriginalSentence = SentenceTextBox.Text;
                translateSet.TranslatedWord = TranslatedTextBox.Text;

                mainForm.EditRow(translateSet);
            }
            else
            {
                mainForm.AddRow(new TranslateSet() { OriginalWord = OriginalTextBox.Text, OriginalSentence = SentenceTextBox.Text, TranslatedWord = TranslatedTextBox.Text });
            }

            this.Close();
        }

        private void SetTranslateSet(TranslateSet translateSet)
        {
            this.translateSet = translateSet;

            OriginalTextBox.Text = translateSet.OriginalWord;
            SentenceTextBox.Text = translateSet.OriginalSentence;
            TranslatedTextBox.Text = translateSet.TranslatedWord;
        }
    }
}

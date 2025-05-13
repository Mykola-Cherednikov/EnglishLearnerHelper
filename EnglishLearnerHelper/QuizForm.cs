using EnglishLearnerHelperAPI;

namespace EnglishLearnerHelper
{
    public partial class QuizForm : Form
    {
        private readonly List<TranslateSet> translateSets;

        private readonly Queue<TranslateSet> translateSetsQueue;

        private readonly Dictionary<Button, EventHandler?> buttonsToEvent;

        private bool AnswerTried = false;

        public QuizForm(IEnumerable<TranslateSet> translateSets, int numOfQuestions)
        {
            if (translateSets == null) throw new ArgumentNullException(nameof(translateSets));

            this.MaximizeBox = false;

            InitializeComponent();

            this.translateSets = RandomizeTranslateSets(translateSets, numOfQuestions);
            translateSetsQueue = new Queue<TranslateSet>(this.translateSets);
            buttonsToEvent = InitializeButtonEvents();

            NextTranslation();
        }

        private List<TranslateSet> RandomizeTranslateSets(IEnumerable<TranslateSet> translateSets, int numOfQuestions)
        {
            var random = new Random();
            return translateSets.OrderBy(_ => random.Next()).Take(numOfQuestions).ToList();
        }

        private Dictionary<Button, EventHandler?> InitializeButtonEvents()
        {
            return new Dictionary<Button, EventHandler?>
            {
                { FirstButton, null },
                { SecondButton, null },
                { ThirdButton, null },
                { FourthButton, null }
            };
        }

        private void NextTranslation()
        {
            if (!translateSetsQueue.Any())
            {
                Close();
                return;
            }

            AnswerTried = false;
            SentenceLabel.Hide();
            var currentSet = translateSetsQueue.Dequeue();
            ClearButtonEvents();
            UpdateDisplayLabels(currentSet);
            ConfigureAnswerButtons(currentSet);
        }

        private void ClearButtonEvents()
        {
            foreach (var pair in buttonsToEvent)
            {
                pair.Key.Click -= pair.Value;
            }
        }

        private void UpdateDisplayLabels(TranslateSet set)
        {
            WordLabel.Text = set.OriginalWord;
            SentenceLabel.Text = set.OriginalSentence;
        }

        private void ConfigureAnswerButtons(TranslateSet correctSet)
        {
            var random = new Random();
            var wrongSets = GetRandomWrongSets(correctSet, random);
            var correctButtonIndex = random.Next(4);

            var buttons = buttonsToEvent.Keys.ToArray();

            ConfigureButton(
                buttons[correctButtonIndex],
                correctSet.TranslatedWord,
                (sender, e) => CorrectAnswer(sender, e, correctSet)
            );

            var wrongSetIndex = 0;
            for (var i = 0; i < 4; i++)
            {
                if (i != correctButtonIndex)
                {
                    var wrongSet = wrongSets[wrongSetIndex];

                    ConfigureButton(
                        buttons[i],
                        wrongSet.TranslatedWord,
                        (sender, e) => WrongAnswer(sender, e, wrongSet, correctSet)
                    );
                    wrongSetIndex++;
                }
            }
        }

        private List<TranslateSet> GetRandomWrongSets(TranslateSet correctSet, Random random)
        {
            var sets = translateSets
                .Where(t => t.Id != correctSet.Id)
                .ToList();

            for (int i = sets.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                var temp = sets[i];
                sets[i] = sets[j];
                sets[j] = temp;
            }

            return sets.Take(3).ToList();
        }

        private void ConfigureButton(Button button, string text, EventHandler handler)
        {
            button.Text = text;
            button.Click += handler;
            buttonsToEvent[button] = handler;
        }

        private void CorrectAnswer(object? sender, EventArgs e, TranslateSet c)
        {
            NextTranslation();
            c.CorrectAnswers.Add(DateTime.Now);
        }

        private void WrongAnswer(object? sender, EventArgs e, TranslateSet w, TranslateSet c)
        {
            MessageBox.Show("Wrong answer! For this word original: " + w.OriginalWord);

            if (!AnswerTried)
            {
                c.WrongAnswers.Add(DateTime.Now);
                AnswerTried = true;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            SentenceLabel.Show();
        }
    }
}

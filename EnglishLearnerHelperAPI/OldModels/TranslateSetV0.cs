namespace EnglishLearnerHelperAPI.OldModels
{
    public class TranslateSetV0
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string OriginalWord { get; set; } = string.Empty;

        public string OriginalSentence { get; set; } = string.Empty;

        public string TranslatedWord { get; set; } = string.Empty;

        public int CorrectAnswers { get; set; }

        public int WrongAnswers { get; set; }
    }
}

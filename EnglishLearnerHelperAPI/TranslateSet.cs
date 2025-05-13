namespace EnglishLearnerHelperAPI
{
    public class TranslateSet
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string OriginalWord { get; set; } = string.Empty;

        public string OriginalSentence { get; set; } = string.Empty;

        public string TranslatedWord { get; set; } = string.Empty;

        public List<DateTime> CorrectAnswers { get; set; } = new List<DateTime>();

        public List<DateTime> WrongAnswers { get; set; } = new List<DateTime>();
    }
}

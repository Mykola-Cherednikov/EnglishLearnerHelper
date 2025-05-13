namespace EnglishLearnerHelperAPI
{
    public class SaveData
    {
        public int Version { get; set; }

        public List<object> Data { get; set; } = new List<object>();
    }
}

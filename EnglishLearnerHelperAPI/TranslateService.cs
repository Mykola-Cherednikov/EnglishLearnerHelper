namespace EnglishLearnerHelperAPI
{
    public class TranslateService
    {
        private readonly List<TranslateSet> Dictionary;

        private readonly string FilePath;

        public TranslateService(string filePath)
        {
            Dictionary = FileService.Load(filePath);

            FilePath = filePath;
        }

        public void AddTranslation(TranslateSet translate)
        {
            var collide = Dictionary.FirstOrDefault(t => t.OriginalWord == translate.OriginalWord);

            if (collide != null)
            {
                throw new Exception(); // Collide exception
            }

            Dictionary.Add(translate);

            FileService.Save(FilePath, Dictionary);
        }

        public void EditTranslation(TranslateSet translate)
        {
            var collide = Dictionary.FirstOrDefault(t => t.Id == translate.Id);

            if (collide == null)
            {
                throw new Exception(); // No such id
            }

            collide.OriginalWord = translate.OriginalWord;
            collide.TranslatedWord = translate.TranslatedWord;
            collide.OriginalSentence = translate.OriginalSentence;

            FileService.Save(FilePath, Dictionary);
        }

        public void RemoveTranslation(string id)
        {
            var translation = Dictionary.FirstOrDefault(t => t.Id == id);

            if (translation == null) // No such id
            {
                throw new Exception();
            }

            Dictionary.Remove(translation);

            FileService.Save(FilePath, Dictionary);
        }

        public List<TranslateSet> GetTranslations()
        {
            return Dictionary;
        }

        public void Save()
        {
            FileService.Save(FilePath, Dictionary);
        }

        public List<TranslateSet> ReloadTranslations()
        {
            Dictionary.Clear();

            Dictionary.AddRange(FileService.Load(FilePath));

            return GetTranslations();
        }

        public List<TranslateSet> ImportTranslations(string importFilePath)
        {
            FileService.ImportData(FilePath, importFilePath);

            return ReloadTranslations();
        }

        public List<TranslateSet> ResetStats()
        {
            Dictionary.ForEach(t => { t.WrongAnswers.Clear(); t.CorrectAnswers.Clear(); });

            Save();

            return ReloadTranslations();
        }

        public List<TranslateSet> RemoveLearned(int streakLength = 7)
        {
            List<TranslateSet> removingSet = Dictionary.Where(t => IsStreaked(t, streakLength)).ToList();

            Dictionary.RemoveAll(t => removingSet.Contains(t));

            FileService.Save($"{Path.GetDirectoryName(FilePath)}removed_set_{DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}.txt", removingSet);

            Save();

            return ReloadTranslations();
        }

        private bool IsStreaked(TranslateSet translateSet, int streakLength)
        {
            if(translateSet.CorrectAnswers.Count < streakLength)
            {
                return false;
            }

            if(translateSet.WrongAnswers.Count == 0)
            {
                return true;
            }

            var firstStreaked = translateSet.CorrectAnswers[^streakLength];
            var lastWrong = translateSet.WrongAnswers.Last();

            return firstStreaked > lastWrong;
        }
    }
}

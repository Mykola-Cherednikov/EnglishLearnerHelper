using EnglishLearnerHelperAPI.OldModels;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace EnglishLearnerHelperAPI
{
    public class FileService
    {
        private static int LastVersion { get => MigrationActions.Count; }

        private static List<Func<string, SaveData, SaveData>> MigrationActions = new List<Func<string, SaveData, SaveData>>() { MigrationToV1 };

        private static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public static void Save(string filePath, List<TranslateSet> translations)
        {
            var saveData = new SaveData()
            {
                Version = LastVersion,
                Data = translations
            };

            string json = JsonSerializer.Serialize(saveData, JsonSerializerOptions);

            File.WriteAllText(filePath, json, Encoding.UTF8);
        }

        public static List<TranslateSet> Load(string filePath)
        {
            List<TranslateSet>? dictionary = null;

            if (File.Exists(filePath))
            {
                var saveData = LoadAndMigrate(filePath);

                dictionary = (List<TranslateSet>)saveData.Data;
            }

            return dictionary ?? new List<TranslateSet>();
        }

        private static SaveData LoadAndMigrate(string filePath)
        {
            var json = File.ReadAllText(filePath, Encoding.UTF8);
            SaveData saveData = TryDeserialize(json) ?? new SaveData
            {
                Version = LastVersion,
                Data = new List<object>()
            };

            for (int i = saveData.Version; i < LastVersion; i++)
            {
                saveData = MigrationActions[i](filePath, saveData);
                Save(filePath, (List<TranslateSet>)saveData.Data);
            }

            return saveData;
        }

        private static SaveData? TryDeserialize(string json)
        {
            try
            {
                var saveData = JsonSerializer.Deserialize<SaveData>(json, JsonSerializerOptions);
                if (saveData?.Data == null)
                    return null;

                saveData.Data = ((JsonElement)saveData.Data).Deserialize<List<TranslateSet>>()!;
                return saveData;
            }
            catch (JsonException)
            {
                var oldData = JsonSerializer.Deserialize<List<TranslateSetV0>>(json, JsonSerializerOptions);
                return oldData != null
                    ? new SaveData { Version = 0, Data = oldData }
                    : null;
            }
        }

        private static SaveData MigrationToV1(string filePath, SaveData saveData)
        {
            var oldData = (List<TranslateSetV0>)saveData.Data;
            var newData = oldData.Select(row => new TranslateSet
            {
                Id = row.Id,
                OriginalWord = row.OriginalWord,
                OriginalSentence = row.OriginalSentence,
                TranslatedWord = row.TranslatedWord,
                CorrectAnswers = Enumerable.Repeat(DateTime.Now, row.CorrectAnswers).ToList(),
                WrongAnswers = Enumerable.Repeat(DateTime.Now, row.WrongAnswers).ToList()
            }).ToList();

            return new SaveData
            {
                Version = 1,
                Data = newData
            };
        }

        public static void ImportData(string filePath, string importFilePath)
        {
            List<TranslateSet> currentTranslateSets = Load(filePath);
            List<TranslateSet> importTranslateSets = Load(importFilePath);

            var finalList = currentTranslateSets.Concat(importTranslateSets).GroupBy(t => t.Id).Select(group => group.First()).ToList();

            Save(filePath, finalList);
        }
    }
}

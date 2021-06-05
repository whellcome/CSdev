using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;



namespace NutritionCalculator.Controllers
{
    class DataJsonController : IDataController
    {
        public List<T> Load<T>() where T : class
        {
            var fileName = typeof(T).Name + ".json";
            var items = new List<T>();
            if (File.Exists(fileName))
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                
                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        items.Add(JsonConvert.DeserializeObject<T>(item));
                    }
                    return items;
                }
            }
            return items;
        }

        public void Save<T>(List<T> items) where T : class
        {
            var fileName = typeof(T).Name + ".json";
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.CheckAdditionalContent = true;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (T item in items)
                {
                    var jsonStr = JsonConvert.SerializeObject(item, typeof(T),serializerSettings);
                    sw.WriteLine(jsonStr);
                }
            }
        }
    }
}
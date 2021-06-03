using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;

namespace NutritionCalculator.Controllers
{
    internal class DataJsonController : IDataController
    {
        public List<T> Load<T>() where T : class
        {
            var fileName = typeof(T).Name + ".json";
            var items = new List<T>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                if (File.Exists(fileName))
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

        public void Save<T>(List<T> item) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}
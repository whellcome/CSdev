using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IntensivFitness.BL.Controller
{
    public abstract class BaseController
    {
        /// <summary>
        /// Loads List by Type
        /// </summary>
        /// <typeparam name="T">Type of list.</typeparam>
        /// <returns>Output list</returns>
        protected static List<T> Load<T>() where T : class
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T).Name;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is List<T> items)
                {
                    return items;
                }
                else
                {
                    return new List<T>();
                }
            }
        }

        /// <summary>
        /// Saves list with parameters
        /// </summary>
        /// <typeparam name="T">Type of list</typeparam>
        /// <param name="item">item</param>
        protected static void Save<T>(List<T> item) where T : class
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T).Name;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
    }
}

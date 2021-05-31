using IntensivFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace IntensivFitness.BL.Controller
{
    /// <summary>
    /// User controller.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// List of users
        /// </summary>
        public List<User> Users { get; }

        /// <summary>
        /// Current user
        /// </summary>
        public User CurrentUser { get; }

        /// <summary>
        /// Create new user controller.
        /// </summary>
        public UserController()
        {
            var userName = InputString("Enter username: ");
            Users = GetUsersData();
            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);

            if (CurrentUser == null)
            {
                var genderName = InputString("Enter gender: ");
                var birthday = InputValue<DateTime>("Enter birthday (dd.mm.yyyy): ");
                var weight = InputValue<double>("Enter weight: ");
                var height = InputValue<double>("Enter height: ");
                var gender = new Gender(genderName);
                var newUser = new User(userName, gender, birthday, weight, height);
                
                CurrentUser = newUser;
                Save();
            }
        }

        /// <summary>
        /// Loads list of users or returns empty list
        /// </summary>
        /// <returns>list of users</returns>
        private List<User> GetUsersData()
        {
            return Load<User>() ?? new List<User>();
        }
        /// <summary>
        /// Loads List by Type
        /// </summary>
        /// <typeparam name="T">Type of list.</typeparam>
        /// <returns>Output list</returns>
        public List<T> Load<T>() where T : class
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
        /// Saves list without parameters
        /// </summary>
        public void Save()
        {
            Save(Users);
        }

        /// <summary>
        /// Saves list with parameters
        /// </summary>
        /// <typeparam name="T">Type of list</typeparam>
        /// <param name="item">item</param>
        public void Save<T>(List<T> item) where T : class
        {
            var formatter = new BinaryFormatter();
            var fileName = typeof(T).Name;

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
        
        /// <summary>
        /// Input of value with verification
        /// </summary>
        /// <typeparam name="T">Type of method.</typeparam>
        /// <param name="str">Information string.</param>
        /// <returns>Output value.</returns>
        private static T InputValue<T>(string str)
        {
            int i = 0;
            T result;
            bool success;
            do
            {
                if (i > 0) Console.WriteLine("Wrong input");
                Console.Write(str);
                i++;
                success = TryToParse<T>(Console.ReadLine(), out result);
            }
            while (!success);
            return result;
        }

        /// <summary>
        /// Input of string with verification.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Output string</returns>
        private static string InputString(string str) 
        {
            int i = 0;
            string result;
            do
            {
                if (i > 0) Console.WriteLine("Wrong input");
                Console.Write(str);
                i++;
                result = Console.ReadLine();
            }
            while (String.IsNullOrWhiteSpace(result));
            return result;
        }

        /// <summary>
        /// Tries to parse by type.
        /// </summary>
        /// <typeparam name="T">Type of method.</typeparam>
        /// <param name="source">Input string.</param>
        /// <param name="value">Output value.</param>
        /// <returns></returns>
        private static bool TryToParse<T>(string source, out T value)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter.CanConvertFrom(typeof(string)))
            {
                try
                {
                    value = (T)converter.ConvertFromString(source);
                    return true;
                }
                catch(Exception)
                {
                    value = default(T);
                    return false;
                }
            }
            else
            {
                value = default(T);
                return false;
            }
        }
    }
}

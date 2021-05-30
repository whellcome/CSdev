using IntensivFitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IntensivFitness.BL.Controller
{
    /// <summary>
    /// User controller.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// User of application.
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Create new user controller.
        /// </summary>
        /// <param name="userName">Name of user.</param>
        /// <param name="genderName">Gander of user.</param>
        /// <param name="birthday">Birthday of user.</param>
        /// <param name="weight">Weight of user.</param>
        /// <param name="height">Height of user.</param>
        public UserController(string userName, string genderName, DateTime birthday, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthday, weight, height);
        }
        /// <summary>
        /// Save user's data.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Load user's data.
        /// </summary>
        /// <returns>User of application.</returns>
        public User Load()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                return formatter.Deserialize(fs) as User;
            }
        }
    }
}

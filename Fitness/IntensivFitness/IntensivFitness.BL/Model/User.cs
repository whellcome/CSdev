using System;

namespace IntensivFitness.BL.Model
{
    [Serializable]
    /// <summary>
    /// User of fitness center.
    /// </summary>
    public class User
    {
        #region Properties
        /// <summary>
        /// Name of user.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gender of user.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Birthdate of user.
        /// </summary>
        public DateTime Birthday { get; }
        /// <summary>
        /// Weight of user.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Height of user.
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Create new user.
        /// </summary>
        /// <param name="name">Name of user.</param>
        /// <param name="gender">Gender of user.</param>
        /// <param name="birthday">Birth date of user.</param>
        /// <param name="weight">Weight of user.</param>
        /// <param name="height">Height of user.</param>
        public User(string name, Gender gender, DateTime birthday, double weight, double height)
        {
            #region Verifications
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Empty value.");
            if (birthday < DateTime.Parse("01.01.1900") || birthday > DateTime.Now)
                throw new ArgumentException("Impossible value.", nameof(birthday));
            if(weight <=0)
                throw new ArgumentException("Impossible value.", nameof(weight));
            if (weight <= 0)
                throw new ArgumentException("Impossible value.", nameof(height));
            Gender = gender ?? throw new ArgumentNullException(nameof(gender), "Empty value.");
            #endregion
            Name = name;
            Birthday = birthday;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"User: {Name} birthday: {Birthday}";
        }
    }
}

using System;

namespace IntensivFitness.BL.Model
{
    [Serializable]
    /// <summary>
    /// Gender of user
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Gender name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Create new Gender
        /// </summary>
        /// <param name="name">Name of gender</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Empty value", nameof(name));
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

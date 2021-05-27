using System;

namespace StDietmar.InsulinCalculator
{
    public class Person
    {
        private string _name;
        public string SecondName { get; set; }
        public string FirstName
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty name!");
                }
                _name = value;
            }
        }
        public Calculator InsulinPlan { get; set; }
        public bool GlutenFree { get; set; }
        public Person(string firstName = "John", string secondName = "Dow", Calculator insulinPlan = null)
        {
            FirstName = firstName;
            SecondName = secondName;
            InsulinPlan = insulinPlan ?? new Calculator();
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName;
            }
        }

        public string ShortName
        {
            get
            {
                return $"{FirstName.Substring(0, 1)}. {SecondName}";
            }
        }
        public string TableName
        {
            get
            {
                return $"{SecondName}, {FirstName}";
            }
        }
        
    }
}

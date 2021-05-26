using System;

namespace StDietmar.InsulinCalculator
{
    public class Calculator
    {
        public enum DayPart : int
        {
            Night_0_3 = 0,
            Night_3_6 = 1,
            Morning_6_9 = 2,
            Morning_9_12 = 3,
            Day_12_3 = 4,
            Day_3_6 = 5,
            Evening_6_9 = 6,
            Evening_9_12 = 7,
        }
        public double[] FactorPlan { get; set; }
        public Calculator()
        {
            Array dayPart = Enum.GetValues(typeof(DayPart));
            FactorPlan = new double[dayPart.Length];
            foreach (int i in dayPart)
            {
                FactorPlan[i] = 0.5;
            }
        }
        public double GetInsulinFactor(DateTime dateTime)
        {
            int indexDayPart = (int)Math.Round((double)dateTime.Hour / 3);
            return FactorPlan[indexDayPart];
        }

        public double GetInsulinAmount(double carbQuantity, DateTime dateTime)
        {
            return GetInsulinFactor(dateTime) * carbQuantity / 10;

        }
    }
}

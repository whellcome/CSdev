using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StDietmar.Test2
{
     class InsulinCalculator
    {
        public double CarbQuantity { get; set; }
        public InsulinPlan InsulinPlan { get; set; }

        public double GetInsulinAmount(DateTime dateTime)
        {
            return InsulinPlan.GetInsulinFactor(dateTime)*CarbQuantity/10;

        }
    }
}

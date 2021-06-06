using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalculator.Controllers
{
    public class InsulinPlanController : DataController
    {
        private List<InsulinPlan> InsulinPlans { get; set; }
        public List<InsulinPlan> UserInsulinPlans { get; set; }
        public InsulinPlan CurrentInsulinPlan { get; set; }
        public InsulinPlanController()
        {
            var currentUser = NutritionCalculatorData.CurrentUser; 
            InsulinPlans = GetInsulinPlans();
            UserInsulinPlans = InsulinPlans.FindAll(i => i.User.Name == currentUser.Name && i.User.BirthDate == currentUser.BirthDate);
            if (UserInsulinPlans.Count <= 0)
            {
                CurrentInsulinPlan = new InsulinPlan(currentUser);
                CurrentInsulinPlan.Plan.Add(SetNewItem());
            }
            else
            {
                CurrentInsulinPlan = currentUser.InsulinPlan ?? UserInsulinPlans.First();// NutritionCalculatorData.CurrentInsulinPlan;
            }
        }

        public InsulinPlanItem SetNewItem()
        {
            return new InsulinPlanItem();
        }

        public void SetNew(string name, List<InsulinPlanItem> insulinPlan)
        {
            var newInsulinPlan = new InsulinPlan(NutritionCalculatorData.CurrentUser)
            {
                Name = name
            };
            foreach (InsulinPlanItem item in insulinPlan)
            {
                newInsulinPlan.Plan.Add(item);
            }
            InsulinPlans.Add(newInsulinPlan);
            CurrentInsulinPlan = newInsulinPlan;
            Save();
            
        }

        public void Update(InsulinPlan insulinPlan)
        {
            var currentInsulinPlan = NutritionCalculatorData.CurrentInsulinPlan;
            var index = InsulinPlans.FindIndex(i => i.User == currentInsulinPlan.User && i.Name == currentInsulinPlan.Name);
            InsulinPlans[index] = insulinPlan;
            Save();
            NutritionCalculatorData.CurrentInsulinPlan = insulinPlan;
        }

        private List<InsulinPlan> GetInsulinPlans()
        {
            return Load<InsulinPlan>();
        }

        public void Save()
        {
            Save(InsulinPlans);
            NutritionCalculatorData.CurrentInsulinPlan = CurrentInsulinPlan;
        }

    }
}

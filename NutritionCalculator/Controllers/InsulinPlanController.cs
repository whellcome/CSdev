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
            var currentUser = NCData.CurrentUser; 
            InsulinPlans = GetInsulinPlans();
            UserInsulinPlans = InsulinPlans.FindAll(i => i.User.Name == currentUser.Name && i.User.BirthDate == currentUser.BirthDate);
            if (UserInsulinPlans.Count <= 0)
            {
                CurrentInsulinPlan = new InsulinPlan(currentUser);
                CurrentInsulinPlan.Plan.Add(SetNewItem());
            }
            else
            {
                CurrentInsulinPlan = UserInsulinPlans.SingleOrDefault(i => i.Id == currentUser.InsulinPlan) ?? UserInsulinPlans.First();// NutritionCalculatorData.CurrentInsulinPlan;
            }
        }

        public InsulinPlanItem SetNewItem()
        {
            return new InsulinPlanItem();
        }

        public void SetNew(InsulinPlan insulinPlan)
        {
            if (CurrentInsulinPlan.Plan.Count == 0)
            {
                foreach (InsulinPlanItem item in insulinPlan.Plan)
                {
                    CurrentInsulinPlan.Plan.Add(item);
                }
                InsulinPlans.Add(CurrentInsulinPlan);
                Save();
            }
        }

        public void Update(InsulinPlan insulinPlan)
        {
            var currentInsulinPlan = UserInsulinPlans.SingleOrDefault(i => i.Id == NCData.CurrentUser.InsulinPlan);
            var index = InsulinPlans.FindIndex(i => i.User == currentInsulinPlan.User && i.Id == currentInsulinPlan.Id);
            InsulinPlans[index] = insulinPlan;
            Save();
            NCData.CurrentUser.InsulinPlan = insulinPlan.Id;
        }

        private List<InsulinPlan> GetInsulinPlans()
        {
            return Load<InsulinPlan>();
        }

        public void Save()
        {
            Save(InsulinPlans);
            NCData.CurrentUser.InsulinPlan = CurrentInsulinPlan.Id;
            NCData.EventHandler(typeof(InsulinPlan).Name);
        }

    }
}

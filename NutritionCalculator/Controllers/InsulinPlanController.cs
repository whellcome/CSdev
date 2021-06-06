using NutritionCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NutritionCalculator.Controllers
{
    public class InsulinPlanController : DataController
    {
        private List<InsulinPlan> InsulinPlans { get; set; }
        public List<InsulinPlan> UserInsulinPlans { get; set; }
        public InsulinPlan CurrentInsulinPlan { get; set; }
        public InsulinPlanController()
        {
            
            InsulinPlans = GetInsulinPlans();
            UserInsulinPlans = InsulinPlans.FindAll(i => i.User.Name == NCData.CurrentUser.Name && i.User.BirthDate == NCData.CurrentUser.BirthDate);
            if (UserInsulinPlans.Count <= 0)
            {
                CurrentInsulinPlan = new InsulinPlan(NCData.CurrentUser);
                CurrentInsulinPlan.Plan.Add(SetNewItem());
            }
            else
            {
                CurrentInsulinPlan = UserInsulinPlans.SingleOrDefault(i => i.Id == NCData.CurrentUser.InsulinPlan) ?? UserInsulinPlans.First();// NutritionCalculatorData.CurrentInsulinPlan;
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
            }
            CurrentInsulinPlan.Id = (int)DateTime.Now.Subtract(new DateTime(2021, 1, 1)).TotalSeconds;
            InsulinPlans.Add(CurrentInsulinPlan);
            Save();
        }

        public void Update(InsulinPlan insulinPlan)
        {
            var currentInsulinPlan = UserInsulinPlans.SingleOrDefault(i => i.Id == NCData.CurrentUser.InsulinPlan);
            var index = InsulinPlans.FindIndex(i => i.User == currentInsulinPlan.User && i.Id == currentInsulinPlan.Id);
            InsulinPlans[index] = insulinPlan;
            NCData.CurrentUser.InsulinPlan = insulinPlan.Id;
            Save();
        }

        private List<InsulinPlan> GetInsulinPlans()
        {
            return Load<InsulinPlan>();
        }

        public void Save()
        {
            NCData.CurrentUser.InsulinPlan = CurrentInsulinPlan.Id;
            Save(InsulinPlans);
            NCData.EventHandler(typeof(InsulinPlan).Name);
        }

    }
}

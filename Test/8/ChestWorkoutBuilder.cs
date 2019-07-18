using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChestWorkoutBuilder : WorkoutBuilder
    {
        protected override void ChangeCloths()
        {
            workout.ChangeCloths("Put sport pants, T-shirt and shoes");
        }

        protected override void DrinkWater()
        {
            workout.DrinkWater("Drink neviot");
        }

        protected override void DoMainDrill()
        {
            workout.DoMainDrill("Press dumbells");
        }

        protected override void TakeAShower()
        {
            workout.TakeAShower("Take a shower in the gym");
        }
    }
}

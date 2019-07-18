using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class WorkoutBuilder
    {
        protected Workout workout;

        public Workout GetWorkout()
        {
            if (workout == null)
                this.BuildWorkout(); ;

            return workout;
        }

        public void BuildWorkout()
        {
            this.workout = new Workout();
            ChangeCloths();
            DrinkWater();
            DoMainDrill();
            TakeAShower();
        }

        protected abstract void ChangeCloths();
        protected abstract void DrinkWater();
        protected abstract void DoMainDrill();
        protected abstract void TakeAShower();
    }
}

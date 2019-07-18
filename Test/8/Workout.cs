using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Workout
    {

        private List<String> actions = new List<String>();

        
        public List<String> GetActions()
        {
            return this.actions;
        }

        public void ChangeCloths(String changeCloths)
        {
            actions.Add(changeCloths);
        }

        public void DrinkWater(String drinkWater)
        {
            actions.Add(drinkWater);
        }

        public void DoMainDrill(String mainDrill)
        {
            actions.Add(mainDrill);
        }

        public void TakeAShower(String shower)
        {
            actions.Add(shower);
        }
    }
}

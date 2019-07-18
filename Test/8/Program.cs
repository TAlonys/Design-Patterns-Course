using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ChestWorkoutBuilder chestBuilder = new ChestWorkoutBuilder();

            Workout regularChestWorkout = chestBuilder.GetWorkout();

            ChestWorkoutBuilderFlys chestBuilderWithFlys = new ChestWorkoutBuilderFlys();

            Workout chestWorkoutWithFlys = chestBuilderWithFlys.GetWorkout();

            PrintWorkout(regularChestWorkout);
            PrintWorkout(chestWorkoutWithFlys);

        }


        static void PrintWorkout(Workout currWorkout)
        {

            Console.WriteLine("Your workout:");

            foreach (string action in currWorkout.GetActions())
            {
                Console.WriteLine(action);
            }

            Console.WriteLine();
        }
    }
}

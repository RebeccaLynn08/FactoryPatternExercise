using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Pie : ICallable
    {
        public void Build()
        {
            Intermission.ElevatorMusic();
            Console.WriteLine("Your delicious pie is ready to share with friends!");
        }

    }
}

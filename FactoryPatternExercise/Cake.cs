using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Cake : ICallable
    {
        public void Build()
        {
            Intermission.ElevatorMusic();
            Console.WriteLine("Your cake is ready to dazzle all of your guests!");
        }
    }
}

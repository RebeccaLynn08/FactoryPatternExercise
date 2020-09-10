using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Cookies : ICallable
    {
        public void Build()
        {
            Intermission.ElevatorMusic();
            Console.WriteLine("Your batch of fresh, warm cookies is ready to share!\n(Or keep all to yourself if you ask me)");

            
        }
    }
}

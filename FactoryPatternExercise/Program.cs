using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people will be eating a treat today?");
            //int customers = Convert.ToInt32(Console.ReadLine());


            ICallable order = BakeryFactory.GetCustomers();
            order.Build();
            Console.ReadLine();


















        }
    }
}

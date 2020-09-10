using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    static class BakeryFactory
    {

        public static ICallable GetCustomers()
        {
            int customers;
            bool input = true;
            do
            {
                if (input == false)
                {
                    Console.WriteLine("Please enter the number of people that will be eating.");

                }
                input = int.TryParse(Console.ReadLine(), out customers);

            } while (input == false || customers <= 0);


            if (customers >= 1 && customers < 3)
            {
                return new Cookies();
            }

            else if (customers >= 3 && customers < 7)
            {
                return new Pie();
            }

            else
            {
                return new Cake();
            }
        }

            











    }
}

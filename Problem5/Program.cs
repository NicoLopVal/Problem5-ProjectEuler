using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valueFound = false;
            int counter = 20;

            while (!valueFound)
            {
                if(counter%20 == 0 &&
                    counter % 19 == 0 &&
                    counter % 18 == 0 &&
                    counter % 17 == 0 &&
                    counter % 16 == 0 &&
                    counter % 15 == 0 &&
                    counter % 14 == 0 &&
                    counter % 13 == 0 &&
                    counter % 12 == 0 &&
                    counter % 11 == 0 &&
                    counter % 10 == 0 &&
                    counter % 9 == 0 &&
                    counter % 8 == 0 &&
                    counter % 7 == 0 &&
                    counter % 6 == 0 &&
                    counter % 5 == 0 &&
                    counter % 4 == 0 &&
                    counter % 3 == 0 &&
                    counter % 2 == 0)
                {
                    valueFound = true;
                    Console.WriteLine(counter + " is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20");
                }
                counter++;
            }
        }
    }
}

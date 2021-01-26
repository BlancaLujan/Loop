using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {

            bool myresponse = true;
            int myVariable = 0;
            int sum = 1;


            while (myresponse)
            {


                sum = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 16 + 17 + 18 + 19 + 20;
                myVariable++;

                Console.WriteLine("Looped" + sum);

                if (sum == 210)
                {
                    myresponse = false;
                }
            }
        }
    }
}

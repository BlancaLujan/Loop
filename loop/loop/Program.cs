using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {


            int result = 0;

            for (int x = 1; x < 21; x++)
            {
                result = result + x;
            }


            

            Console.WriteLine(result);
        }
    }
}

using System;

namespace Ryan_Posey___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = Convert.ToInt32(Console.ReadLine());
            string word = Console.ReadLine();
            integer = 0 - integer;

            while (integer < 0) {
                Console.WriteLine(-integer + " " + word);
                integer = integer + 1;

            }
            return;
        }
    }
}

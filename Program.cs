using System;

class Program
{
    static void Main(string[] args)
    {

        int number = 10;


        for (int i = 1; i <= number; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine("{0} adalah bilangan genap", i);
            }
            else
            {
                Console.WriteLine("{0} adalah bilangan ganjil", i);
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment
        int number = 10;

        // Pengulangan dengan for loop
        for (int i = 1; i <= number; i++)
        {
            // Pemilihan dengan if statement
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

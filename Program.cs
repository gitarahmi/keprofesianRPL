using System;

class Program
{
    static void Main(string[] args)
    {
        // assignment
        int number = 10;

        // perulangan
        for (int i = 1; i <= number; i++)
        {
            // pemilihan
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

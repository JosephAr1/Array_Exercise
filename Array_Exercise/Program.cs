using System;

namespace Array_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] balance = new int[5];
            int i, j;

            for(i=0; i <5; i++)
            {
                int number = 1 + 1;
                Console.WriteLine("Enter the balance of " + number);
                balance[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (j = 0; j < 5; j++)
            {
                int num = j + 1;
                Console.WriteLine("Value of the balance" + num + " is " + balance[j]);
            }
            
        }
    }
}

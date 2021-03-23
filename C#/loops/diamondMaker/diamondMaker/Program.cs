using System;

namespace diamondMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables | i = height's loop counter | j = spaces' loop counter | k = diamond blocks'(*) loop counter
            int i, j, k, x;
            // Getting the height of diamond
            Console.WriteLine("Note: in order to have diamond we need two pyramid attached to each other. one ascending and one descending.");
            Console.Write("Enter the height of your half-diamond: ");
            x = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"A {x * 2 - 1} story Diamond\n");
            // Note: in order to have diamond we need two pyramid attached to each other. one ascending and one descending.
            // Ascending pyramid or the first half of daimond
            for (i = 1; i <= x; i++)
            {
                // Space loop
                for (j = i; j < x; j++)
                    Console.Write("  ");
                // Star loop
                for (k = 1; k <= i * 2 - 1; k++)
                    Console.Write(" *");
                Console.WriteLine();
            }
            // Descending pyramid or the second half of daimond
            /* In order to have a perfect diamond, you'll need to have an odd number for height.
               Because the 'for' loop happens twice the number of rows will always be even so we decrease the 2nd loop steps by 1. */
            for (i = x - 1; i > 0; i--)
            {
                // Space loop
                for (j = x; j > i; j--)
                    Console.Write("  ");
                // Star loop
                for (k = i * 2 - 1; k > 0; k--)
                    Console.Write(" *");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

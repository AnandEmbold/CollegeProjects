using System;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing Variables
            string repeatReq;
            byte menuC;
            float number1, number2, result;
            while (true)
            {
                // Menu
                Console.WriteLine("Calculator menu:");
                Console.WriteLine("1- Sum (+)");
                Console.WriteLine("2- Subtract (-)");
                Console.WriteLine("3- Divide (÷)");
                Console.WriteLine("4- Multiply (×)");
                Console.WriteLine("---------------");
                Console.Write("Enter a number from the menu: ");
                menuC = byte.Parse(Console.ReadLine());
                // Menu input validation
                if (menuC < 1 || menuC > 4)
                {
                    Console.WriteLine("\nInvalid number!");
                    Console.WriteLine("Enter a number from the menu!\nPlease try again.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                // 1st Number
                Console.Write("\nEnter the 1st number: ");
                number1 = float.Parse(Console.ReadLine());
                // 2nd Number
                Console.Write("\nEnter the 2nd number: ");
                number2 = float.Parse(Console.ReadLine());
                // The operation
                switch (menuC)
                {
                    case 1:
                        result = number1 + number2;
                        Console.WriteLine("\n{0} + {1} = {2}", number1, number2, result);
                        break;
                    case 2:
                        result = number1 - number2;
                        Console.WriteLine("\n{0} - {1} = {2}", number1, number2, result);
                        break;
                    case 3:
                        result = number1 / number2;
                        Console.WriteLine("\n{0} ÷ {1} = {2}", number1, number2, result);
                        break;
                    case 4:
                        result = number1 * number2;
                        Console.WriteLine("\n{0} × {1} = {2}", number1, number2, result);
                        break;
                }
                // Loop request
                do
                {
                    Console.Write("\nDo you wish to try again [Y/N]? ");
                    repeatReq = Console.ReadLine().ToLower();
                } while (!(repeatReq == "n" || repeatReq == "y"));
                if (repeatReq == "y")
                {                    
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nBYE BYE then!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

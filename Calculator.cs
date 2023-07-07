using System;

namespace Hello
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Operand");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Operand");
            int b = int.Parse(Console.ReadLine());

            if(operation == 1)
            {
                int ans = a + b;
                Console.WriteLine("Answer : " + ans);
            }
            else if(operation == 2)
            {
                int ans = a - b;
                Console.WriteLine("Answer : " + ans);
            }
            else if(operation == 3)
            {
                int ans = a * b;
                Console.WriteLine("Answer : " + ans);
            }
            else if (operation == 4)
            {
                int ans = a / b;
                Console.WriteLine("Answer : " + ans);
            }
        }
    }
}

using System;

namespace Hello
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check For Prime Number");

            int number = int.Parse(Console.ReadLine());
            Boolean flag = false;

            for(int i=2;i<Math.Sqrt(number);i++)
            {
                if(number%i==0)
                {
                    flag = true;
                    break;
                }
            }

            if(flag)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}

using System;

namespace Hello
{
    internal class Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check For Palindrom : ");

            string check = Console.ReadLine();
            Boolean flag = false;

            for(int i=0;i<check.Length; i++)
            {
                if (check[i] != check[check.Length-i-1])
                {
                    flag = true;
                    break;
                }
            }

            if(flag)
            {
                Console.WriteLine("Not Palindrom");
            }
            else
            {
                Console.WriteLine("Palindrom");
            }

        }
    }
}

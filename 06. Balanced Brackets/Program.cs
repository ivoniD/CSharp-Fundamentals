using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // On the next n lines, you will receive "(", ")" or another string
            // You have to print "BALANCED" if the parentheses are balanced and "UNBALANCED" 

            int n = int.Parse(Console.ReadLine());
            bool isOpen = false;
            bool isBalanced = true;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpen)
                    {
                        isOpen = true;
                    }
                    else
                    {
                        isBalanced = true;
                    }
                }
                if (input == ")")
                {
                    if (isOpen)
                    {
                        isBalanced = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
               

            }
                if (isBalanced)
                {

                }
        }
    }
}

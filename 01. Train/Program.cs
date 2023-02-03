using System;

namespace P_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagonsArr = new int[n];
            int allPeople = 0;
            for (int i = 0; i < wagonsArr.Length; i++)
            {
                wagonsArr[i] = int.Parse(Console.ReadLine());
                allPeople += wagonsArr[i];
            }
            Console.WriteLine(string.Join(' ', wagonsArr));
            Console.WriteLine(allPeople);
        }
    }
}

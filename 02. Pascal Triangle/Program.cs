using System;

namespace P_02._Pascal_Triangle_ID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// 4

            int firstrow = 1;
            Console.WriteLine(firstrow);

            if (n == 1)
            {

                return;
            }
            int[] upArray =
            {
                1,
                1
            };
            Console.WriteLine(string.Join(' ', upArray));
            if (n == 2)
            {

                return;
            }

            for (int i = 0; i < upArray.Length + 1; i++)
            {
                int[] downArray = new int[upArray.Length + 1];

                for (int j = 1; j < downArray.Length - 1; j++)
                {
                    downArray[0] = 1;
                    downArray[downArray.Length - 1] = 1;

                    downArray[j] = upArray[j - 1] + upArray[j];
                }
                Console.WriteLine(string.Join(' ', downArray));
                upArray = downArray;
                if (upArray.Length + 1 > n)
                {
                    return;
                }
            }
        }
    }
}

using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
           string curSymbol = string.Empty;
            string text = string.Empty;
            while (true)
            {
                if (num % 10 == 0)
                {
                    curSymbol = " ";
                    text += curSymbol;
                    //Console.Write(text);
                }
                else if (num % 10 == 2)
                {
                    curSymbol = "a";
                    if (num == 22)
                    {
                        curSymbol = "b";
                    }
                    else if (num == 222)
                    {
                        curSymbol = "c";
                    }
                    text += curSymbol;
                    //Console.Write(text);
                }
                else if (num % 10 == 3)
                {
                    curSymbol = "d";
                    if (num == 33)
                    {
                        curSymbol = "e";
                    }
                    else if (num == 333)
                    {
                        curSymbol = "f";
                    }
                    text += curSymbol;
                   // Console.Write(text);
                }
                else if (num % 10 == 4)
                {
                    curSymbol = "g";
                    if (num == 44)
                    {
                        curSymbol = "h";
                    }
                    else if (num == 444)
                    {
                        curSymbol = "i";
                    }
                    text += curSymbol;
                    //Console.Write(text);
                }
                else if (num % 10 == 5)
                {
                    curSymbol = "j";
                    if (num == 55)
                    {
                        curSymbol = "k";
                    }
                    else if (num == 555)
                    {
                        curSymbol = "l";
                    }
                    text += curSymbol;
                   // Console.Write(text);
                }
                else if (num % 10 == 6)
                {
                    curSymbol = "m";
                    if (num == 66)
                    {
                        curSymbol = "n";
                    }
                    else if (num == 666)
                    {
                        curSymbol = "o";
                    }
                    text += curSymbol;
                    //Console.Write(text);
                }
                else if (num % 10 == 7)
                {
                    curSymbol = "p";
                    if (num == 22)
                    {
                        curSymbol = "q";
                    }
                    else if (num == 222)
                    {
                        curSymbol = "r";
                    }
                    else if (num == 7777)
                    {
                        curSymbol = "s";
                    }
                    text += curSymbol;
                    //Console.Write(text);
                }
                else if (num % 10 == 8)
                {
                    curSymbol = "t";
                    if (num == 88)
                    {
                        curSymbol = "u";
                    }
                    else if (num == 888)
                    {
                        curSymbol = "v";
                    }
                    text += curSymbol;
                   // Console.Write(text);
                }
                else if (num % 10 == 9)
                {
                    curSymbol = "w";
                    if (num == 99)
                    {
                        curSymbol = "x";
                    }
                    else if (num == 999)
                    {
                        curSymbol = "y";
                    }
                    else if (num == 9999)
                    {
                        curSymbol = "z";
                    }
                    text += curSymbol;
                  //  Console.Write(text);
                }
                num = int.Parse(Console.ReadLine());
                Console.Write(text);
            }
            

        }
    }
}

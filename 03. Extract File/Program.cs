using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C:\Internal\training-internal\Template.pptx
            //File name: Template
            // File extension: pptx

            string input = Console.ReadLine();

            int lastCross = input.LastIndexOf('\\');
            string needed = input.Substring(lastCross + 1);


            int dotPosition = needed.LastIndexOf('.');
            string fileName = needed.Substring(0, dotPosition);
            string extencion = needed.Substring(dotPosition + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extencion}");





        }
    }
}

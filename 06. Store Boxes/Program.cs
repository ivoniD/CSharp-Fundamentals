using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Store_Boxes
{
    class Item
    {
        public Item(string itemsName, double itemsPrice)
        {
            this.ItemsName = itemsName;
            this.ItemsPrice = itemsPrice;
        }
        public string ItemsName { get; set; }

        public double ItemsPrice { get; set; }

    }
    //: Serial Number, Item, Item Quantity, and Price for a Box.
    class Box
    {
        public Box(int serialNum, string item, int quantity, double boxPrice, double boxTotal)
        {
            this.SerialNumber = serialNum;
            this.Item = item;
            this.ItemQuantity = quantity;
            this.BoxPrice = boxPrice;
            this.BoxTotalPrice = boxTotal;
        }
        public int SerialNumber { get; set; }

        public string Item { get; set; }

        public int ItemQuantity { get; set; }

        public double BoxPrice { get; set; }

        public double BoxTotalPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int serialNum = int.Parse(cmdArgs[0]);
                string name = cmdArgs[1];
                int quantity = int.Parse(cmdArgs[2]);
                double itemPrice = double.Parse(cmdArgs[3]);
                double boxPrice = quantity * itemPrice;

                Item newItem = new Item(name, itemPrice);
                items.Add(newItem);
                Box newBox = new Box(serialNum, name, quantity, itemPrice, boxPrice);

                boxes.Add(newBox);

                command = Console.ReadLine();
            }
            boxes = boxes.OrderByDescending(boxes => boxes.BoxTotalPrice).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.BoxPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxTotalPrice:f2}");
            }
        }
    }
}

using System;

namespace Properties.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.length = 3;
            box.height = 4;
            box.width = 5;
            //Console.WriteLine("Box length is " + box.le);

            box.DisplayInfo();
        }
    }
}

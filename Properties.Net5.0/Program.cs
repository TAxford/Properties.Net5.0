using System;

namespace Properties.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.length = 3;
            box.SetLength(4);
            box.Height = -4;
            box.Width = 5;
            Console.WriteLine("Box s volume is " + box.Width);
            Console.WriteLine("Box s width is " + box.GetVolume());
            box.DisplayInfo();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Net5._0
{
    internal class Box
    {
        // member variables
        public int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and height is {1} and width is {2} so the volumeis {3}",
                length, height, width, volume = length*height*width);
        }

    }
}

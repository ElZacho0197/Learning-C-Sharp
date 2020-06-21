using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class GlazerCalc
    {
        static public void glazerCalc()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter the width of the window in feet.");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter the height of the window in feet.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = (2 * width) + (2 * height);
            glassArea = (width * height) * 2;

            Console.WriteLine("The length of wood is " + woodLength + " feet.");
            Console.WriteLine("The area of the glass is " + glassArea + " square feet.");
            Console.WriteLine("Press Enter to quit...");
            Console.ReadLine();
        }
    }
}

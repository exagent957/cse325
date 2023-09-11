using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            string myName, myLocation;
            var currentDate = DateTime.Now;
            var christmas = new DateTime(2023, 12, 25);
            var daysBetween = christmas - currentDate;
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            myName = "Marc Williamson";
            myLocation = "Hartselle, Alabama";
            Console.WriteLine("My name is " + myName +".");
            Console.WriteLine("I am from " + myLocation+".");
            Console.WriteLine("Today is " + currentDate.ToString("MM/dd/yyyy")+".");
            Console.WriteLine("There are " + daysBetween.Days + " days until Christmas.");
            Console.WriteLine("Enter width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            Console.ReadKey();
        }
    }
}

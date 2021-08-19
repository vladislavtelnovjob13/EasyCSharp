using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCSharp
{
    class Properties_Shed
    {

        static void Main(string[] args)
        {
            Shed myFirstShed = new Shed();
            myFirstShed.Height = 10;
            myFirstShed.Width = 20;
            myFirstShed.Lengthwise = myFirstShed.Width;

            Console.WriteLine("Высота =" + myFirstShed.Height);
            Console.WriteLine("Ширина =" + myFirstShed.Width);
            Console.WriteLine("Глубина =" + myFirstShed.Lengthwise);

            int size = myFirstShed.GetSize();
            Console.WriteLine("Объем =" + size);
            Console.WriteLine("Объем =" + myFirstShed.GetSize());


            Console.ReadLine();

            Shed shed = new Shed();
            shed.Height = 1;
            shed.Width = 5;
            shed.Lengthwise = 10;
            shed.ExpandSize(10, 13, 14);
        }
    }

}

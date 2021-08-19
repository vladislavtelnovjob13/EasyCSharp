using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCSharp
{
    class Shed
    {
        int width;
        int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Lengthwise { get; set; }

        public int GetSize()
        {
            int size = width * height * Lengthwise;
            return size;

            //return width * height * Lengthwise;
        }

        public void ExpandSize(int x, int y, int h) 
        {
            Width += x;
            Lengthwise += y;
            Height += h;

        }
    }
}

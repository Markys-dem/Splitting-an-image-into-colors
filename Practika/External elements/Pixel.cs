using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Practika.External_elements
{
    class Pixel
    {
        //Счётчик пикселей с данным цветом
        public double count;
        //Цвет 
        public Color color;

        public Pixel(Color cl)
        {
            count = 0;
            color = cl;
        }

        public void plusCount()
        {
            count++;
        }



    }
}

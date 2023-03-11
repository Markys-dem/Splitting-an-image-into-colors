using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practika.External_elements;
using System.Drawing;

namespace Practika.DecisionTreeClassifier.Classification
{
    class CountColor
    {
        private Monochrome monochrome = new Monochrome();
        private Multicolored multicolored = new Multicolored();

        public InfoImage checkCountColor(List<Pixel> pixels)
        {
            if((double)(pixels[0].count / sum(pixels)) >= 0.8 && (double)(pixels[1].count / sum(pixels)) <= 0.4)
            {
                return monochrome.checkMonochrome(pixels);
            }
            return multicolored.detectionMainColor(pixels);
        }

        private double sum(List<Pixel> pixels)
        {
            double sum = 0;
            for (int i=0; i<pixels.Count; i++)
            {
                sum += pixels[i].count;
            }
            return sum;
        }
    }
}

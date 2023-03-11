using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practika.External_elements;

namespace Practika.DecisionTreeClassifier.Classification
{
    class Multicolored
    {
        ColorDetection2 colorDetection2 = new ColorDetection2();
        public InfoImage detectionMainColor(List<Pixel> pixels)
        {
            if (checkVolume(pixels))
            {
                return new InfoImage(pixels[0].color, pixels[1].color, 2);
            }
            return new InfoImage(pixels[0].color, pixels[1].color, pixels[2].color, 4);
        }

        private bool checkVolume(List<Pixel> pixels)
        {
            double sum = 0;
            for(int i=0;i<pixels.Count; i++)
            {
                sum += pixels[i].count;
            }
            return (pixels[0].count + pixels[1].count) / sum >= 0.75;
        }
    }
}

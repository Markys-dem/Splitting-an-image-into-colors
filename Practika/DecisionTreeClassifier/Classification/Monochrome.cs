using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practika.External_elements;
using System.Drawing;

namespace Practika.DecisionTreeClassifier.Classification
{
    class Monochrome
    {
        private ColorDetection colorDetection = new ColorDetection();
        public InfoImage checkMonochrome(List<Pixel> pixels)
        {
            return colorDetection.detectionColor(pixels);
        }
        
    }
}

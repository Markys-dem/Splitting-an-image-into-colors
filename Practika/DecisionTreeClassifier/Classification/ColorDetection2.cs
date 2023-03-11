using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practika.External_elements;

namespace Practika.DecisionTreeClassifier.Classification
{
    class ColorDetection2
    {
        public InfoImage detectionColor(List<Pixel> pixels)
        {
            return new InfoImage(pixels[0].color,pixels[1].color, 2);
        }
    }
}

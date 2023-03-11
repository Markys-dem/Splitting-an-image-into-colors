using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practika.External_elements;
using System.Drawing;

namespace Practika.DecisionTreeClassifier.Classification
{
    class WhiteAndBlack
    {
        private CountColor countColor = new CountColor();
        public InfoImage checkColor(List<Pixel> pixels)
        {
            if((pixels[0].color == Color.FromArgb(255, 0, 0, 0) || pixels[0].color == Color.White || pixels[0].color == Color.FromArgb(255, 192, 192, 192) || pixels[0].color == Color.FromArgb(255, 102, 51, 0))
                && (pixels[1].color == Color.FromArgb(255, 0, 0, 0) || pixels[1].color == Color.FromArgb(255, 255, 255, 255) || pixels[1].color == Color.FromArgb(255, 192, 192, 192) || pixels[1].color == Color.FromArgb(255, 102, 51, 0))
                && (pixels[2].color == Color.FromArgb(255, 0, 0, 0) || pixels[2].color == Color.FromArgb(255, 255, 255, 255) || pixels[2].color == Color.FromArgb(255, 192, 192, 192) || pixels[2].color == Color.FromArgb(255, 102, 51, 0)))
            {
                return new InfoImage (pixels[0].color, pixels[1].color, pixels[2].color, 3);
            }

            return countColor.checkCountColor(pixels);
        }

    }
}

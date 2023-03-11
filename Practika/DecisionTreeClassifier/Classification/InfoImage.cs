using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Practika.DecisionTreeClassifier.Classification
{
    public class InfoImage
    {
        public List<Color> color = new List<Color>();
        public int countColor;

        public InfoImage() { }
        //Монохрамотическое
        public InfoImage(Color cl, int contC)
        {
            color.Add(cl);
            countColor = contC;
        }
        //Черное белое и разноцветное
        public InfoImage(Color cl,Color cl2, Color cl3, int contC)
        {
            color.Add(cl);
            color.Add(cl2);
            color.Add(cl3);
            countColor = contC;
        }

        //Двух цветное
        public InfoImage(Color cl, Color cl2, int contC)
        {
            color.Add(cl);
            color.Add(cl2);
            countColor = contC;
        }

    }
}

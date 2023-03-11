using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practika.DecisionTreeClassifier.Classification;

namespace Practika
{
    public partial class InformationOnImage : Form
    {
        private int heigth;
        private int wideth;
        protected InfoImage infoImage = new InfoImage();
        public InformationOnImage(int h, int w, InfoImage info)
        {
            InitializeComponent();
            heigth = h;
            wideth = w;
            infoImage = info;
        }

        private void InformationOnImage_Load(object sender, EventArgs e)
        {
            if (infoImage.countColor == 1)
            {
                InfoLable.Text = "Изображение Монохроматическое \n Высота: " + heigth.ToString() + "\n Ширина: " + wideth.ToString(); ;
                mainColorBox.BackColor = infoImage.color[0];
            }
            else if (infoImage.countColor == 2)
            {
                InfoLable.Text = "Изображение Двухцветное \n Высота: " + heigth.ToString() + "\n Ширина: " + wideth.ToString(); ;
                mainColorBox.BackColor = infoImage.color[0];
                SecondColorBox.BackColor = infoImage.color[1];
            }
            else if(infoImage.countColor == 3) {
                    InfoLable.Text = "Изображение Черно-Белое \n Высота: " + heigth.ToString() + "\n Ширина: " + wideth.ToString(); ;
                    mainColorBox.BackColor = infoImage.color[0];
                    SecondColorBox.BackColor = infoImage.color[1];
                    pictureBox3.BackColor = infoImage.color[2];
            }
            else if (infoImage.countColor == 4)
            {
                InfoLable.Text = "Изображение Разноцветное \n Высота: " + heigth.ToString() + "\n Ширина: " + wideth.ToString(); ;
                mainColorBox.BackColor = infoImage.color[0];
                SecondColorBox.BackColor = infoImage.color[1];
                pictureBox3.BackColor = infoImage.color[2];
            }
        }
    }
}

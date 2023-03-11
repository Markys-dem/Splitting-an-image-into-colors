using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Practika.External_elements
{
    class WorkImage
    {
        private Image image = null;

        //Основные данные с которыми я работаю
        //Pixel (Color; coumt)     count у всех 0
        private  List<Pixel> map = new List<Pixel>() 
        { 
            new Pixel(Color.FromArgb(255,255,0,0)),//red
            new Pixel(Color.FromArgb(255,255,128,0)),//orange 
            new Pixel(Color.FromArgb(255,255,255,0)),//yellow
            new Pixel(Color.FromArgb(255,128,255,0)),//ligth green 
            new Pixel(Color.FromArgb(255,0,255,0)),//green
            new Pixel(Color.FromArgb(255,0,255,80)),//beryzovi
            new Pixel(Color.FromArgb(255,0,255,255)),//cayn
            new Pixel(Color.FromArgb(255,0,128,255)),//light blue
            new Pixel(Color.FromArgb(255,0,0,255)),//blue
            new Pixel(Color.FromArgb(255,128,0,255)),//Lilac
            new Pixel(Color.FromArgb(255,255,0,255)),//purple
            new Pixel(Color.FromArgb(255,255,0,128)),//Pink
            new Pixel(Color.FromArgb(255,0,0,0)),//black
            new Pixel(Color.FromArgb(255,255,255,255)),//white
            new Pixel(Color.FromArgb(255,102,51,0)),//Brown
            new Pixel(Color.FromArgb(255,192,192,192)),//Greyy
            new Pixel(Color.FromArgb(255,255,255,204)),//pink
            new Pixel(Color.FromArgb(255,255,229,204)),//Beige
            new Pixel(Color.FromArgb(255,255,215,0)),//Gold
            new Pixel(Color.FromArgb(255,0,0,153)),//Black Blue
            new Pixel(Color.FromArgb(255,255,153,204))
        };
        public WorkImage(Image im)
        {
            image = im;
        }


        private void creatMainColor()
        {
            //Перевод изображения в матрицу пикселей
            Bitmap btm = new Bitmap(image);
            for (int i=0; i< btm.Width; i++)
            {
                for (int j=0; j<btm.Height; j++)
                {
                    //Достаю цвет пикселя
                    Color newColor = btm.GetPixel(i, j);
                    //Метод нахождения цвета
                    FindNearestColor(newColor);
                }
            }
        }
        
        //Метод рассчитывает расстояние между цветами двух пикселей
        private static int GetDistance(Color current, Color match)
        {
            //Тут думаю будет всё понятно, обычная формула
            int redDifference;
            int greenDifference;
            int blueDifference;

            redDifference = current.R - match.R;
            greenDifference = current.G - match.G;
            blueDifference = current.B - match.B;

            return redDifference * redDifference + greenDifference * greenDifference + 
            blueDifference * blueDifference;
        }

        //Метод сравнивает Цвет пикселя и возврощает индекс цвета map, к которому цвет пикселя близок
        private void FindNearestColor(Color current)
        {
            //Наименьшая дистанция
            //Нужна для сравнения "расстояния" между цветами, чтобы найти минимальное
            int shortestDistance;
            //индекс нужного элемента листа, для пополнения счётчика
            int index;

            index = -1;
            //Просто беру максимальное значения для удобства
            shortestDistance = int.MaxValue;

            for (int i = 0; i < map.Count; i++)
            {
                Color match;
                int distance;
                //Беру цвет первого элемента List
                match = map[i].color;
                //Вычисление дистанции
                distance = GetDistance(current, match);

                //Если дисатнция меньше прошлой, я ее запоминаю и индекс цвета тоже запоминаю
                if (distance < shortestDistance)
                {
                    index = i;
                    shortestDistance = distance;
                }
            }
            //В конце пополняю счётчик данного цвета
            map[index].plusCount();
        }

        public List<Pixel>  getListColor (){
            //Вызывается основная функция
            creatMainColor();
            //Цвета у которых маленький показатель (я пока не знаю какой порог поставить)
            //я их удаляю
            for (int i=0; i<map.Count; i++){
                if (map[i].count == 0){
                    map.RemoveAt(i);
                }
            }
            //Сортировка по убыванию, что бы 1 стоял цвет с большим повторением
            map.Sort(delegate (Pixel x, Pixel y)
            {
                return y.count.CompareTo(x.count);
            });
            return map;
        }
    }
}

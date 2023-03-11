using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practika.External_elements;

namespace Practika
{
    public partial class AllColor : Form
    {
        //Массив всех изображений с различным процентом пикселей
        private List<Bitmap> btm = new List<Bitmap>();
        private Random random = new Random();
        public AllColor()
        {
            InitializeComponent();
            Procent.Text = "";
        }

        private void AllColor_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //Перевод ползунка в начальное положение
            trackBar1.Value = 1;
            //Открытие файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Установка фильтра
            openFileDialog.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Отключаем возможность двигать ползунок
                btnloadingImage.Enabled = false;
                ImageBox.Image = null;
                //очищаем лист для нового изображения
                btm.Clear();
                //переводим изображение в матрицу пикселей
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                //Процесс обработки изображения
                await Task.Run (()=> { Processing(bitmap); });
                btnloadingImage.Enabled = true;
            }
        }

        private List<CoordinatesPixel> getPixels(Bitmap bitmap)
        {
            List<CoordinatesPixel> pixels = new List<CoordinatesPixel>(bitmap.Width * bitmap.Height);
            for(int i=0; i<bitmap.Width; i++)
            {
                for (int j=0;j<bitmap.Height; j++)
                {
                    pixels.Add(new CoordinatesPixel()
                    {
                        color = bitmap.GetPixel(i, j),
                        point = new Point() { X = i, Y = j }
                    });
                }
            }
            return pixels;
        }

        private  void Processing(Bitmap bitmap)
        {
            //Создается лист с координатами и цветами пикселей
            List<CoordinatesPixel> pixels = getPixels(bitmap);
            //вычиялется шаг
            var step = (bitmap.Width * bitmap.Height) / 100;
            //Создаётся новый лист с новыми пикселями размер меньше
            List<CoordinatesPixel> current = new List<CoordinatesPixel>(pixels.Count - step);
            //Для каждого значения Ползунка
            //Мы рассчитываем матрицу пикселей
            for (int i=1; i<trackBar1.Maximum; i++)
            {
                for (int j=0; j<step; j++)
                {
                    //Рандомно выбираем индекс пикселя
                    var index = random.Next(pixels.Count);
                    //Добавляем удалённые пиксели в лист
                    current.Add(pixels[index]);
                    //Удаляем пиксели
                    pixels.RemoveAt(index);
                }
                Bitmap currentBTM = new Bitmap(bitmap.Width, bitmap.Height);
                //Заполняем новую матрицу пикселей
                foreach (var pixel in current)
                {
                    currentBTM.SetPixel(pixel.point.X, pixel.point.Y, pixel.color);
                }
                //Добавляем ее в наш основной лист
                btm.Add(currentBTM);

                this.Invoke(new Action(() =>
                {
                    Procent.Text = $"{i} %";
                }));
            }
            btm.Add(bitmap);
        }

        private void btnCloseImage_Click(object sender, EventArgs e)
        {
            //Кнопка закрытия изображения
            Procent.Text = "";
            this.ImageBox.Image = null;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (btm == null || btm.Count==0)
            {
                return;
            }
            //Взависимости от пложения ползунка, программа выбирает нужное изображение из массива BitMap
            ImageBox.Image = btm[trackBar1.Value - 1];
        }
    }
}

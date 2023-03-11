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
using Practika.DecisionTreeClassifier.Classification;

namespace Practika
{
    public partial class FormClassification : Form
    {
        //форма хранит в себе изображение и экземпляр класса, для классификации
        public Image image=null;
        WorkImage work;
        public FormClassification()
        {
            InitializeComponent();
        }

        private void LoadingImage_Load(object sender, EventArgs e)
        {

        }
        //Кнопка открытия фотографии
        private void btnopenFile_Click(object sender, EventArgs e)
        {
            //Очистка фотографии и цветов
            image = null;
            this.pictureBox1.Image = null;
            pictureBox3.BackColor = this.BackColor;
            pictureBox4.BackColor = this.BackColor;
            pictureBox5.BackColor = this.BackColor;
            pictureBox6.BackColor = this.BackColor;
            pictureBox7.BackColor = this.BackColor;
            //Создание экземпляра класса, для того, чтоб открыть файл с компьютера
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Установка фильтра для открытия определенного файла
            openFileDialog.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            //Проверка открылся ли файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = image;
            }
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            //Проверка для классификации
            //Если изображение не выбрано, выведется предупрждение
            if (image != null)
            {
                work = new WorkImage(image);
            }
            else
            {
                MessageBox.Show("Отсутсвует фото");
                return;
            }

            //Через класс WorkImage получаем список цветов и количества повторений этого цвета
            List<Pixel> mainColor = new List<Pixel>(work.getListColor());
            //Получаем информацию с помощью дерева решений
            InfoImage infoImage = new WhiteAndBlack().checkColor(mainColor);
            //Передаём информацию в форму вывода
            InformationOnImage information = new InformationOnImage(image.Height, image.Width, infoImage);
            information.Show();
            
            //pictureBox2.BackColor = mainColor[0].color;
            //pictureBox3.BackColor = mainColor[1].color;
            //pictureBox4.BackColor = mainColor[2].color;
            //pictureBox5.BackColor = mainColor[3].color;
            //pictureBox6.BackColor = mainColor[4].color;

        }

        private void btnCloseImage_Click(object sender, EventArgs e)
        {
            image = null;
            this.pictureBox1.Image = null;
            pictureBox3.BackColor = this.BackColor;
            pictureBox4.BackColor = this.BackColor;
            pictureBox5.BackColor = this.BackColor;
            pictureBox6.BackColor = this.BackColor;
            pictureBox7.BackColor = this.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Действия аналогичны при классификации, только первые 5 цветов выводятся в pictureBox
            if (image != null)
            {
                work = new WorkImage(image);
            }
            else
            {
                MessageBox.Show("Отсутсвует фото");
                return;
            }
            List<Pixel> mainColor = new List<Pixel>(work.getListColor());
            pictureBox3.BackColor = mainColor[0].color;
            pictureBox4.BackColor = mainColor[1].color;
            pictureBox5.BackColor = mainColor[2].color;
            pictureBox6.BackColor = mainColor[3].color;
            pictureBox7.BackColor = mainColor[4].color;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //Вызывается форма с информацие о программе
            this.diffForms.Controls.Clear();
            Info info = new Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            info.FormBorderStyle = FormBorderStyle.None;
            this.diffForms.Controls.Add(info);
            info.Show();
        }


        private async void btnAllColor_Click(object sender, EventArgs e)
        {
            //Вызывает форма с дополнительной функией
            this.diffForms.Controls.Clear();
            AllColor allColor = new AllColor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            allColor.FormBorderStyle = FormBorderStyle.None;
            this.diffForms.Controls.Add(allColor);
            allColor.Show();
        }

        private void btnClassification_Click(object sender, EventArgs e)
        {
            //Вызывается форма для классификации
            this.diffForms.Controls.Clear();
            FormClassification formClassification = new FormClassification() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formClassification.FormBorderStyle = FormBorderStyle.None;
            this.diffForms.Controls.Add(formClassification);
            formClassification.Show();

        }
    }
}

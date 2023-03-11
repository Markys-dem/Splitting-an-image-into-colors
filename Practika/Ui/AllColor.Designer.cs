
namespace Practika
{
    partial class AllColor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTracBar = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.MenuImage = new System.Windows.Forms.Panel();
            this.btnCloseImage = new System.Windows.Forms.Button();
            this.btnloadingImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Procent = new System.Windows.Forms.Label();
            this.panelTracBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.MenuImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTracBar
            // 
            this.panelTracBar.Controls.Add(this.trackBar1);
            this.panelTracBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTracBar.Location = new System.Drawing.Point(863, 0);
            this.panelTracBar.Name = "panelTracBar";
            this.panelTracBar.Size = new System.Drawing.Size(70, 590);
            this.panelTracBar.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(70, 590);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ImageBox
            // 
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImageBox.Location = new System.Drawing.Point(206, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(657, 590);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // MenuImage
            // 
            this.MenuImage.Controls.Add(this.Procent);
            this.MenuImage.Controls.Add(this.btnCloseImage);
            this.MenuImage.Controls.Add(this.btnloadingImage);
            this.MenuImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuImage.Location = new System.Drawing.Point(0, 0);
            this.MenuImage.Name = "MenuImage";
            this.MenuImage.Size = new System.Drawing.Size(200, 590);
            this.MenuImage.TabIndex = 2;
            // 
            // btnCloseImage
            // 
            this.btnCloseImage.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnCloseImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCloseImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseImage.Location = new System.Drawing.Point(0, 68);
            this.btnCloseImage.Name = "btnCloseImage";
            this.btnCloseImage.Size = new System.Drawing.Size(200, 68);
            this.btnCloseImage.TabIndex = 1;
            this.btnCloseImage.Text = "Закрыть изображение";
            this.btnCloseImage.UseVisualStyleBackColor = false;
            this.btnCloseImage.Click += new System.EventHandler(this.btnCloseImage_Click);
            // 
            // btnloadingImage
            // 
            this.btnloadingImage.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnloadingImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnloadingImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnloadingImage.Location = new System.Drawing.Point(0, 0);
            this.btnloadingImage.Name = "btnloadingImage";
            this.btnloadingImage.Size = new System.Drawing.Size(200, 68);
            this.btnloadingImage.TabIndex = 0;
            this.btnloadingImage.Text = "Загрузить изображение";
            this.btnloadingImage.UseVisualStyleBackColor = false;
            this.btnloadingImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Procent
            // 
            this.Procent.AutoSize = true;
            this.Procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Procent.Location = new System.Drawing.Point(13, 174);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(64, 25);
            this.Procent.TabIndex = 2;
            this.Procent.Text = "label1";
            // 
            // AllColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(933, 590);
            this.Controls.Add(this.MenuImage);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.panelTracBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllColor";
            this.Text = "AllColor";
            this.Load += new System.EventHandler(this.AllColor_Load);
            this.panelTracBar.ResumeLayout(false);
            this.panelTracBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.MenuImage.ResumeLayout(false);
            this.MenuImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTracBar;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel MenuImage;
        private System.Windows.Forms.Button btnloadingImage;
        private System.Windows.Forms.Button btnCloseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label Procent;
    }
}
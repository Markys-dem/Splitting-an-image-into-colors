
namespace Practika
{
    partial class InformationOnImage
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
            this.mainColorBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SecondColorBox = new System.Windows.Forms.PictureBox();
            this.InfoLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainColorBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainColorBox
            // 
            this.mainColorBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainColorBox.Location = new System.Drawing.Point(0, 0);
            this.mainColorBox.Name = "mainColorBox";
            this.mainColorBox.Size = new System.Drawing.Size(242, 50);
            this.mainColorBox.TabIndex = 0;
            this.mainColorBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.SecondColorBox);
            this.panel1.Controls.Add(this.mainColorBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 149);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(242, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // SecondColorBox
            // 
            this.SecondColorBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondColorBox.Location = new System.Drawing.Point(0, 50);
            this.SecondColorBox.Name = "SecondColorBox";
            this.SecondColorBox.Size = new System.Drawing.Size(242, 50);
            this.SecondColorBox.TabIndex = 1;
            this.SecondColorBox.TabStop = false;
            // 
            // InfoLable
            // 
            this.InfoLable.AutoSize = true;
            this.InfoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLable.Location = new System.Drawing.Point(331, 44);
            this.InfoLable.Name = "InfoLable";
            this.InfoLable.Size = new System.Drawing.Size(79, 29);
            this.InfoLable.TabIndex = 2;
            this.InfoLable.Text = "label1";
            // 
            // InformationOnImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoLable);
            this.Controls.Add(this.panel1);
            this.Name = "InformationOnImage";
            this.Text = "InformationOnImage";
            this.Load += new System.EventHandler(this.InformationOnImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainColorBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondColorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainColorBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox SecondColorBox;
        private System.Windows.Forms.Label InfoLable;
    }
}

namespace Practika
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnAllColor;
            System.Windows.Forms.Button btnClassification;
            System.Windows.Forms.Button btnInfo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.diffForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnAllColor = new System.Windows.Forms.Button();
            btnClassification = new System.Windows.Forms.Button();
            btnInfo = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllColor
            // 
            btnAllColor.BackColor = System.Drawing.Color.PapayaWhip;
            btnAllColor.Dock = System.Windows.Forms.DockStyle.Top;
            btnAllColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAllColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnAllColor.Location = new System.Drawing.Point(0, 138);
            btnAllColor.Name = "btnAllColor";
            btnAllColor.Size = new System.Drawing.Size(158, 69);
            btnAllColor.TabIndex = 2;
            btnAllColor.Text = "Доппольнительная Фукнция";
            btnAllColor.UseVisualStyleBackColor = false;
            btnAllColor.Click += new System.EventHandler(this.btnAllColor_Click);
            // 
            // btnClassification
            // 
            btnClassification.BackColor = System.Drawing.Color.PapayaWhip;
            btnClassification.Dock = System.Windows.Forms.DockStyle.Top;
            btnClassification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnClassification.Location = new System.Drawing.Point(0, 69);
            btnClassification.Name = "btnClassification";
            btnClassification.Size = new System.Drawing.Size(158, 69);
            btnClassification.TabIndex = 1;
            btnClassification.Text = "Классификация";
            btnClassification.UseVisualStyleBackColor = false;
            btnClassification.Click += new System.EventHandler(this.btnClassification_Click);
            // 
            // btnInfo
            // 
            btnInfo.BackColor = System.Drawing.Color.PapayaWhip;
            btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btnInfo.Location = new System.Drawing.Point(0, 0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(158, 69);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Информация";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.AutoSize = true;
            this.panelMenu.Controls.Add(btnAllColor);
            this.panelMenu.Controls.Add(btnClassification);
            this.panelMenu.Controls.Add(btnInfo);
            this.panelMenu.Location = new System.Drawing.Point(-2, 233);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(158, 457);
            this.panelMenu.TabIndex = 0;
            // 
            // diffForms
            // 
            this.diffForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diffForms.Location = new System.Drawing.Point(162, 12);
            this.diffForms.Name = "diffForms";
            this.diffForms.Size = new System.Drawing.Size(987, 677);
            this.diffForms.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1166, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.diffForms);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(886, 645);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnInfo_Click);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel diffForms;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


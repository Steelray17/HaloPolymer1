namespace HaloPolymer
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenCeh = new System.Windows.Forms.Button();
            this.buttonOpenASYTP = new System.Windows.Forms.Button();
            this.buttonOpenEquipment = new System.Windows.Forms.Button();
            this.buttonOpenDB = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenCeh
            // 
            this.buttonOpenCeh.Location = new System.Drawing.Point(318, 12);
            this.buttonOpenCeh.Name = "buttonOpenCeh";
            this.buttonOpenCeh.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenCeh.TabIndex = 1;
            this.buttonOpenCeh.Text = "Цеха";
            this.buttonOpenCeh.UseVisualStyleBackColor = true;
            this.buttonOpenCeh.Click += new System.EventHandler(this.buttonOpenCeh_Click);
            // 
            // buttonOpenASYTP
            // 
            this.buttonOpenASYTP.Location = new System.Drawing.Point(318, 66);
            this.buttonOpenASYTP.Name = "buttonOpenASYTP";
            this.buttonOpenASYTP.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenASYTP.TabIndex = 2;
            this.buttonOpenASYTP.Text = "АСУТП";
            this.buttonOpenASYTP.UseVisualStyleBackColor = true;
            this.buttonOpenASYTP.Click += new System.EventHandler(this.buttonOpenASYTP_Click);
            // 
            // buttonOpenEquipment
            // 
            this.buttonOpenEquipment.Location = new System.Drawing.Point(318, 120);
            this.buttonOpenEquipment.Name = "buttonOpenEquipment";
            this.buttonOpenEquipment.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenEquipment.TabIndex = 3;
            this.buttonOpenEquipment.Text = "Оборудование";
            this.buttonOpenEquipment.UseVisualStyleBackColor = true;
            this.buttonOpenEquipment.Click += new System.EventHandler(this.buttonOpenEquipment_Click);
            // 
            // buttonOpenDB
            // 
            this.buttonOpenDB.Location = new System.Drawing.Point(33, 97);
            this.buttonOpenDB.Name = "buttonOpenDB";
            this.buttonOpenDB.Size = new System.Drawing.Size(255, 48);
            this.buttonOpenDB.TabIndex = 4;
            this.buttonOpenDB.Text = "База данных IP адресов АСУТП";
            this.buttonOpenDB.UseVisualStyleBackColor = true;
            this.buttonOpenDB.Click += new System.EventHandler(this.buttonOpenDB_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 175);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonOpenDB);
            this.Controls.Add(this.buttonOpenEquipment);
            this.Controls.Add(this.buttonOpenASYTP);
            this.Controls.Add(this.buttonOpenCeh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведение базы данных IP адресов АСУТП";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenCeh;
        private System.Windows.Forms.Button buttonOpenASYTP;
        private System.Windows.Forms.Button buttonOpenEquipment;
        private System.Windows.Forms.Button buttonOpenDB;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


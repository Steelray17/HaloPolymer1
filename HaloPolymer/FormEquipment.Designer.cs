namespace HaloPolymer
{
    partial class FormEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipment));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewEquipment = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameEquipment = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonDel.Location = new System.Drawing.Point(322, 218);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(117, 36);
            this.buttonDel.TabIndex = 35;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonEdit.Location = new System.Drawing.Point(198, 218);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 34;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAdd.Location = new System.Drawing.Point(75, 218);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewEquipment
            // 
            this.listViewEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewEquipment.FullRowSelect = true;
            this.listViewEquipment.GridLines = true;
            this.listViewEquipment.HideSelection = false;
            this.listViewEquipment.Location = new System.Drawing.Point(138, 93);
            this.listViewEquipment.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.listViewEquipment.Name = "listViewEquipment";
            this.listViewEquipment.Size = new System.Drawing.Size(301, 119);
            this.listViewEquipment.TabIndex = 32;
            this.listViewEquipment.UseCompatibleStateImageBehavior = false;
            this.listViewEquipment.View = System.Windows.Forms.View.Details;
            this.listViewEquipment.SelectedIndexChanged += new System.EventHandler(this.listViewEquipment_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название оборудования";
            this.columnHeader2.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название оборудования";
            // 
            // textBoxNameEquipment
            // 
            this.textBoxNameEquipment.Location = new System.Drawing.Point(12, 142);
            this.textBoxNameEquipment.Name = "textBoxNameEquipment";
            this.textBoxNameEquipment.Size = new System.Drawing.Size(120, 20);
            this.textBoxNameEquipment.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // FormEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 258);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameEquipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оборудование";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewEquipment;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameEquipment;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
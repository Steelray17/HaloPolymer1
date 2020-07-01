namespace HaloPolymer
{
    partial class FormCeh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCeh));
            this.textBoxNameCeha = new System.Windows.Forms.TextBox();
            this.textBoxNumberCeha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewCeh = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameCeha
            // 
            this.textBoxNameCeha.Location = new System.Drawing.Point(12, 93);
            this.textBoxNameCeha.Name = "textBoxNameCeha";
            this.textBoxNameCeha.Size = new System.Drawing.Size(120, 20);
            this.textBoxNameCeha.TabIndex = 0;
            // 
            // textBoxNumberCeha
            // 
            this.textBoxNumberCeha.Location = new System.Drawing.Point(12, 138);
            this.textBoxNumberCeha.Name = "textBoxNumberCeha";
            this.textBoxNumberCeha.Size = new System.Drawing.Size(120, 20);
            this.textBoxNumberCeha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название цеха";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер цеха";
            // 
            // listViewCeh
            // 
            this.listViewCeh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader10});
            this.listViewCeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewCeh.FullRowSelect = true;
            this.listViewCeh.GridLines = true;
            this.listViewCeh.HideSelection = false;
            this.listViewCeh.Location = new System.Drawing.Point(138, 77);
            this.listViewCeh.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.listViewCeh.Name = "listViewCeh";
            this.listViewCeh.Size = new System.Drawing.Size(425, 119);
            this.listViewCeh.TabIndex = 11;
            this.listViewCeh.UseCompatibleStateImageBehavior = false;
            this.listViewCeh.View = System.Windows.Forms.View.Details;
            this.listViewCeh.SelectedIndexChanged += new System.EventHandler(this.listViewCeh_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название цеха";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Номер цеха";
            this.columnHeader10.Width = 90;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonDel.Location = new System.Drawing.Point(446, 205);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(117, 36);
            this.buttonDel.TabIndex = 19;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonEdit.Location = new System.Drawing.Point(322, 205);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAdd.Location = new System.Drawing.Point(199, 205);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // FormCeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 246);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCeh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberCeha);
            this.Controls.Add(this.textBoxNameCeha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCeh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цеха";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameCeha;
        private System.Windows.Forms.TextBox textBoxNumberCeha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewCeh;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
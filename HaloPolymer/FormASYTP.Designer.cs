namespace HaloPolymer
{
    partial class FormASYTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormASYTP));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewASYTP = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxASYTP = new System.Windows.Forms.TextBox();
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
            this.buttonDel.TabIndex = 28;
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
            this.buttonEdit.TabIndex = 27;
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
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewASYTP
            // 
            this.listViewASYTP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewASYTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewASYTP.FullRowSelect = true;
            this.listViewASYTP.GridLines = true;
            this.listViewASYTP.HideSelection = false;
            this.listViewASYTP.Location = new System.Drawing.Point(138, 93);
            this.listViewASYTP.Margin = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.listViewASYTP.Name = "listViewASYTP";
            this.listViewASYTP.Size = new System.Drawing.Size(301, 119);
            this.listViewASYTP.TabIndex = 25;
            this.listViewASYTP.UseCompatibleStateImageBehavior = false;
            this.listViewASYTP.View = System.Windows.Forms.View.Details;
            this.listViewASYTP.SelectedIndexChanged += new System.EventHandler(this.listViewASYTP_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название АСУТП";
            this.columnHeader2.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название АСУТП";
            // 
            // textBoxASYTP
            // 
            this.textBoxASYTP.Location = new System.Drawing.Point(12, 142);
            this.textBoxASYTP.Name = "textBoxASYTP";
            this.textBoxASYTP.Size = new System.Drawing.Size(120, 20);
            this.textBoxASYTP.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // FormASYTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 258);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewASYTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxASYTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormASYTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АСУТП";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewASYTP;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxASYTP;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
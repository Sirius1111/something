namespace Lesson9_2
{
    partial class AddTovar
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTovar = new System.Windows.Forms.TextBox();
            this.categoryValue = new System.Windows.Forms.ComboBox();
            this.text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftLast = new System.Windows.Forms.Button();
            this.changeImg = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(36, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(167, 194);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // nameTovar
            // 
            this.nameTovar.Location = new System.Drawing.Point(254, 12);
            this.nameTovar.Name = "nameTovar";
            this.nameTovar.Size = new System.Drawing.Size(204, 20);
            this.nameTovar.TabIndex = 3;
            this.nameTovar.Text = "товар";
            this.nameTovar.Enter += new System.EventHandler(this.nameTovar_TextChanged);
            // 
            // categoryValue
            // 
            this.categoryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryValue.FormattingEnabled = true;
            this.categoryValue.Items.AddRange(new object[] {
            "Сендвичи",
            "Сырники",
            "Торты",
            "Классический кофе",
            "Чай",
            "Альтернативный кофе"});
            this.categoryValue.Location = new System.Drawing.Point(254, 44);
            this.categoryValue.Name = "categoryValue";
            this.categoryValue.Size = new System.Drawing.Size(204, 21);
            this.categoryValue.TabIndex = 5;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(254, 99);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(204, 107);
            this.text.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Состав";
            // 
            // leftLast
            // 
            this.leftLast.Location = new System.Drawing.Point(127, 272);
            this.leftLast.Name = "leftLast";
            this.leftLast.Size = new System.Drawing.Size(204, 34);
            this.leftLast.TabIndex = 8;
            this.leftLast.Text = "Вернуться назад";
            this.leftLast.UseVisualStyleBackColor = true;
            this.leftLast.Click += new System.EventHandler(this.left);
            // 
            // changeImg
            // 
            this.changeImg.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить продукт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.leftLast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.categoryValue);
            this.Controls.Add(this.nameTovar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Name = "AddTovar";
            this.Text = "AddTovar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TovarList_FormClosed);
            this.Load += new System.EventHandler(this.TovarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTovar;
        private System.Windows.Forms.ComboBox categoryValue;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button leftLast;
        private System.Windows.Forms.OpenFileDialog changeImg;
        private System.Windows.Forms.Button button2;
    }
}
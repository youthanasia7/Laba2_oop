namespace Laba2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Rectangle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Square = new System.Windows.Forms.Button();
            this.B_Ellipse = new System.Windows.Forms.Button();
            this.B_Circle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Move = new System.Windows.Forms.Button();
            this.B_Polygon = new System.Windows.Forms.Button();
            this.B_Triangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Plane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(313, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // B_Rectangle
            // 
            this.B_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Rectangle.Location = new System.Drawing.Point(26, 48);
            this.B_Rectangle.Name = "B_Rectangle";
            this.B_Rectangle.Size = new System.Drawing.Size(168, 30);
            this.B_Rectangle.TabIndex = 1;
            this.B_Rectangle.Text = "Прямоугольник";
            this.B_Rectangle.UseVisualStyleBackColor = true;
            this.B_Rectangle.Click += new System.EventHandler(this.B_Rectangle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Создание фигуры:";
            // 
            // B_Square
            // 
            this.B_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Square.Location = new System.Drawing.Point(26, 84);
            this.B_Square.Name = "B_Square";
            this.B_Square.Size = new System.Drawing.Size(168, 30);
            this.B_Square.TabIndex = 3;
            this.B_Square.Text = "Квадрат";
            this.B_Square.UseVisualStyleBackColor = true;
            this.B_Square.Click += new System.EventHandler(this.B_Square_Click);
            // 
            // B_Ellipse
            // 
            this.B_Ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Ellipse.Location = new System.Drawing.Point(26, 120);
            this.B_Ellipse.Name = "B_Ellipse";
            this.B_Ellipse.Size = new System.Drawing.Size(168, 30);
            this.B_Ellipse.TabIndex = 4;
            this.B_Ellipse.Text = "Эллипс";
            this.B_Ellipse.UseVisualStyleBackColor = true;
            this.B_Ellipse.Click += new System.EventHandler(this.B_Ellipse_Click);
            // 
            // B_Circle
            // 
            this.B_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Circle.Location = new System.Drawing.Point(26, 156);
            this.B_Circle.Name = "B_Circle";
            this.B_Circle.Size = new System.Drawing.Size(168, 30);
            this.B_Circle.TabIndex = 5;
            this.B_Circle.Text = "Круг";
            this.B_Circle.UseVisualStyleBackColor = true;
            this.B_Circle.Click += new System.EventHandler(this.B_Circle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(845, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистить полотно ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 436);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Удалить фигуру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_Move
            // 
            this.B_Move.Location = new System.Drawing.Point(632, 436);
            this.B_Move.Name = "B_Move";
            this.B_Move.Size = new System.Drawing.Size(134, 23);
            this.B_Move.TabIndex = 9;
            this.B_Move.Text = "Переместить фигуру";
            this.B_Move.UseVisualStyleBackColor = true;
            this.B_Move.Click += new System.EventHandler(this.B_Move_Click);
            // 
            // B_Polygon
            // 
            this.B_Polygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Polygon.Location = new System.Drawing.Point(26, 192);
            this.B_Polygon.Name = "B_Polygon";
            this.B_Polygon.Size = new System.Drawing.Size(168, 30);
            this.B_Polygon.TabIndex = 10;
            this.B_Polygon.Text = "Многоугольник";
            this.B_Polygon.UseVisualStyleBackColor = true;
            this.B_Polygon.Click += new System.EventHandler(this.B_Polygon_Click);
            // 
            // B_Triangle
            // 
            this.B_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Triangle.Location = new System.Drawing.Point(26, 228);
            this.B_Triangle.Name = "B_Triangle";
            this.B_Triangle.Size = new System.Drawing.Size(168, 30);
            this.B_Triangle.TabIndex = 11;
            this.B_Triangle.Text = "Треугольник";
            this.B_Triangle.UseVisualStyleBackColor = true;
            this.B_Triangle.Click += new System.EventHandler(this.B_Triangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "(700;400)";
            // 
            // B_Plane
            // 
            this.B_Plane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.B_Plane.Location = new System.Drawing.Point(26, 264);
            this.B_Plane.Name = "B_Plane";
            this.B_Plane.Size = new System.Drawing.Size(168, 30);
            this.B_Plane.TabIndex = 13;
            this.B_Plane.Text = "Самолет";
            this.B_Plane.UseVisualStyleBackColor = true;
            this.B_Plane.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 490);
            this.Controls.Add(this.B_Plane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Triangle);
            this.Controls.Add(this.B_Polygon);
            this.Controls.Add(this.B_Move);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.B_Circle);
            this.Controls.Add(this.B_Ellipse);
            this.Controls.Add(this.B_Square);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Rectangle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_Rectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Square;
        private System.Windows.Forms.Button B_Ellipse;
        private System.Windows.Forms.Button B_Circle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_Move;
        private System.Windows.Forms.Button B_Polygon;
        private System.Windows.Forms.Button B_Triangle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Plane;
    }
}


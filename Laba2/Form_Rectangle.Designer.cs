namespace Laba2
{
    partial class Form_Rectangle
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
            this.button1 = new System.Windows.Forms.Button();
            this.BNewSize = new System.Windows.Forms.Button();
            this.BNewCord = new System.Windows.Forms.Button();
            this.newW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newY = new System.Windows.Forms.TextBox();
            this.newX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valW = new System.Windows.Forms.TextBox();
            this.valY = new System.Windows.Forms.TextBox();
            this.valX = new System.Windows.Forms.TextBox();
            this.RectDraw = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valH = new System.Windows.Forms.TextBox();
            this.newH = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BNewSize
            // 
            this.BNewSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BNewSize.Location = new System.Drawing.Point(241, 361);
            this.BNewSize.Name = "BNewSize";
            this.BNewSize.Size = new System.Drawing.Size(100, 29);
            this.BNewSize.TabIndex = 54;
            this.BNewSize.Text = "Изменить";
            this.BNewSize.UseVisualStyleBackColor = true;
            this.BNewSize.Click += new System.EventHandler(this.BNewSize_Click_1);
            // 
            // BNewCord
            // 
            this.BNewCord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BNewCord.Location = new System.Drawing.Point(58, 361);
            this.BNewCord.Name = "BNewCord";
            this.BNewCord.Size = new System.Drawing.Size(112, 29);
            this.BNewCord.TabIndex = 53;
            this.BNewCord.Text = "Переместить ";
            this.BNewCord.UseVisualStyleBackColor = true;
            this.BNewCord.Click += new System.EventHandler(this.BNewCord_Click_1);
            // 
            // newW
            // 
            this.newW.Location = new System.Drawing.Point(241, 290);
            this.newW.Name = "newW";
            this.newW.Size = new System.Drawing.Size(100, 20);
            this.newW.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(176, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ширина";
            // 
            // newY
            // 
            this.newY.Location = new System.Drawing.Point(70, 324);
            this.newY.Name = "newY";
            this.newY.Size = new System.Drawing.Size(100, 20);
            this.newY.TabIndex = 50;
            // 
            // newX
            // 
            this.newX.Location = new System.Drawing.Point(70, 289);
            this.newX.Name = "newX";
            this.newX.Size = new System.Drawing.Size(100, 20);
            this.newX.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(27, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(27, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(176, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ширина";
            // 
            // valW
            // 
            this.valW.Location = new System.Drawing.Point(241, 113);
            this.valW.Name = "valW";
            this.valW.Size = new System.Drawing.Size(100, 20);
            this.valW.TabIndex = 45;
            // 
            // valY
            // 
            this.valY.Location = new System.Drawing.Point(58, 155);
            this.valY.Name = "valY";
            this.valY.Size = new System.Drawing.Size(100, 20);
            this.valY.TabIndex = 44;
            // 
            // valX
            // 
            this.valX.Location = new System.Drawing.Point(58, 115);
            this.valX.Name = "valX";
            this.valX.Size = new System.Drawing.Size(100, 20);
            this.valX.TabIndex = 43;
            // 
            // RectDraw
            // 
            this.RectDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RectDraw.Location = new System.Drawing.Point(135, 203);
            this.RectDraw.Name = "RectDraw";
            this.RectDraw.Size = new System.Drawing.Size(100, 29);
            this.RectDraw.TabIndex = 42;
            this.RectDraw.Text = "Нарисовать";
            this.RectDraw.UseVisualStyleBackColor = true;
            this.RectDraw.Click += new System.EventHandler(this.RectDraw_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(104, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Изменение параметров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(27, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(104, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Создание прямоугольника";
            // 
            // valH
            // 
            this.valH.Location = new System.Drawing.Point(241, 154);
            this.valH.Name = "valH";
            this.valH.Size = new System.Drawing.Size(100, 20);
            this.valH.TabIndex = 56;
            // 
            // newH
            // 
            this.newH.Location = new System.Drawing.Point(241, 324);
            this.newH.Name = "newH";
            this.newH.Size = new System.Drawing.Size(100, 20);
            this.newH.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(176, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Высота";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(176, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Высота";
            // 
            // Form_Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newH);
            this.Controls.Add(this.valH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNewSize);
            this.Controls.Add(this.BNewCord);
            this.Controls.Add(this.newW);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newY);
            this.Controls.Add(this.newX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valW);
            this.Controls.Add(this.valY);
            this.Controls.Add(this.valX);
            this.Controls.Add(this.RectDraw);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "Form_Rectangle";
            this.Text = "Form_Rectangle";
            this.Load += new System.EventHandler(this.Form_Rectangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BNewSize;
        private System.Windows.Forms.Button BNewCord;
        private System.Windows.Forms.TextBox newW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newY;
        private System.Windows.Forms.TextBox newX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valW;
        private System.Windows.Forms.TextBox valY;
        private System.Windows.Forms.TextBox valX;
        private System.Windows.Forms.Button RectDraw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox valH;
        private System.Windows.Forms.TextBox newH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}
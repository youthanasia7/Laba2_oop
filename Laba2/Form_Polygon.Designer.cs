namespace Laba2
{
    partial class Form_Polygon
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
            this.dots_count = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.setY = new System.Windows.Forms.TextBox();
            this.BsetDots = new System.Windows.Forms.Button();
            this.BAddDots = new System.Windows.Forms.Button();
            this.BDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dots_count
            // 
            this.dots_count.Location = new System.Drawing.Point(41, 63);
            this.dots_count.Name = "dots_count";
            this.dots_count.Size = new System.Drawing.Size(100, 20);
            this.dots_count.TabIndex = 0;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(41, 127);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(100, 20);
            this.setX.TabIndex = 1;
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(41, 174);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(100, 20);
            this.setY.TabIndex = 2;
            // 
            // BsetDots
            // 
            this.BsetDots.Location = new System.Drawing.Point(180, 63);
            this.BsetDots.Name = "BsetDots";
            this.BsetDots.Size = new System.Drawing.Size(75, 23);
            this.BsetDots.TabIndex = 3;
            this.BsetDots.Text = "button1";
            this.BsetDots.UseVisualStyleBackColor = true;
            this.BsetDots.Click += new System.EventHandler(this.BsetDots_Click);
            // 
            // BAddDots
            // 
            this.BAddDots.Location = new System.Drawing.Point(41, 200);
            this.BAddDots.Name = "BAddDots";
            this.BAddDots.Size = new System.Drawing.Size(75, 23);
            this.BAddDots.TabIndex = 4;
            this.BAddDots.Text = "button2";
            this.BAddDots.UseVisualStyleBackColor = true;
            this.BAddDots.Click += new System.EventHandler(this.BAddDots_Click);
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(180, 200);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(75, 23);
            this.BDraw.TabIndex = 5;
            this.BDraw.Text = "button3";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // Form_Polygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 439);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.BAddDots);
            this.Controls.Add(this.BsetDots);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.dots_count);
            this.Name = "Form_Polygon";
            this.Text = "Form_Polygon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dots_count;
        private System.Windows.Forms.TextBox setX;
        private System.Windows.Forms.TextBox setY;
        private System.Windows.Forms.Button BsetDots;
        private System.Windows.Forms.Button BAddDots;
        private System.Windows.Forms.Button BDraw;
    }
}
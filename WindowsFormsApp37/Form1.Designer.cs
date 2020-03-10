namespace WindowsFormsApp37
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Disc = new System.Windows.Forms.Label();
            this.xx1 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(233, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(364, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "c = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(136, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Калькулятор квадратных уравнений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(207, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ax+bx+c=0";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(124, 103);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(24, 20);
            this.A.TabIndex = 5;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(257, 103);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(24, 20);
            this.B.TabIndex = 6;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(391, 103);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(31, 20);
            this.C.TabIndex = 7;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(217, 175);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Расчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.calculate_click);
            // 
            // Disc
            // 
            this.Disc.AutoSize = true;
            this.Disc.Location = new System.Drawing.Point(140, 241);
            this.Disc.Name = "Disc";
            this.Disc.Size = new System.Drawing.Size(24, 13);
            this.Disc.TabIndex = 10;
            this.Disc.Text = "D =";
            // 
            // xx1
            // 
            this.xx1.AutoSize = true;
            this.xx1.Location = new System.Drawing.Point(140, 333);
            this.xx1.Name = "xx1";
            this.xx1.Size = new System.Drawing.Size(27, 13);
            this.xx1.TabIndex = 11;
            this.xx1.Text = "x1 =";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(296, 333);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(27, 13);
            this.lab.TabIndex = 12;
            this.lab.Text = "x2 =";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(143, 359);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 20);
            this.X1.TabIndex = 13;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(299, 359);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 20);
            this.X2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.xx1);
            this.Controls.Add(this.Disc);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Disc;
        private System.Windows.Forms.Label xx1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox X2;
    }
}


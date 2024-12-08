namespace prim12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b00 = new Button();
            b10 = new Button();
            b20 = new Button();
            b21 = new Button();
            b11 = new Button();
            b01 = new Button();
            b22 = new Button();
            b12 = new Button();
            b02 = new Button();
            c0 = new Button();
            c1 = new Button();
            label1 = new Label();
            restart = new Button();
            SuspendLayout();
            // 
            // b00
            // 
            b00.Location = new Point(0, 0);
            b00.Name = "b00";
            b00.Size = new Size(200, 200);
            b00.TabIndex = 0;
            b00.Text = "button1";
            b00.UseVisualStyleBackColor = true;
            b00.Click += game;
            // 
            // b10
            // 
            b10.Location = new Point(0, 197);
            b10.Name = "b10";
            b10.Size = new Size(200, 200);
            b10.TabIndex = 1;
            b10.Text = "button2";
            b10.UseVisualStyleBackColor = true;
            b10.Click += game;
            // 
            // b20
            // 
            b20.Location = new Point(0, 392);
            b20.Name = "b20";
            b20.Size = new Size(200, 200);
            b20.TabIndex = 2;
            b20.Text = "button3";
            b20.UseVisualStyleBackColor = true;
            b20.Click += game;
            // 
            // b21
            // 
            b21.Location = new Point(195, 392);
            b21.Name = "b21";
            b21.Size = new Size(200, 200);
            b21.TabIndex = 5;
            b21.Text = "button4";
            b21.UseVisualStyleBackColor = true;
            b21.Click += game;
            // 
            // b11
            // 
            b11.Location = new Point(195, 197);
            b11.Name = "b11";
            b11.Size = new Size(200, 200);
            b11.TabIndex = 4;
            b11.Text = "button5";
            b11.UseVisualStyleBackColor = true;
            b11.Click += game;
            // 
            // b01
            // 
            b01.Location = new Point(195, 0);
            b01.Name = "b01";
            b01.Size = new Size(200, 200);
            b01.TabIndex = 3;
            b01.Text = "button6";
            b01.UseVisualStyleBackColor = true;
            b01.Click += game;
            // 
            // b22
            // 
            b22.Location = new Point(390, 392);
            b22.Name = "b22";
            b22.Size = new Size(200, 200);
            b22.TabIndex = 8;
            b22.Text = "button7";
            b22.UseVisualStyleBackColor = true;
            b22.Click += game;
            // 
            // b12
            // 
            b12.Location = new Point(390, 197);
            b12.Name = "b12";
            b12.Size = new Size(200, 200);
            b12.TabIndex = 7;
            b12.Text = "button8";
            b12.UseVisualStyleBackColor = true;
            b12.Click += game;
            // 
            // b02
            // 
            b02.Location = new Point(390, 0);
            b02.Name = "b02";
            b02.Size = new Size(200, 200);
            b02.TabIndex = 6;
            b02.Text = "button9";
            b02.UseVisualStyleBackColor = true;
            b02.Click += game;
            // 
            // c0
            // 
            c0.Location = new Point(696, 197);
            c0.Name = "c0";
            c0.Size = new Size(217, 65);
            c0.TabIndex = 9;
            c0.Text = "Начать за Х";
            c0.UseVisualStyleBackColor = true;
            c0.Click += begin;
            // 
            // c1
            // 
            c1.Location = new Point(696, 289);
            c1.Name = "c1";
            c1.Size = new Size(217, 65);
            c1.TabIndex = 10;
            c1.Text = "Начать за О";
            c1.UseVisualStyleBackColor = true;
            c1.Click += begin;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 60);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 11;
            label1.Text = "0";
            label1.Visible = false;
            // 
            // restart
            // 
            restart.Location = new Point(696, 225);
            restart.Name = "restart";
            restart.Size = new Size(217, 103);
            restart.TabIndex = 12;
            restart.Text = "Restart Game";
            restart.UseVisualStyleBackColor = true;
            restart.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 591);
            Controls.Add(restart);
            Controls.Add(label1);
            Controls.Add(c1);
            Controls.Add(c0);
            Controls.Add(b22);
            Controls.Add(b12);
            Controls.Add(b02);
            Controls.Add(b21);
            Controls.Add(b11);
            Controls.Add(b01);
            Controls.Add(b20);
            Controls.Add(b10);
            Controls.Add(b00);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 647);
            MinimizeBox = false;
            MinimumSize = new Size(1000, 647);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b00;
        private Button b10;
        private Button b20;
        private Button b21;
        private Button b11;
        private Button b01;
        private Button b22;
        private Button b12;
        private Button b02;
        private Button c0;
        private Button c1;
        private Label label1;
        private Button restart;
    }
}

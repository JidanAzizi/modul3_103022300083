﻿namespace modul3_103022300083
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnResult = new Button();
            label1 = new Label();
            btn0 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(123, 170);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 51);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(229, 170);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 51);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(335, 170);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 51);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(123, 227);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 51);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(229, 227);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 51);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(335, 227);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 51);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(123, 284);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 51);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(229, 284);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 51);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(335, 284);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 51);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(516, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 51);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(516, 227);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(100, 51);
            btnResult.TabIndex = 10;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 101);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            label1.Click += label1_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(229, 341);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 51);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button12_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btn0);
            Controls.Add(label1);
            Controls.Add(btnResult);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnResult;
        private Label label1;
        private Button btn0;
        private TextBox textBox1;
    }
}

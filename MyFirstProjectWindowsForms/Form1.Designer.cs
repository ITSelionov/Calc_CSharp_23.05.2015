using System.Drawing;
using System.Windows.Forms;

namespace Calc_CSharp
{
    partial class Form1
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.Standart = new System.Windows.Forms.RadioButton();
            this.Engineer = new System.Windows.Forms.RadioButton();
            this.Sqr = new System.Windows.Forms.Button();
            this.PI = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 36);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ReadOnly = true;
            this.InputBox.Size = new System.Drawing.Size(138, 25);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(13, 170);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(30, 30);
            this.One.TabIndex = 1;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(47, 170);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(30, 30);
            this.Two.TabIndex = 2;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(84, 170);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(30, 30);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 134);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(30, 30);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(47, 134);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(30, 30);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(84, 134);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(30, 30);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(13, 98);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(30, 30);
            this.Seven.TabIndex = 7;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(47, 98);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(30, 30);
            this.Eight.TabIndex = 8;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(83, 98);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(30, 30);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Devide
            // 
            this.Devide.Location = new System.Drawing.Point(119, 98);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(30, 30);
            this.Devide.TabIndex = 10;
            this.Devide.Text = "/";
            this.Devide.UseVisualStyleBackColor = true;
            this.Devide.Click += new System.EventHandler(this.Devide_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(119, 134);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(30, 30);
            this.Multiply.TabIndex = 11;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(120, 170);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(30, 30);
            this.Minus.TabIndex = 12;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(121, 206);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(30, 30);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Clear
            // 
            this.Clear.ForeColor = System.Drawing.Color.Red;
            this.Clear.Location = new System.Drawing.Point(13, 206);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(30, 30);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(47, 206);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(30, 30);
            this.Zero.TabIndex = 15;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(83, 206);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(30, 30);
            this.PlusMinus.TabIndex = 16;
            this.PlusMinus.Text = "±";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.PlusMinus_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(13, 242);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(138, 30);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(13, 67);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(138, 25);
            this.ResultBox.TabIndex = 18;
            // 
            // Standart
            // 
            this.Standart.AutoSize = true;
            this.Standart.Location = new System.Drawing.Point(13, 12);
            this.Standart.Name = "Standart";
            this.Standart.Size = new System.Drawing.Size(65, 17);
            this.Standart.TabIndex = 19;
            this.Standart.TabStop = true;
            this.Standart.Text = "Standart";
            this.Standart.UseVisualStyleBackColor = true;
            this.Standart.CheckedChanged += new System.EventHandler(this.Standart_CheckedChanged);
            // 
            // Engineer
            // 
            this.Engineer.AutoSize = true;
            this.Engineer.Location = new System.Drawing.Point(84, 12);
            this.Engineer.Name = "Engineer";
            this.Engineer.Size = new System.Drawing.Size(67, 17);
            this.Engineer.TabIndex = 20;
            this.Engineer.TabStop = true;
            this.Engineer.Text = "Engineer";
            this.Engineer.UseVisualStyleBackColor = true;
            this.Engineer.CheckedChanged += new System.EventHandler(this.Engineer_CheckedChanged);
            // 
            // Sqr
            // 
            this.Sqr.Location = new System.Drawing.Point(180, 98);
            this.Sqr.Name = "Sqr";
            this.Sqr.Size = new System.Drawing.Size(37, 30);
            this.Sqr.TabIndex = 21;
            this.Sqr.Text = "sqr";
            this.Sqr.UseVisualStyleBackColor = true;
            // 
            // PI
            // 
            this.PI.Location = new System.Drawing.Point(180, 134);
            this.PI.Name = "PI";
            this.PI.Size = new System.Drawing.Size(37, 30);
            this.PI.TabIndex = 22;
            this.PI.Text = "PI";
            this.PI.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(180, 206);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(37, 30);
            this.Log.TabIndex = 23;
            this.Log.Text = "log";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(180, 170);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(37, 30);
            this.Point.TabIndex = 24;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 279);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.PI);
            this.Controls.Add(this.Sqr);
            this.Controls.Add(this.Engineer);
            this.Controls.Add(this.Standart);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button Equal;
        private TextBox ResultBox;
        private RadioButton Standart;
        private RadioButton Engineer;
        private Button Sqr;
        private Button PI;
        private Button Log;
        private Button Point;
    }
}


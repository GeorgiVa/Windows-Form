﻿namespace Timer
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.label1 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.button4 = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.radioButton3 = new System.Windows.Forms.RadioButton();
         this.radioButton4 = new System.Windows.Forms.RadioButton();
         this.radioButton5 = new System.Windows.Forms.RadioButton();
         this.radioButton6 = new System.Windows.Forms.RadioButton();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.timer2 = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label1.Location = new System.Drawing.Point(95, 18);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(43, 46);
         this.label1.TabIndex = 0;
         this.label1.Text = "0";
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Lime;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Location = new System.Drawing.Point(13, 101);
         this.button1.Margin = new System.Windows.Forms.Padding(4);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(90, 30);
         this.button1.TabIndex = 1;
         this.button1.Text = "Start";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.Lime;
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button2.Location = new System.Drawing.Point(116, 101);
         this.button2.Margin = new System.Windows.Forms.Padding(4);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(90, 30);
         this.button2.TabIndex = 1;
         this.button2.Text = "Stop";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.GreenYellow;
         this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button3.Location = new System.Drawing.Point(214, 101);
         this.button3.Margin = new System.Windows.Forms.Padding(4);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(90, 30);
         this.button3.TabIndex = 0;
         this.button3.Text = "Reset";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // timer1
         // 
         this.timer1.Interval = 1;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // button4
         // 
         this.button4.BackColor = System.Drawing.Color.GreenYellow;
         this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button4.Location = new System.Drawing.Point(13, 139);
         this.button4.Margin = new System.Windows.Forms.Padding(4);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(291, 30);
         this.button4.TabIndex = 2;
         this.button4.Text = "Close";
         this.button4.UseVisualStyleBackColor = false;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.Location = new System.Drawing.Point(176, 19);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(43, 46);
         this.label2.TabIndex = 3;
         this.label2.Text = "0";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(265, 30);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(29, 31);
         this.label3.TabIndex = 4;
         this.label3.Text = "0";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.Location = new System.Drawing.Point(149, 19);
         this.label4.Margin = new System.Windows.Forms.Padding(0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(31, 46);
         this.label4.TabIndex = 5;
         this.label4.Text = ":";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label5.Location = new System.Drawing.Point(231, 19);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(31, 46);
         this.label5.TabIndex = 5;
         this.label5.Text = ".";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label6.Location = new System.Drawing.Point(107, 65);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(16, 13);
         this.label6.TabIndex = 6;
         this.label6.Text = "m";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label7.Location = new System.Drawing.Point(190, 65);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(13, 13);
         this.label7.TabIndex = 7;
         this.label7.Text = "s";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label8.Location = new System.Drawing.Point(268, 65);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(22, 13);
         this.label8.TabIndex = 8;
         this.label8.Text = "ms";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label9.Location = new System.Drawing.Point(12, 19);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(43, 46);
         this.label9.TabIndex = 9;
         this.label9.Text = "0";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label10.Location = new System.Drawing.Point(28, 65);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(14, 13);
         this.label10.TabIndex = 6;
         this.label10.Text = "h";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label11.Location = new System.Drawing.Point(61, 19);
         this.label11.Margin = new System.Windows.Forms.Padding(0);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(31, 46);
         this.label11.TabIndex = 5;
         this.label11.Text = ":";
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Location = new System.Drawing.Point(322, 12);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(55, 21);
         this.radioButton1.TabIndex = 10;
         this.radioButton1.Text = "Red";
         this.radioButton1.UseVisualStyleBackColor = true;
         this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Location = new System.Drawing.Point(322, 66);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(72, 21);
         this.radioButton2.TabIndex = 12;
         this.radioButton2.Text = "Yellow";
         this.radioButton2.UseVisualStyleBackColor = true;
         this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
         // 
         // radioButton3
         // 
         this.radioButton3.AutoSize = true;
         this.radioButton3.Location = new System.Drawing.Point(322, 40);
         this.radioButton3.Name = "radioButton3";
         this.radioButton3.Size = new System.Drawing.Size(71, 21);
         this.radioButton3.TabIndex = 13;
         this.radioButton3.Text = "Green";
         this.radioButton3.UseVisualStyleBackColor = true;
         this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
         // 
         // radioButton4
         // 
         this.radioButton4.AutoSize = true;
         this.radioButton4.Location = new System.Drawing.Point(322, 94);
         this.radioButton4.Name = "radioButton4";
         this.radioButton4.Size = new System.Drawing.Size(67, 21);
         this.radioButton4.TabIndex = 14;
         this.radioButton4.Text = "White";
         this.radioButton4.UseVisualStyleBackColor = true;
         this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
         // 
         // radioButton5
         // 
         this.radioButton5.AutoSize = true;
         this.radioButton5.Location = new System.Drawing.Point(322, 122);
         this.radioButton5.Name = "radioButton5";
         this.radioButton5.Size = new System.Drawing.Size(88, 21);
         this.radioButton5.TabIndex = 15;
         this.radioButton5.Text = "Magenta";
         this.radioButton5.UseVisualStyleBackColor = true;
         this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
         // 
         // radioButton6
         // 
         this.radioButton6.AutoSize = true;
         this.radioButton6.Location = new System.Drawing.Point(322, 150);
         this.radioButton6.Name = "radioButton6";
         this.radioButton6.Size = new System.Drawing.Size(62, 21);
         this.radioButton6.TabIndex = 16;
         this.radioButton6.TabStop = true;
         this.radioButton6.Text = "Cyan";
         this.radioButton6.UseVisualStyleBackColor = true;
         this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
         // 
         // textBox1
         // 
         this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.textBox1.Location = new System.Drawing.Point(69, 178);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.textBox1.Size = new System.Drawing.Size(45, 22);
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "min";
         this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
         // 
         // textBox2
         // 
         this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.textBox2.Location = new System.Drawing.Point(13, 178);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(45, 22);
         this.textBox2.TabIndex = 1;
         this.textBox2.Text = "hours";
         this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
         // 
         // timer2
         // 
         this.timer2.Interval = 1;
         this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.ClientSize = new System.Drawing.Size(415, 207);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.radioButton6);
         this.Controls.Add(this.radioButton5);
         this.Controls.Add(this.radioButton4);
         this.Controls.Add(this.radioButton3);
         this.Controls.Add(this.radioButton2);
         this.Controls.Add(this.radioButton1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Form1";
         this.Text = "Chronometer";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.RadioButton radioButton1;
      private System.Windows.Forms.RadioButton radioButton2;
      private System.Windows.Forms.RadioButton radioButton3;
      private System.Windows.Forms.RadioButton radioButton4;
      private System.Windows.Forms.RadioButton radioButton5;
      private System.Windows.Forms.RadioButton radioButton6;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Timer timer2;
   }
}


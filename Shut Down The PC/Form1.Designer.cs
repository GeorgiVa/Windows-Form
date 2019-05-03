namespace Shut_Down_PC
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
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.colorDialog1 = new System.Windows.Forms.ColorDialog();
         this.label5 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.Goldenrod;
         this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.button1.FlatAppearance.BorderSize = 2;
         this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.GreenYellow;
         this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Location = new System.Drawing.Point(150, 22);
         this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(99, 27);
         this.button1.TabIndex = 0;
         this.button1.Text = "Start";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         this.textBox1.BackColor = System.Drawing.Color.Thistle;
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox1.Font = new System.Drawing.Font("Arial", 14F);
         this.textBox1.Location = new System.Drawing.Point(32, 22);
         this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(89, 27);
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "min";
         this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(63, 75);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(20, 16);
         this.label1.TabIndex = 2;
         this.label1.Text = "...";
         // 
         // button2
         // 
         this.button2.BackColor = System.Drawing.Color.Goldenrod;
         this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.button2.FlatAppearance.BorderSize = 2;
         this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.GreenYellow;
         this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
         this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button2.Location = new System.Drawing.Point(150, 69);
         this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(99, 27);
         this.button2.TabIndex = 3;
         this.button2.Text = "Abort";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // timer1
         // 
         this.timer1.Interval = 1000;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Plum;
         this.label2.Font = new System.Drawing.Font("Arial", 8F);
         this.label2.Location = new System.Drawing.Point(10, 107);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(166, 14);
         this.label2.TabIndex = 4;
         this.label2.Text = "Press \'Abort\' to stop the process";
         this.label2.Visible = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.label3.Location = new System.Drawing.Point(35, 75);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(28, 15);
         this.label3.TabIndex = 2;
         this.label3.Text = "sec";
         this.label3.Visible = false;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Plum;
         this.label4.Font = new System.Drawing.Font("Arial", 8F);
         this.label4.Location = new System.Drawing.Point(10, 122);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(130, 14);
         this.label4.TabIndex = 4;
         this.label4.Text = "Double click \'Abort\' to Exit";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.Plum;
         this.label5.Font = new System.Drawing.Font("Arial", 6F);
         this.label5.Location = new System.Drawing.Point(247, 130);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(24, 10);
         this.label5.TabIndex = 4;
         this.label5.Text = "Color";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.label5.DoubleClick += new System.EventHandler(this.label5_DoubleClick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Plum;
         this.ClientSize = new System.Drawing.Size(274, 143);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.MaximizeBox = false;
         this.MinimumSize = new System.Drawing.Size(280, 160);
         this.Name = "Form1";
         this.Opacity = 0.9D;
         this.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.Text = "Shut Down";
         this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ColorDialog colorDialog1;
      private System.Windows.Forms.Label label5;
   }
}


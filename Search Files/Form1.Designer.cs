namespace SearchFiles
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.button2 = new System.Windows.Forms.Button();
         this.richTextBox2 = new System.Windows.Forms.RichTextBox();
         this.button3 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.SuspendLayout();
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
         this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline);
         this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
         this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
         this.dateTimePicker1.Location = new System.Drawing.Point(390, 52);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(172, 24);
         this.dateTimePicker1.TabIndex = 13;
         // 
         // textBox2
         // 
         this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox2.BackColor = System.Drawing.SystemColors.Info;
         this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.textBox2.Location = new System.Drawing.Point(151, 52);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(223, 23);
         this.textBox2.TabIndex = 17;
         this.textBox2.Text = "Търсене на файл:";
         this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
         // 
         // button2
         // 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
         this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
         this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.button2.Location = new System.Drawing.Point(482, 532);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(100, 30);
         this.button2.TabIndex = 14;
         this.button2.Text = "Clear Text";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button3_Click);
         // 
         // richTextBox2
         // 
         this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox2.BackColor = System.Drawing.Color.Beige;
         this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.richTextBox2.Location = new System.Drawing.Point(25, 118);
         this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
         this.richTextBox2.Name = "richTextBox2";
         this.richTextBox2.Size = new System.Drawing.Size(557, 444);
         this.richTextBox2.TabIndex = 15;
         this.richTextBox2.Text = "";
         this.richTextBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox2_MouseClick);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
         this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.button3.ForeColor = System.Drawing.Color.Black;
         this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.button3.Location = new System.Drawing.Point(12, 52);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(122, 34);
         this.button3.TabIndex = 10;
         this.button3.Text = "Files";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button2_Click);
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.BackColor = System.Drawing.SystemColors.Info;
         this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
         this.textBox1.Location = new System.Drawing.Point(151, 12);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(411, 23);
         this.textBox1.TabIndex = 12;
         this.textBox1.Text = "Директория C, D или E";
         this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
         this.button1.FlatAppearance.BorderSize = 15;
         this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.button1.ForeColor = System.Drawing.Color.Black;
         this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.button1.Location = new System.Drawing.Point(12, 12);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(122, 34);
         this.button1.TabIndex = 11;
         this.button1.Text = "Directories";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // richTextBox1
         // 
         this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.richTextBox1.Location = new System.Drawing.Point(12, 105);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(584, 472);
         this.richTextBox1.TabIndex = 16;
         this.richTextBox1.Text = "";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(609, 589);
         this.Controls.Add(this.dateTimePicker1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.richTextBox2);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.richTextBox1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DateTimePicker dateTimePicker1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.RichTextBox richTextBox2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.RichTextBox richTextBox1;
   }
}


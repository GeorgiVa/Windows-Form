namespace _3_Zada4a_WinForm
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.pictureBox1Back = new System.Windows.Forms.PictureBox();
         this.richTextBox2 = new System.Windows.Forms.RichTextBox();
         this.pictureBox2Redo = new System.Windows.Forms.PictureBox();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.pictureBox1Search = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Back)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Redo)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Search)).BeginInit();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
         this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
         this.textBox1.Location = new System.Drawing.Point(84, 12);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(322, 25);
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "Компютър";
         this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
         this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
         this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
         // 
         // richTextBox1
         // 
         this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox1.BackColor = System.Drawing.Color.FloralWhite;
         this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.richTextBox1.EnableAutoDragDrop = true;
         this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.richTextBox1.Location = new System.Drawing.Point(0, 60);
         this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.richTextBox1.Size = new System.Drawing.Size(642, 476);
         this.richTextBox1.TabIndex = 2;
         this.richTextBox1.Text = "";
         this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
         this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
         this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseMove);
         // 
         // pictureBox1Back
         // 
         this.pictureBox1Back.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Back.Image")));
         this.pictureBox1Back.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1Back.Name = "pictureBox1Back";
         this.pictureBox1Back.Size = new System.Drawing.Size(30, 25);
         this.pictureBox1Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1Back.TabIndex = 3;
         this.pictureBox1Back.TabStop = false;
         this.pictureBox1Back.Click += new System.EventHandler(this.pictureBox1_ClickBack);
         // 
         // richTextBox2
         // 
         this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.richTextBox2.Location = new System.Drawing.Point(0, 536);
         this.richTextBox2.Margin = new System.Windows.Forms.Padding(0);
         this.richTextBox2.Name = "richTextBox2";
         this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
         this.richTextBox2.Size = new System.Drawing.Size(642, 112);
         this.richTextBox2.TabIndex = 4;
         this.richTextBox2.Text = "Info";
         // 
         // pictureBox2Redo
         // 
         this.pictureBox2Redo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2Redo.Image")));
         this.pictureBox2Redo.Location = new System.Drawing.Point(48, 12);
         this.pictureBox2Redo.Name = "pictureBox2Redo";
         this.pictureBox2Redo.Size = new System.Drawing.Size(30, 25);
         this.pictureBox2Redo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox2Redo.TabIndex = 3;
         this.pictureBox2Redo.TabStop = false;
         this.pictureBox2Redo.Click += new System.EventHandler(this.pictureBox2_ClickRedo);
         // 
         // timer1
         // 
         this.timer1.Interval = 125;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // textBox2
         // 
         this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox2.BackColor = System.Drawing.Color.FloralWhite;
         this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(204)));
         this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
         this.textBox2.Location = new System.Drawing.Point(412, 12);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(230, 25);
         this.textBox2.TabIndex = 5;
         this.textBox2.Text = "Search";
         this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
         this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
         this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
         this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
         this.textBox2.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(11, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "MousePosition_Click.Y";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(166, 40);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(103, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "richTextBox1.Height";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(132, 40);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(16, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "...";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(275, 40);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(16, 13);
         this.label4.TabIndex = 6;
         this.label4.Text = "...";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(345, 40);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(103, 13);
         this.label5.TabIndex = 6;
         this.label5.Text = "richTextBox2.Height";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(454, 40);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(16, 13);
         this.label6.TabIndex = 6;
         this.label6.Text = "...";
         // 
         // pictureBox1Search
         // 
         this.pictureBox1Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox1Search.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1Search.ErrorImage")));
         this.pictureBox1Search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Search.Image")));
         this.pictureBox1Search.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1Search.InitialImage")));
         this.pictureBox1Search.Location = new System.Drawing.Point(613, 12);
         this.pictureBox1Search.Name = "pictureBox1Search";
         this.pictureBox1Search.Size = new System.Drawing.Size(29, 25);
         this.pictureBox1Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1Search.TabIndex = 7;
         this.pictureBox1Search.TabStop = false;
         this.pictureBox1Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1Search_MouseClick);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LemonChiffon;
         this.ClientSize = new System.Drawing.Size(642, 646);
         this.Controls.Add(this.pictureBox1Search);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.pictureBox2Redo);
         this.Controls.Add(this.pictureBox1Back);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.richTextBox2);
         this.Controls.Add(this.richTextBox1);
         this.MinimumSize = new System.Drawing.Size(100, 200);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "File Browser";
         this.Resize += new System.EventHandler(this.Form1_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Back)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Redo)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Search)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.PictureBox pictureBox1Back;
      private System.Windows.Forms.RichTextBox richTextBox2;
      private System.Windows.Forms.PictureBox pictureBox2Redo;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.PictureBox pictureBox1Search;
   }
}


namespace WindowsFormsApplication2
{
  partial class SourceCode
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceCode));
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.richTextBox2 = new System.Windows.Forms.RichTextBox();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
         this.button1.FlatAppearance.BorderSize = 15;
         this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
         this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
         resources.ApplyResources(this.button1, "button1");
         this.button1.ForeColor = System.Drawing.Color.Black;
         this.button1.Name = "button1";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         resources.ApplyResources(this.textBox1, "textBox1");
         this.textBox1.BackColor = System.Drawing.SystemColors.Info;
         this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
         this.textBox1.Name = "textBox1";
         this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
         resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
         this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
         this.dateTimePicker1.Name = "dateTimePicker1";
         // 
         // button2
         // 
         resources.ApplyResources(this.button2, "button2");
         this.button2.Name = "button2";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
         this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
         resources.ApplyResources(this.button3, "button3");
         this.button3.ForeColor = System.Drawing.Color.Black;
         this.button3.Name = "button3";
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // richTextBox2
         // 
         resources.ApplyResources(this.richTextBox2, "richTextBox2");
         this.richTextBox2.BackColor = System.Drawing.Color.Beige;
         this.richTextBox2.Name = "richTextBox2";
         this.richTextBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox2_MouseClick);
         // 
         // richTextBox1
         // 
         resources.ApplyResources(this.richTextBox1, "richTextBox1");
         this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.richTextBox1.Name = "richTextBox1";
         // 
         // textBox2
         // 
         resources.ApplyResources(this.textBox2, "textBox2");
         this.textBox2.BackColor = System.Drawing.SystemColors.Info;
         this.textBox2.Name = "textBox2";
         this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
         // 
         // SourceCode
         // 
         this.AcceptButton = this.button1;
         this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.PaleTurquoise;
         this.Controls.Add(this.dateTimePicker1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.richTextBox2);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.richTextBox1);
         this.HelpButton = true;
         this.KeyPreview = true;
         this.Name = "SourceCode";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TextBox textBox2;

  }
}


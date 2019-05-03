using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Dublicat_Finder
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
         //цветовете за изхода
         richTextBox1.BackColor = Color.FromArgb(200, 200, 200);
         if (MessageBox.Show("Изход!", "Dublicate Finder v1.5", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
         {
            for (int i = 0; i < 100; i++) { progressBar1.Value = i; Thread.Sleep(10); }
            //--------------------------------
            if (disposing && (components != null))
            {
               components.Dispose();
            }
            base.Dispose(disposing);
            //----------------------------------
         }
         richTextBox1.BackColor = Color.FromArgb(245, 245, 245);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.button1 = new System.Windows.Forms.Button();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button2 = new System.Windows.Forms.Button();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.button3 = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.calcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openDestinationFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.creatyorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.programToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.progressBar1 = new System.Windows.Forms.ProgressBar();
         this.menuStrip2 = new System.Windows.Forms.MenuStrip();
         this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.menuStrip2.SuspendLayout();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
         this.button1.Location = new System.Drawing.Point(478, 33);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(90, 24);
         this.button1.TabIndex = 0;
         this.button1.Text = "Сканиране";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // richTextBox1
         // 
         this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.richTextBox1.AutoWordSelection = true;
         this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.richTextBox1.Location = new System.Drawing.Point(12, 97);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.Size = new System.Drawing.Size(567, 368);
         this.richTextBox1.TabIndex = 1;
         this.richTextBox1.Text = "";
         this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.textBox1.Location = new System.Drawing.Point(12, 33);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(423, 23);
         this.textBox1.TabIndex = 2;
         this.textBox1.Text = "Път до папка C:\\ D:\\ E:\\ ...";
         // 
         // button2
         // 
         this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button2.ForeColor = System.Drawing.Color.Red;
         this.button2.Location = new System.Drawing.Point(478, 65);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(90, 24);
         this.button2.TabIndex = 5;
         this.button2.Text = "Изтриване";
         this.button2.UseVisualStyleBackColor = false;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // textBox2
         // 
         this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textBox2.CausesValidation = false;
         this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.textBox2.Location = new System.Drawing.Point(12, 65);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(460, 23);
         this.textBox2.TabIndex = 6;
         this.textBox2.Text = "Изтриване  на тип файл (.exe .doc...)  или на всички повтарящи";
         this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
         // 
         // button3
         // 
         this.button3.AllowDrop = true;
         this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
         this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
         this.button3.FlatAppearance.BorderSize = 0;
         this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
         this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
         this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button3.Font = new System.Drawing.Font("Century Schoolbook", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.button3.Location = new System.Drawing.Point(518, 465);
         this.button3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(61, 22);
         this.button3.TabIndex = 7;
         this.button3.Text = "CLEAR";
         this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.button3.UseVisualStyleBackColor = false;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(579, 24);
         this.menuStrip1.TabIndex = 8;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.calcToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
         this.openToolStripMenuItem.Text = "New";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // openToolStripMenuItem1
         // 
         this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
         this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.openToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
         this.openToolStripMenuItem1.Text = "Open";
         this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
         this.saveToolStripMenuItem.Text = "Save";
         // 
         // calcToolStripMenuItem
         // 
         this.calcToolStripMenuItem.Name = "calcToolStripMenuItem";
         this.calcToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
         this.calcToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
         this.calcToolStripMenuItem.Text = "Calc";
         this.calcToolStripMenuItem.Click += new System.EventHandler(this.calcToolStripMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
         // 
         // quitToolStripMenuItem
         // 
         this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
         this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
         this.quitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
         this.quitToolStripMenuItem.Text = "Quit!";
         this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
         // 
         // viewToolStripMenuItem
         // 
         this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDestinationFolderToolStripMenuItem});
         this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
         this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.viewToolStripMenuItem.Text = "View";
         // 
         // openDestinationFolderToolStripMenuItem
         // 
         this.openDestinationFolderToolStripMenuItem.Name = "openDestinationFolderToolStripMenuItem";
         this.openDestinationFolderToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
         this.openDestinationFolderToolStripMenuItem.Text = "Open destination file or directory";
         this.openDestinationFolderToolStripMenuItem.Click += new System.EventHandler(this.openDestinationFolderToolStripMenuItem_Click);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatyorToolStripMenuItem});
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.aboutToolStripMenuItem.Text = "Help";
         // 
         // creatyorToolStripMenuItem
         // 
         this.creatyorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatorToolStripMenuItem,
            this.programToolStripMenuItem1});
         this.creatyorToolStripMenuItem.Name = "creatyorToolStripMenuItem";
         this.creatyorToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.creatyorToolStripMenuItem.Text = "About";
         // 
         // creatorToolStripMenuItem
         // 
         this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
         this.creatorToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
         this.creatorToolStripMenuItem.Text = "Creator";
         this.creatorToolStripMenuItem.Click += new System.EventHandler(this.creatorToolStripMenuItem_Click_1);
         // 
         // programToolStripMenuItem1
         // 
         this.programToolStripMenuItem1.Name = "programToolStripMenuItem1";
         this.programToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
         this.programToolStripMenuItem1.Text = "Program";
         this.programToolStripMenuItem1.Click += new System.EventHandler(this.programToolStripMenuItem1_Click);
         // 
         // progressBar1
         // 
         this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.progressBar1.Location = new System.Drawing.Point(0, 471);
         this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
         this.progressBar1.Name = "progressBar1";
         this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.progressBar1.Size = new System.Drawing.Size(518, 16);
         this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
         this.progressBar1.TabIndex = 1;
         // 
         // menuStrip2
         // 
         this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
         this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem2});
         this.menuStrip2.Location = new System.Drawing.Point(346, 33);
         this.menuStrip2.Name = "menuStrip2";
         this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
         this.menuStrip2.Size = new System.Drawing.Size(126, 24);
         this.menuStrip2.TabIndex = 9;
         this.menuStrip2.Text = "menuStrip2";
         // 
         // openToolStripMenuItem2
         // 
         this.openToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
         this.openToolStripMenuItem2.Size = new System.Drawing.Size(32, 24);
         this.openToolStripMenuItem2.Text = "...";
         this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ButtonFace;
         this.ClientSize = new System.Drawing.Size(579, 486);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.menuStrip2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.progressBar1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.richTextBox1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.Text = "Премахване на еднакви файлове";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.menuStrip2.ResumeLayout(false);
         this.menuStrip2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem creatyorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem calcToolStripMenuItem;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.MenuStrip menuStrip2;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
      private ToolStripMenuItem viewToolStripMenuItem;
      private ToolStripMenuItem openDestinationFolderToolStripMenuItem;
   }
}


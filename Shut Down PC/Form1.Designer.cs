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
         this.btnShutdown = new System.Windows.Forms.Button();
         this.textMinLeft = new System.Windows.Forms.TextBox();
         this.labelSec = new System.Windows.Forms.Label();
         this.btnAbort = new System.Windows.Forms.Button();
         this.timerShutdown = new System.Windows.Forms.Timer(this.components);
         this.labelAbortInfo = new System.Windows.Forms.Label();
         this.labelSecText = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.labelColor = new System.Windows.Forms.Label();
         this.btnSleep = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnShutdown
         // 
         this.btnShutdown.BackColor = System.Drawing.Color.Goldenrod;
         this.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.btnShutdown.FlatAppearance.BorderSize = 2;
         this.btnShutdown.FlatAppearance.CheckedBackColor = System.Drawing.Color.GreenYellow;
         this.btnShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
         this.btnShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
         this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnShutdown.Location = new System.Drawing.Point(150, 12);
         this.btnShutdown.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.btnShutdown.Name = "btnShutdown";
         this.btnShutdown.Size = new System.Drawing.Size(99, 29);
         this.btnShutdown.TabIndex = 0;
         this.btnShutdown.Text = "Shutdown";
         this.btnShutdown.UseVisualStyleBackColor = false;
         this.btnShutdown.Click += new System.EventHandler(this.shutdown_Click);
         // 
         // textMinLeft
         // 
         this.textMinLeft.BackColor = System.Drawing.Color.Thistle;
         this.textMinLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.textMinLeft.Font = new System.Drawing.Font("Arial", 14F);
         this.textMinLeft.Location = new System.Drawing.Point(32, 12);
         this.textMinLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.textMinLeft.Multiline = true;
         this.textMinLeft.Name = "textMinLeft";
         this.textMinLeft.Size = new System.Drawing.Size(89, 27);
         this.textMinLeft.TabIndex = 1;
         this.textMinLeft.Text = "min";
         this.textMinLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.textMinLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxMin_MouseClick);
         this.textMinLeft.Leave += new System.EventHandler(this.textMinLeft_Leave);
         // 
         // labelSec
         // 
         this.labelSec.AutoSize = true;
         this.labelSec.Location = new System.Drawing.Point(63, 75);
         this.labelSec.Name = "labelSec";
         this.labelSec.Size = new System.Drawing.Size(21, 19);
         this.labelSec.TabIndex = 2;
         this.labelSec.Text = "...";
         // 
         // btnAbort
         // 
         this.btnAbort.BackColor = System.Drawing.Color.Goldenrod;
         this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnAbort.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.btnAbort.FlatAppearance.BorderSize = 2;
         this.btnAbort.FlatAppearance.CheckedBackColor = System.Drawing.Color.GreenYellow;
         this.btnAbort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
         this.btnAbort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
         this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnAbort.Location = new System.Drawing.Point(150, 80);
         this.btnAbort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.btnAbort.Name = "btnAbort";
         this.btnAbort.Size = new System.Drawing.Size(99, 29);
         this.btnAbort.TabIndex = 3;
         this.btnAbort.Text = "Abort";
         this.btnAbort.UseVisualStyleBackColor = false;
         this.btnAbort.Click += new System.EventHandler(this.shutdownAbort_Click);
         // 
         // timerShutdown
         // 
         this.timerShutdown.Interval = 1000;
         this.timerShutdown.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // labelAbortInfo
         // 
         this.labelAbortInfo.AutoSize = true;
         this.labelAbortInfo.BackColor = System.Drawing.Color.Plum;
         this.labelAbortInfo.Font = new System.Drawing.Font("Arial", 8F);
         this.labelAbortInfo.Location = new System.Drawing.Point(9, 113);
         this.labelAbortInfo.Name = "labelAbortInfo";
         this.labelAbortInfo.Size = new System.Drawing.Size(197, 16);
         this.labelAbortInfo.TabIndex = 4;
         this.labelAbortInfo.Text = "Press \'Abort\' to stop the process";
         this.labelAbortInfo.Visible = false;
         // 
         // labelSecText
         // 
         this.labelSecText.AutoSize = true;
         this.labelSecText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
         this.labelSecText.Location = new System.Drawing.Point(35, 75);
         this.labelSecText.Name = "labelSecText";
         this.labelSecText.Size = new System.Drawing.Size(33, 18);
         this.labelSecText.TabIndex = 2;
         this.labelSecText.Text = "sec";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Plum;
         this.label4.Font = new System.Drawing.Font("Arial", 8F);
         this.label4.Location = new System.Drawing.Point(9, 130);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(160, 16);
         this.label4.TabIndex = 4;
         this.label4.Text = "Double click \'Abort\' to Exit";
         // 
         // labelColor
         // 
         this.labelColor.AutoSize = true;
         this.labelColor.BackColor = System.Drawing.Color.Plum;
         this.labelColor.Font = new System.Drawing.Font("Arial", 6F);
         this.labelColor.Location = new System.Drawing.Point(247, 133);
         this.labelColor.Margin = new System.Windows.Forms.Padding(0);
         this.labelColor.Name = "labelColor";
         this.labelColor.Size = new System.Drawing.Size(32, 13);
         this.labelColor.TabIndex = 4;
         this.labelColor.Text = "Color";
         this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.labelColor.DoubleClick += new System.EventHandler(this.labelColor_DoubleClick);
         // 
         // btnSleep
         // 
         this.btnSleep.BackColor = System.Drawing.Color.Goldenrod;
         this.btnSleep.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
         this.btnSleep.FlatAppearance.BorderSize = 2;
         this.btnSleep.FlatAppearance.CheckedBackColor = System.Drawing.Color.GreenYellow;
         this.btnSleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
         this.btnSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
         this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnSleep.Location = new System.Drawing.Point(150, 46);
         this.btnSleep.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
         this.btnSleep.Name = "btnSleep";
         this.btnSleep.Size = new System.Drawing.Size(99, 29);
         this.btnSleep.TabIndex = 5;
         this.btnSleep.Text = "Sleep";
         this.btnSleep.UseVisualStyleBackColor = false;
         this.btnSleep.Click += new System.EventHandler(this.sleep_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Plum;
         this.CancelButton = this.btnAbort;
         this.ClientSize = new System.Drawing.Size(282, 151);
         this.Controls.Add(this.btnSleep);
         this.Controls.Add(this.labelColor);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.labelAbortInfo);
         this.Controls.Add(this.btnAbort);
         this.Controls.Add(this.labelSecText);
         this.Controls.Add(this.labelSec);
         this.Controls.Add(this.textMinLeft);
         this.Controls.Add(this.btnShutdown);
         this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

      private System.Windows.Forms.Button btnShutdown;
      private System.Windows.Forms.TextBox textMinLeft;
      private System.Windows.Forms.Label labelSec;
      private System.Windows.Forms.Button btnAbort;
      private System.Windows.Forms.Timer timerShutdown;
      private System.Windows.Forms.Label labelAbortInfo;
      private System.Windows.Forms.Label labelSecText;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ColorDialog colorDialog;
      private System.Windows.Forms.Label labelColor;
      private System.Windows.Forms.Button btnSleep;
   }
}


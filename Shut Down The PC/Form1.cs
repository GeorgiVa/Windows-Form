using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shut_Down_PC
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      int abort = 0;
      int minLeft = 0;
      private void button1_Click(object sender, EventArgs e)
      {
         if (timer1.Enabled == true) { return; }
         while (textBox1.Text == "min" || textBox1.Text == "") { return; }
         int min = Convert.ToInt32(textBox1.Text) * 60;
         if (min > 604800) { MessageBox.Show("Too long time!"); return; }
         minLeft = min;
         string time = Convert.ToString(min);
         string start = "/s /t " + time;
         label2.Visible = true;
         label3.Visible = true;
         timer1.Enabled = true;

         Process.Start("shutdown", start);//Стартиране на изключването

         if (timer1.Enabled == true) { abort = 0; }
      }
      private void button2_Click(object sender, EventArgs e)
      {
         Process.Start("shutdown", " /a");//Спиране на изключването
         timer1.Enabled = false;
         abort++;
         if ((abort == 2) && (timer1.Enabled == false)) { Dispose(); }
      }
      private void textBox1_MouseClick(object sender, MouseEventArgs e)
      {
         textBox1.Text = null;
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         minLeft--;
         label1.Text = Convert.ToString(minLeft);
         //button1.Text = Convert.ToString(minLeft);
      }

      private void Form1_DoubleClick(object sender, EventArgs e)
      {
         DialogResult result = colorDialog1.ShowDialog();
         if (result == DialogResult.Cancel) { return; }
         BackColor = colorDialog1.Color;
         label1.BackColor = colorDialog1.Color;
         label2.BackColor = colorDialog1.Color;
         label3.BackColor = colorDialog1.Color;
         label4.BackColor = colorDialog1.Color;
         label5.BackColor = colorDialog1.Color;

         if (BackColor.Name == "Black")
         {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
         }
         if (BackColor.Name == "White")
         {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
         }
      }

      private void label5_DoubleClick(object sender, EventArgs e)
      {
         DialogResult result = colorDialog1.ShowDialog();
         if (result == DialogResult.Cancel) { return; }
         BackColor = colorDialog1.Color;
         label1.BackColor = colorDialog1.Color;
         label2.BackColor = colorDialog1.Color;
         label3.BackColor = colorDialog1.Color;
         label4.BackColor = colorDialog1.Color;
         label5.BackColor = colorDialog1.Color;

         if (BackColor.Name == "Black")
         {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
         }
         if (BackColor.Name == "White")
         {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
         }
      }
   }
}

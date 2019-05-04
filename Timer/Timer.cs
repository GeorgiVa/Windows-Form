using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
   public partial class Timer : Form
   {
      public Timer()
      {
         InitializeComponent();
      }

      int hours, min, sec, milisec;
      int chronHours, chronMin;
      SoundPlayer sound = new SoundPlayer();
      private void button1_Click(object sender, EventArgs e)
      {
         timer1.Enabled = true;
      }

      private void button2_Click(object sender, EventArgs e)
      {
         timer1.Enabled = false;
      }

      private void button3_Click(object sender, EventArgs e)
      {
         timer1.Enabled = false;
         label1.Text = "0";
         label2.Text = "0";
         label3.Text = "0";
         hours = 00;
         min = 00;
         sec = 00;
         textBox1.Text = "min"; textBox2.Text = "hour";
      }
      private void button4_Click(object sender, EventArgs e)
      {
         Dispose();
      }

      private void radioButton2_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButton2.Checked == true) { BackColor = Color.Yellow; }
      }
      private void radioButton4_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButton4.Checked == true) { BackColor = Color.WhiteSmoke; }
      }
      private void radioButton5_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButton5.Checked == true) { BackColor = Color.Magenta; }
      }
      private void radioButton6_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButton6.Checked == true) { BackColor = Color.Cyan; }
      }
      private void radioButton3_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButton3.Checked == true) { BackColor = Color.Green; }
      }
      private void radioButton1_CheckedChanged(object sender, EventArgs e)
      {
         if (radioButton1.Checked == true) { BackColor = Color.Red; }
      }

      private void textBox1_MouseClick(object sender, MouseEventArgs e)
      {
         textBox1.Text = "";
      }
      private void textBox2_MouseClick(object sender, MouseEventArgs e)
      {
         textBox2.Text = "";
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         #region
         try
         {
            chronMin = Convert.ToInt32(textBox1.Text);
         }
         catch (FormatException)
         {
            chronMin = 9999999;
            timer1.Enabled = false; MessageBox.Show("Грешно число");
         }

         milisec++;
         label3.Text = Convert.ToString(milisec);

         if (milisec == 59)
         {
            sec++;
            milisec = 0;
            label2.Text = sec.ToString();
         }

         if (sec == 59)
         {
            min++;
            sec = 0;
            label1.Text = min.ToString();
         }
         if (min == 59)
         {
            hours++;
            min = 0;
            label9.Text = hours.ToString();
         }
         #endregion


         ///----------------->>> ВКЛЮЧВАНЕ НА НОВ ПРОЦЕС <<<--------------------------------
         Task.Factory.StartNew(() => timer2_Tick(sender, e));//<-- ВКЛЮЧВАНЕ НА НОВ ПРОЦЕС
         ///----------------->>> ВКЛЮЧВАНЕ НА НОВ ПРОЦЕС <<<--------------------------------


         if (chronMin == min)
         {
            timer1.Enabled = false;
            sound.SoundLocation = @"REMINDER.WAV";
            sound.PlayLooping();

            if (MessageBox.Show("Time's up", "Done", MessageBoxButtons.OK) == DialogResult.OK)
            {
               Thread.Sleep(500);
               sound.Stop();
            }
         }
      }
      private void timer2_Tick(object sender, EventArgs e)
      {
         Thread.Sleep(3600000);
         sound.Stop();
      }
   }
}

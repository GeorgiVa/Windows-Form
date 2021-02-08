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
      string time;

      private void shutdown_Click(object sender, EventArgs e)
      {
         if (timerShutdown.Enabled == true) { return; }
         SettingsShutdownSleep_Method();

         string start = "/s /t " + time;
         if (time != null)
         {
            Process.Start("shutdown", start);//Стартиране на изключването с командата "shutdown"
         }
         if (timerShutdown.Enabled == true) { abort = 0; }
      }
      private void sleep_Click(object sender, EventArgs e)
      {
         if (timerShutdown.Enabled == true) { return; }
         SettingsShutdownSleep_Method();
         if (timerShutdown.Enabled == true) { abort = 0; this.ControlBox = false; }
      }
      private void shutdownAbort_Click(object sender, EventArgs e)
      {
         time = null;
         abort++;
         labelSec.Text = "...";
         labelAbortInfo.Visible = false;
         if (timerShutdown.Enabled == true) { Process.Start("shutdown", " /a"); }//Спиране на изключването
         timerShutdown.Enabled = false;
         textMinLeft.Text = "min";
         this.ControlBox = true;
         if (timerShutdown.Enabled == true) { abort = 0; }
         if (abort == 2) { Dispose(); }
      }
      private void textBoxMin_MouseClick(object sender, MouseEventArgs e)
      {
         if (textMinLeft.Text == null || textMinLeft.Text == "min") { textMinLeft.Text = null; }
      }
      private void timer1_Tick(object sender, EventArgs e)
      {
         minLeft--;
         labelSec.Text = Convert.ToString(minLeft);

         if (minLeft <= 0)//Стартиране на заспиването
         {
            timerShutdown.Stop();
            this.Close();

            Application.SetSuspendState(PowerState.Suspend, false, false);
         }
      }
      private void Form1_DoubleClick(object sender, EventArgs e)
      {
         DialogResult result = colorDialog.ShowDialog();

         if (result == DialogResult.Cancel) { return; }
         
         BackColor = colorDialog.Color;
         labelSec.BackColor = colorDialog.Color;
         labelAbortInfo.BackColor = colorDialog.Color;
         labelSecText.BackColor = colorDialog.Color;
         label4.BackColor = colorDialog.Color;
         labelColor.BackColor = colorDialog.Color;

         if (BackColor.Name == "Black")
         {
            labelSec.ForeColor = Color.White;
            labelAbortInfo.ForeColor = Color.White;
            labelSecText.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            labelColor.ForeColor = Color.White;
         }
         if (BackColor.Name == "White")
         {
            labelSec.ForeColor = Color.Black;
            labelAbortInfo.ForeColor = Color.Black;
            labelSecText.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            labelColor.ForeColor = Color.Black;
         }
      }
      private void labelColor_DoubleClick(object sender, EventArgs e)
      {
         DialogResult result = colorDialog.ShowDialog();
         if (result == DialogResult.Cancel) { return; }
         BackColor = colorDialog.Color;
         labelSec.BackColor = colorDialog.Color;
         labelAbortInfo.BackColor = colorDialog.Color;
         labelSecText.BackColor = colorDialog.Color;
         label4.BackColor = colorDialog.Color;
         labelColor.BackColor = colorDialog.Color;

         if (BackColor.Name == "Black")
         {
            labelSec.ForeColor = Color.White;
            labelAbortInfo.ForeColor = Color.White;
            labelSecText.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            labelColor.ForeColor = Color.White;
         }
         if (BackColor.Name == "White")
         {
            labelSec.ForeColor = Color.Black;
            labelAbortInfo.ForeColor = Color.Black;
            labelSecText.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            labelColor.ForeColor = Color.Black;
         }
      }

      private void SettingsShutdownSleep_Method()
      {
         if (timerShutdown.Enabled == true) { return; }
         while (textMinLeft.Text == "min" || textMinLeft.Text == "") { return; }

         int min = Convert.ToInt32(textMinLeft.Text) * 60;
         if (min > 604800)
         {
            MessageBox.Show("Too long time!"); return;
         }
         minLeft = min;
         time = Convert.ToString(min);
         labelAbortInfo.Visible = true;
         //labelSecText.Visible = true;
         timerShutdown.Enabled = true;
      }

      private void textMinLeft_Leave(object sender, EventArgs e)
      {

      }
   }
}

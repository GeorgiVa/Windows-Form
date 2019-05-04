using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();

         string site = Settings.Default.google;
         webBrowser1.Navigate(site);
         textBox1.AppendText(site);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         string site = "https://www.mataf.net/bg/widget/conversiontab-BGN-SEK";

         ActiveForm.Width = 450;
         ActiveForm.Height = 425;
         webBrowser1.Navigate(site);
         textBox1.Clear();
         textBox1.AppendText(site);
      }
      private void textBox1_Enter(object sender, EventArgs e)
      {
         webBrowser1.Navigate(textBox1.Text);
      }
      private void button3_Click(object sender, EventArgs e)
      {
         ActiveForm.Width = 900;
         ActiveForm.Height = 600;
         textBox1.Clear();
         textBox1.AppendText(Settings.Default.google);
         webBrowser1.Navigate(Settings.Default.google);
      }
      private void button2_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Good Bay :)");
         Thread.Sleep(500);
         base.Dispose();
      }


   }
}

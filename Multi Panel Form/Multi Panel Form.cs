using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultyFormCompressedExe
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }
      private void label4_Click(object sender, EventArgs e)
      {
         Process.Start("Licens.txt");
      }

      private void label6_Click(object sender, EventArgs e)
      {
         Dispose();
      }
      private void button1_Click(object sender, EventArgs e)
      {
         Process.Start("Shut Down PC.exe");
      }
      private void button2_Click(object sender, EventArgs e)
      {
         Process.Start("Timer.exe");
      }
      private void button3_Click(object sender, EventArgs e)
      {
         Process.Start("Currency_Converter.exe");
      }
      private void button4_Click(object sender, EventArgs e)
      {
         Process.Start("Duplicate Finder.exe");
      }
      private void Form1_Load(object sender, EventArgs e)
      {
         Task.Factory.StartNew(() => LabelInfo(choseProgram));
      }
      private void Form1_MouseHover(object sender, EventArgs e)
      {
         Task.Factory.StartNew(() => LabelInfo(choseProgram));
      }

      int proverka = 0;
      public object tLock = new object();
      char[] closeProgram = { 'И', 'З', 'Х', 'О', 'Д', ' ', 'о', 'т', ' ', 'п', 'р', 'о', 'г', 'р', 'а', 'м', 'а', 'т', 'а' };
      char[] choseProgram = { 'И', 'з', 'б', 'е', 'р', 'е', 'т', 'е', ' ', 'п', 'р', 'о', 'г', 'р', 'а', 'м', 'а' };
      char[] shutDownPC = { 'И', 'з', 'к', 'л', 'ю', 'ч', 'в', 'а', 'н', 'е', ' ', 'н', 'а', ' ', 'к', 'о', 'м', 'п', 'ю', 'т', 'ъ', 'р', 'а', ' ', 'с', 'л', 'е', 'д', ' ', 'о', 'п', 'р', 'е', 'д', 'е', 'л', 'е', 'н', 'о', ' ', 'в', 'р', 'е', 'м', 'е' };
      char[] timer = { 'Т', 'а', 'й', 'м', 'е', 'р', ' ', '-', ' ', 'х', 'р', 'о', 'н', 'о', 'м', 'е', 'т', 'ъ', 'р' };
      char[] currencyConverter = { 'В', 'а', 'л', 'у', 'т', 'е', 'н', ' ', 'к', 'о', 'н', 'в', 'е', 'р', 'т', 'о', 'р', ' ', 'и', ' ', 'б', 'р', 'а', 'у', 'з', 'ъ', 'р' };
      char[] dublicateFinder = { 'Т', 'ъ', 'р', 'с', 'е', 'н', 'е', ' ', 'и', ' ', 'и', 'з', 'т', 'р', 'и', 'в', 'а', 'н', 'е', ' ', 'н', 'а', ' ', 'е', 'д', 'н', 'а', 'к', 'в', 'и', ' ', 'ф', 'а', 'й', 'л', 'о', 'в', 'е' };

      private void LabelInfo(char[] chars)
      {
         if (proverka == 0)
         {
            lock (tLock)
            {
               proverka = 1;
               label7.Text = "";
               foreach (var character in chars)
               {
                  label7.Text += character;
                  Thread.Sleep(15);
               }
            }
         }
         proverka = 0;
      }

      #region Бутони - Hover/Leave
      private void label6_MouseHover(object sender, EventArgs e)
      {
         Task.Factory.StartNew(() => LabelInfo(closeProgram));
      }

      private void button1_MouseHover(object sender, EventArgs e)
      {
         button1.Height = 60;
         Task.Factory.StartNew(() => LabelInfo(shutDownPC));
      }
      private void button1_MouseLeave(object sender, EventArgs e)
      {
         button1.Height = 50;
      }

      //----------------------------------------------------------
      private void button2_MouseHover(object sender, EventArgs e)
      {
         button2.Height = 60;
         Task.Factory.StartNew(() => LabelInfo(timer));

      }
      private void button2_MouseLeave(object sender, EventArgs e)
      {
         button2.Height = 50;
      }

      //----------------------------------------------------------
      private void button3_MouseHover(object sender, EventArgs e)
      {
         button3.Height = 60;
         Task.Factory.StartNew(() => LabelInfo(currencyConverter));
      }
      private void button3_MouseLeave(object sender, EventArgs e)
      {
         button3.Height = 50;
      }

      //----------------------------------------------------------
      private void button4_MouseHover(object sender, EventArgs e)
      {
         button4.Height = 60;
         Task.Factory.StartNew(() => LabelInfo(dublicateFinder));
      }
      private void button4_MouseLeave(object sender, EventArgs e)
      {
         button4.Height = 50;
      }
      #endregion


   }
}

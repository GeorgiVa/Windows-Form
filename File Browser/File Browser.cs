using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace _3_Zada4a_WinForm
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();

         string[] folders = Directory.GetLogicalDrives();
         foreach (var drive in folders)
         {
            richTextBox1.AppendText(drive);
            richTextBox1.AppendText("\n");
         }
      }
     
      Stack redoStack = new Stack();//Събира директориите в които съм се връщал за да мога пак да се върна в тях
      Queue searchQueue = new Queue();//За добавяне на папки и файлове за търсене(когато се влезе в директория преди това searchQueue се изчиства за да може да се търси от съответната директория-изчиства се и когато се натискат бутоните за back и redo)
      Queue searchFounded = new Queue();//Намерени пътища и файлове
      string[] allLineArr;
      int linePos;
  
      //-----------------------------Методи---------------------------------------------
      private void GetAndPrintFilesAndFolders() //Метода за взимане на директориите и файловете
      {
         try
         {
            if (textBox1.Text != "" && textBox1.Text != "Компютър")
            {
               string[] folders = Directory.GetDirectories(textBox1.Text);
               foreach (var folder in folders)
               {
                  richTextBox1.AppendText(folder);
                  richTextBox1.AppendText("\n");
               }

               string[] files = Directory.GetFiles(textBox1.Text);
               foreach (var file in files)
               {
                  richTextBox1.AppendText(file);
                  richTextBox1.AppendText("\n");
               }
            }
            else
            {
               string[] folders = Directory.GetLogicalDrives();
               foreach (var folder in folders)
               {
                  richTextBox1.AppendText(folder);
                  richTextBox1.AppendText("\n");
               }
            }
         }
         catch (IOException) { Process.Start(textBox1.Text); }
         catch (UnauthorizedAccessException ex)
         {
            richTextBox1.AppendText(" Error: \n" + ex.Message);
         }
         if (textBox1.Text == "") { textBox1.Text = "Компютър"; }
      }
      private void TakeNumberCklickedRow(out string[] allLine, out int linePos) //Взимане на реда върху който е кликнато
      {
         allLine = richTextBox1.Lines;
         int charIndex = richTextBox1.GetFirstCharIndexOfCurrentLine();
         linePos = richTextBox1.GetLineFromCharIndex(charIndex);
      }
      private void PutStartDirInQueue()
      {
         //Първо взимам директория върху която е кликнато за да търся в нея
         //Ако не е в директория взимам локалните дискове C:\\ D:\\ и другите

         richTextBox1.Clear();
         pictureBox1Search.Image = pictureBox1Search.ErrorImage;
         if (textBox1.Text != "Компютър")
         {
            searchQueue.Enqueue(textBox1.Text);
         }
         else
         {
            string[] logicalDrives = Directory.GetLogicalDrives();
            foreach (var drive in logicalDrives)
            {
               searchQueue.Enqueue(drive); //Добавям ги за да търся в целия компютър 
            }
         }
      }
      private void SearchWord_BFS() //Търсенето в ширина с рекурсия
      {
         int countFolder = 0;
         int countFiles = 0;
         try
         {
            while (searchQueue.Count > 0)
            {
               string path = searchQueue.Dequeue().ToString();
               string[] folders = Directory.GetDirectories(path);
               countFolder += folders.Length;
               foreach (var folderPath in folders)
               {
                  searchQueue.Enqueue(folderPath);//Добавям само директориите за да търся и в тях на следващата итерация
                  SearchPatternInPath(folderPath);
               }

               string[] files = Directory.GetFiles(path);
               countFiles += files.Length;
               foreach (var filePath in files)
               {
                  SearchPatternInPath(filePath);
               }
            }
            PrintCountedItem(countFolder, countFiles);
            foreach (var path in searchFounded)
            {
               richTextBox1.AppendText(path.ToString() + "\n");
            }
         }
         catch (UnauthorizedAccessException ex)
         {
            richTextBox2.AppendText(ex.Message + "\n");
            SearchWord_BFS();
         }
         catch (IOException ex) { richTextBox2.AppendText(ex.Message + "\n"); }
         PrintCountedItem(countFolder, countFiles);//Тука ги печата много пъти а не трябва
      }
      private void SearchPatternInPath(string path)
      {
         string textBox2Pattern = textBox2.Text;
         Regex regexClass = new Regex(textBox2Pattern);
         bool matchPathAndRegex = regexClass.IsMatch(path);
         if (matchPathAndRegex) { searchFounded.Enqueue(path); }
      }
      private void PrintCountedItem(int countFolder, int countFiles)
      {
         richTextBox2.Clear();
         richTextBox2.AppendText("Файлове   " + countFiles.ToString() + " бр.\n");
         richTextBox2.AppendText("Папки   " + countFolder.ToString() + " бр.\n");
      }
      //-----------------------------------------------------------------------------------------
      private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)//Влизане в папка или отваряне на файл
      {
         TakeNumberCklickedRow(out allLineArr, out linePos);

         if (allLineArr.Length != 0 && allLineArr[linePos] != "")
         {
          textBox1.Text = allLineArr[linePos]; 
            richTextBox1.Clear();
            redoStack.Clear();
         }
         GetAndPrintFilesAndFolders();
      }
      private void richTextBox1_MouseClick(object sender, MouseEventArgs e) //Инфото на кликнат файл (ДА ГО ДОПЪЛНЯ)
      {
         richTextBox2.Clear();

         TakeNumberCklickedRow(out allLineArr, out linePos);

         if (allLineArr.Length != 0 && allLineArr[linePos] != "")
         {
            FileInfo fileInfo = new FileInfo(allLineArr[linePos]);
            DriveInfo driveInfo = new DriveInfo(allLineArr[linePos]);

            if (fileInfo.Name == "")
            {
               richTextBox2.AppendText("Локален Диск  (" + driveInfo.Name + ")\n");
            }
            else
            {
               richTextBox2.AppendText(" " + fileInfo.Name + "\n");
               richTextBox2.AppendText("    " + fileInfo.Attributes + "\n");
               richTextBox2.AppendText("       Създаден на: " + fileInfo.CreationTime.ToString() + "\n");
            }
            try
            {
               long totalSize = driveInfo.TotalSize / 1024 / 1024 / 1024;
               long freeSpace = driveInfo.TotalFreeSpace / 1024 / 1024 / 1024;

               richTextBox2.AppendText("           File System " + driveInfo.DriveFormat.ToString() + "\n");
               richTextBox2.AppendText("           Total Size " + totalSize.ToString() + " GB" + "\n");
               richTextBox2.AppendText("           Free Size " + freeSpace.ToString() + " GB" + "\n");
            }
            catch (IOException ex) { richTextBox2.AppendText(ex.Message); }
         }
      }
      private void pictureBox1_ClickBack(object sender, EventArgs e) //Това е бутона за назад 
      {
         pictureBox1Back.Width = 27;
         pictureBox1Back.Height = 22;
         timer1.Start();
         richTextBox2.Clear();
         redoStack.Push(textBox1.Text);//Слагам пътя който е бил посетен
         string backPath = "";
         //Търси наклонена черта (\) и взима буквите на директорията за да се върне назад
         for (int i = textBox1.Text.Length - 2; i >= 0; i--)
         {
            if (textBox1.Text[i] == '\\')
            {
               for (int j = 0; j <= i; j++)
               {
                  backPath += textBox1.Text[j];
               }
               break;
            }
         }
         richTextBox1.Clear();
         textBox1.Clear();
         textBox1.Text = backPath;
         //-----------------------------------------------------------
         GetAndPrintFilesAndFolders();
         //-----------------------------------------------------------
      }
      private void pictureBox2_ClickRedo(object sender, EventArgs e) //Това е бутона за redo 
      {
         pictureBox2Redo.Width = 27;
         pictureBox2Redo.Height = 22;
         timer1.Start();
         richTextBox2.Clear();
         if (redoStack.Count > 0)
         {
            string redoBack = redoStack.Pop().ToString();
            richTextBox1.Clear();
            textBox1.Clear();
            textBox1.Text = redoBack;
            //-----------------------------------------------------------
            GetAndPrintFilesAndFolders();
            //-----------------------------------------------------------
         }
      }
      private void pictureBox1Search_MouseClick(object sender, MouseEventArgs e)//Search с лупата ИЛИ изтриване на търсената дума
      {
         if (e.Button == MouseButtons.Left && pictureBox1Search.Image == pictureBox1Search.ErrorImage)
         {
            textBox2.ForeColor = Color.Silver;
            searchQueue.Clear();
            richTextBox1.Clear();
            textBox2.Text = "Search";
            pictureBox1Search.Image = pictureBox1Search.InitialImage;
            GetAndPrintFilesAndFolders();
         }
         else
         {
            PutStartDirInQueue();
            SearchWord_BFS();
         }
      }
      private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e) //Връщане в Компютър 
      {
         richTextBox1.Clear();
         textBox1.Text = "Компютър";
         string[] logicalDrives = Directory.GetLogicalDrives();
         foreach (var drive in logicalDrives)
         {
            richTextBox1.AppendText(drive);
            richTextBox1.AppendText("\n");
         }
      }
      private void textBox1_MouseHover(object sender, EventArgs e)//textBox1 смяна на цвета на фона 
      {
         textBox1.BackColor = Color.White;
      }
      private void textBox1_MouseLeave(object sender, EventArgs e)//textBox1 Връщане на цвета на фона 
      {
         textBox1.BackColor = Color.FloralWhite;
      }
      private void textBox2_MouseClick(object sender, MouseEventArgs e) //Search - Clear()  
      {
         if (textBox2.ForeColor != Color.Black)
         {
            textBox2.Clear();
         }
      }
      private void textBox2_Enter(object sender, EventArgs e)//Като натисна Tab и отида на Search-a
      {
         if (textBox2.ForeColor != Color.Black)
         {
            textBox2.Clear();
         }
      }
      private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//Search - Enter Key 
      {
         textBox2.ForeColor = Color.Black;
         if (e.KeyChar == 13)
         {
            PutStartDirInQueue();
            SearchWord_BFS();
         }
      }
      private void textBox2_MouseHover(object sender, EventArgs e)//textBox2 смяна на цвета на фона
      {
         textBox2.BackColor = Color.White;
      }
      private void textBox2_MouseLeave(object sender, EventArgs e)//textBox2 Връщане на цвета на фона
      {
         textBox2.BackColor = Color.FloralWhite;
         //if (textBox2.Text == "") { textBox2.Text = "Search"; }
      }
      private void timer1_Tick(object sender, EventArgs e) //За размера на стрелките
      {
         pictureBox1Back.Width = 30;
         pictureBox1Back.Height = 25;
         pictureBox2Redo.Width = 30;
         pictureBox2Redo.Height = 25;
         timer1.Stop();
      }
      //--------------------------------------------
      private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
      {
         bool checkSizeNS = false;
         label3.Text = MousePosition.Y.ToString();
         label4.Text = richTextBox1.Height.ToString();
         label6.Text = richTextBox2.Height.ToString();

         int SizeNS_Pos = richTextBox1.Height + this.Top + 85;
         if (SizeNS_Pos - 10 <= MousePosition.Y && SizeNS_Pos + 30 >= MousePosition.Y)
         {
            //Прихващане долния ръб на richTextBox1
            //-10 и +30 са зададани за да прихваща мишката на range от пиксели 
            Cursor.Current = Cursors.SizeNS;
            checkSizeNS = true;
         }
         //--------------------------------------------------------------------------------------
         //За  richTextBox2.Height използвам 'Location' който вдига горния ръб нагоре и 'strech_r_T_Box2' който сваля долния ръб
         int strech_r_T_Box1 = MousePosition.Y - this.Top - 85;
         int strech_r_T_Box2 = this.Bottom - MousePosition.Y;
         Point r_T_Box2Point = new Point(0, strech_r_T_Box1 + 60);

         //int maxSizeRTB1 = Convert.ToInt32(this.Bottom - this.Top);
         //int minSizeRTB1 = this.Height + 100;
         //richTextBox1.MaximumSize = new Size(this.Width, maxSizeRTB1);
         //richTextBox1.MinimumSize = new Size(this.Width, minSizeRTB1);

         //int maxSizeRTB2 = Convert.ToInt32((this.Bottom - this.Top) * 0.75);
         //int minSizeRTB2 = this.Height + 100;
         //richTextBox2.MaximumSize = new Size(this.Width, maxSizeRTB2);
         //richTextBox2.MinimumSize = new Size(this.Width, minSizeRTB2);

         if ((e.Button == MouseButtons.Left) && checkSizeNS == true)
         {
            richTextBox1.Height = strech_r_T_Box1;
            richTextBox2.Height = strech_r_T_Box2;
            richTextBox2.Location = r_T_Box2Point;
         }
      }
      private void Form1_Resize(object sender, EventArgs e)
      {
         int maxSizeRTB1 = Convert.ToInt32(this.Bottom - this.Top);
         int minSizeRTB1 = this.Height - richTextBox2.Height - 85;
         richTextBox1.MaximumSize = new Size(this.Width - 8, maxSizeRTB1);
         richTextBox1.MinimumSize = new Size(this.Width - 8, minSizeRTB1);

         int maxSizeRTB2 = Convert.ToInt32(this.Bottom - this.Top);
         int minSizeRTB2 = this.Height - richTextBox1.Height;
         richTextBox2.MaximumSize = new Size(this.Width - 8, maxSizeRTB2);
         richTextBox2.MinimumSize = new Size(this.Width - 8, minSizeRTB2);
      }
   }
}

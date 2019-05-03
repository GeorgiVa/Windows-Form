using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Dublicat_Finder
{
   public partial class Form1 : Form
   {
      public Form1() { InitializeComponent(); }

      int checkDir = 0;
      int countFiles = 0;
      int countRemoved = 0;
      string fileType = null;
      int delFileExtended = 0;
      string[] filesArr = null;
      List<string> List_filesInFoldersForDel = new List<string>();
      List<string> List_FilesNameForDel = new List<string>();
      string fileName = null;
      string startDirectory = null;
      string logFile = null;

      //--------------------------------------Методи--------------------------------------
      private void GetFolders(string inputDir)//<<---Папки DFS-----
      {
         try
         {
            GetFiles(inputDir);

            string[] dirsArr = Directory.GetDirectories(inputDir);
            foreach (var folder in dirsArr)
            {
               GetFolders(folder);
            }
         }
         catch (UnauthorizedAccessException)
         {
            richTextBox1.AppendText("Заключена или системна папка");
         }
      }
      //-----------------
      private void GetFiles(string folder)//<----Файлове - Търсене-----
      {
         //<<<ВАЖНО>>>Така търси само файлове с това разширение
         //string[] files = Directory.GetFiles(folder,"*.exe");

         #region 
         //Проверка за търсене на файлове по разширение(exe, jpg, mp3...)
         if (fileType == "*Тип файл или Изтриване на всички повтарящи" || fileType == "*")
         {
            filesArr = Directory.GetFiles(folder);
         }
         else
         {  //Ако е влязло тука значи ще трие по разширение на файла
            filesArr = Directory.GetFiles(folder, fileType);//Тук взима файлове по разширение и само тях слага в масива и после се трият
            delFileExtended = 1;
         }
         countFiles = countFiles + filesArr.Length;
         #endregion

         foreach (var item in filesArr)
         {
            richTextBox1.AppendText(item);//---Показване на файловете в прозореца на програмата
            richTextBox1.AppendText("\n");
            //За да се премести файл, се взима отделно само името му и се залепва за името на папка, в коато се премества
            fileName = Path.GetFileName(item);//<<---Така се взима само името на файла
            List_filesInFoldersForDel.Add(item);//<---Слагам файловете в List-а в който ще търся и трия след като се натрупат
            List_FilesNameForDel.Add(fileName);
         }
         WriteInLogFile();//<---Записване имената на файловете в Log.txt файл
      }

      private void EreaseDublicateFile()//<---Изтриване с бутона Изтрий
      {
         //В двата List-aслагам имената и пътя до файл 
         //След това ги прехвърлям в масив за да им взимам позицията
         //Изтриване на файлове от масивите и папката коята е зададена
         string[] filesInFolderArr = List_filesInFoldersForDel.ToArray();
         string[] onlyNamesAtFilesArr = List_FilesNameForDel.ToArray();
         string searchedFile = null;
         string compareFile = null;

         //--------------!!! ИЗТРИВАНЕ !!!--------------
         #region //изтриване по разширение на файла
         if (delFileExtended == 1)
         {
            string typeFile = "Изтриване на всички файлове с разширение ''" + textBox2.Text + "''";
            if (MessageBox.Show(typeFile, "Warning !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
               return;
            }
            foreach (var item in filesInFolderArr)
            {
               //Тук вече има само файлове по разширение (exe, txt, jpg....)
               FileSystem.DeleteFile(item, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);
               countRemoved++;
            }
            filesInFolderArr = null;
            onlyNamesAtFilesArr = null;
         }
         #endregion

         //--------------!!! ИЗТРИВАНЕ !!!!--------------
         #region //изтриване на всички повтарящи се
         else
         {
            string typeFile = "Изтриване на всички повтарящи се файлове!";
            if (MessageBox.Show(typeFile, "Warning !!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
               return;
            }
            for (int i = 0; i < filesInFolderArr.Length; i++)
            {
               searchedFile = onlyNamesAtFilesArr[i];
               for (int j = i + 1; j < filesInFolderArr.Length; j++)
               {
                  compareFile = onlyNamesAtFilesArr[j];
                  //Проверка за изтрити файлове. На мястото на изтритите се слага null
                  if (searchedFile == compareFile && (searchedFile != null || compareFile != null))
                  {
                     FileSystem.DeleteFile(filesInFolderArr[j], UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);

                     // Зануляване на поз.от която е изтрит файл за да не се повтаря 
                     //и да не се натрупва невярна бройка в брояча
                     filesInFolderArr[j] = null;
                     onlyNamesAtFilesArr[j] = null;
                     countRemoved++;
                  }
               }
            }
            filesInFolderArr = null;
            onlyNamesAtFilesArr = null;
         }
         #endregion
      }

      private void WriteInLogFile()//<---Записване имената на файловете в Log.txt файл
      {
         try
         {
            using (StreamWriter writeFileLog = new StreamWriter(logFile, append: true))//--------
            {
               foreach (var item in filesArr) { writeFileLog.WriteLine(item, true); }
            }
         }
         catch (FormatException ex)
         {
            richTextBox1.AppendText(ex.Message);
         }
      }

      private void SelectFolder()// Потвърждение от прозореца OK и Cancel
      {
         textBox1.Clear();
         richTextBox1.Clear();

         using (var fdb = new FolderBrowserDialog())
         {
            DialogResult result = fdb.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fdb.SelectedPath))
            {
               textBox1.AppendText(fdb.SelectedPath);
            }
            else { textBox1.AppendText("Път до папка C:\\ D:\\ E:\\ ..."); }
         }
      }

      private int CheckDir(string input)
      {
         try { string[] arr = Directory.GetFiles(input); checkDir = 0; }

         catch (ArgumentException)
         {
            MessageBox.Show("Невалиден път! \nНапишете път до папка или отворете папка!", "Грешка! :)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            checkDir = 1;
         }
         catch (DirectoryNotFoundException)
         {
            MessageBox.Show("Невалиден път! \nНапишете път до папка или отворете папка!", "Грешка! :)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            checkDir = 1;
         }
         catch (NotSupportedException)
         {
            MessageBox.Show("Невалиден път! \nНапишете път до папка или отворете папка!", "Грешка! :)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            checkDir = 1;
         }
         catch (UnauthorizedAccessException)
         {
            MessageBox.Show("Невалиден път! \nНапишете път до папка или отворете папка!", "Грешка! :)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            checkDir = 1;
         }
         catch (IOException)
         {
            MessageBox.Show("Невалиден път! \nНапишете път до папка или отворете папка!", "Грешка! :)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            checkDir = 1;
         }
         return checkDir;
      }
      //--------------------------------------Buttons--------------------------------------
      private void button1_Click(object sender, EventArgs e)
      {
         checkDir = 0;
         countFiles = 0;
         startDirectory = textBox1.Text;//-------Start Търсене 1----------
         checkDir = CheckDir(startDirectory);  //Проверка за несъществуваща папка
         if (checkDir == 1) { return; }
         logFile = startDirectory + "\\Log.txt";
         fileType = "*" + textBox2.Text;
         GetFolders(startDirectory);//<<<----Файлове - Търсене-----
         richTextBox1.AppendText("Файловете са " + countFiles + " бр.\n");
         delFileExtended = 0;

         #region Записване на "countFiles" в Log.txt файла
         try
         {
            using (StreamWriter writeFileLog = new StreamWriter(logFile, append: true))//--------
            {
               writeFileLog.WriteLine("Файловете са " + countFiles + " бр.\n", true);
            }
         }
         catch (UnauthorizedAccessException ex) { MessageBox.Show(ex.Message, "Грешка! :)", MessageBoxButtons.OK, MessageBoxIcon.Error); }
         #endregion
      }

      private void button2_Click(object sender, EventArgs e)
      {
         checkDir = 0;
         countFiles = 0;
         List_filesInFoldersForDel.Clear();
         List_FilesNameForDel.Clear();
         startDirectory = textBox1.Text;//-------Start Изтриване 2----------
         checkDir = CheckDir(startDirectory); //Проверка за несъществуваща папка
         if (checkDir == 1) { return; }
         logFile = startDirectory + "\\Log.txt";
         fileType = "*" + textBox2.Text;
         GetFolders(startDirectory);//<<<----Файлове - Търсене и преброяване-----
         EreaseDublicateFile();//--Изтриване
         richTextBox1.AppendText("  Файловете са " + countFiles + " бр.\n");
         richTextBox1.AppendText("  Изтрити " + countRemoved + " бр.\n");
         delFileExtended = 0;

         #region Записване на "countRemoved" в Log.txt файла
         using (StreamWriter writeFileLog = new StreamWriter(logFile, append: true))//--------
         {
            writeFileLog.WriteLine("  Изтрити " + countRemoved + " бр.\n", true);
         }
         #endregion
         countRemoved = 0;
         //Process.Start(logFile); //---Отваряне на Log.txt файла
         //File.Delete(logFile);
      }

      private void button3_Click(object sender, EventArgs e)
      {
         richTextBox1.Clear();
      }

      private void textBox2_MouseClick(object sender, MouseEventArgs e)
      {
         textBox2.Clear();
      }

      //----------------------------Menu Buttons--------------------------
      private void programToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Duplicate Finder v1.5 \n Search and remove files", "For Program", MessageBoxButtons.OK, MessageBoxIcon.Question);
      }

      private void creatorToolStripMenuItem_Click_1(object sender, EventArgs e)
      {
         MessageBox.Show("Created by georg_v", "For Creator", MessageBoxButtons.OK, MessageBoxIcon.Question);
      }

      private void quitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Dispose();
      }

      private void openToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         SelectFolder();
      }
      private void openToolStripMenuItem2_Click(object sender, EventArgs e)
      {
         SelectFolder();
      }
      private void calcToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Process.Start("calc.exe");
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Process.Start("explorer");
      }

      private void openDestinationFolderToolStripMenuItem_Click(object sender, EventArgs e)//Проверка за несъществуваща папка
      {
         try
         {
            Process.Start(textBox1.Text);//Отваря папката която е написана в textBox1 или програма
         }
         catch (Exception)
         {
            MessageBox.Show("Невалиден път! \nНапишете път до папка или отворете папка!", "Грешка! :)",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void richTextBox1_MouseDown(object sender, MouseEventArgs e)//Преписано - Контекст менюто за copy,paste....
      {
         if (e.Button == MouseButtons.Right)
         {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem("Cut");

            menuItem.Click += new EventHandler(CutAction);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem("Copy");
            menuItem.Click += new EventHandler(CopyAction);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem("Paste");
            menuItem.Click += new EventHandler(PasteAction);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem("Select All");
            menuItem.Click += new EventHandler(SelectAll);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem("Open File");
            menuItem.Click += new EventHandler(PlayFile);
            contextMenu.MenuItems.Add(menuItem);

            richTextBox1.ContextMenu = contextMenu;
         }
      }
      //---------------Преписано - методи------------
      void CutAction(object sender, EventArgs e)
      {
         richTextBox1.Cut();
      }
      void CopyAction(object sender, EventArgs e)
      {
         Clipboard.SetText(richTextBox1.SelectedText);
      }
      void PasteAction(object sender, EventArgs e)
      {
         if (Clipboard.ContainsText())
         {
            richTextBox1.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
         }
      }
      void SelectAll(object sender, EventArgs e)
      {
         richTextBox1.SelectAll();
         richTextBox1.Focus();
      }
      void PlayFile(object sender, EventArgs e)//Мой метод
      {
         string openFile = null;
         try
         {
            if (richTextBox1.SelectedText[richTextBox1.SelectedText.Length - 1] == '\n')//Премахване на новия ред ('\n') за да се отвори файла
            {
               for (int i = 0; i < richTextBox1.SelectedText.Length - 1; i++)
               {
                  openFile += richTextBox1.SelectedText[i];
               }
               Process.Start(openFile);
            }
            else
            {
               openFile = richTextBox1.SelectedText;
               Process.Start(openFile);
            }
         }
         catch (Exception)
         {
            MessageBox.Show("Файлът вече е изтрит или не е маркиран целия ред или този файл не може да се отвори");
         }//Проверка за немаркиран цял ред
      }
   }
}
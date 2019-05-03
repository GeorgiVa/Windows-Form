using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  public partial class SourceCode : Form
  {
    //11.Напишете програма, която обхожда директорията C:\Windows\ и всичките и поддиректории рекурсивно и отпечатва всички файлове, който имат разширение *.exe.
    //...............................................Решена..........................................

    string[] dirArray = null;
    //-------------------------------------------------------------
    private void GetFolders(string inputDir)//-----Метод за папките------
    {
      if(inputDir == "Директория C, D или E")
      {
        MessageBox.Show("Опа Error-че\nДиректория C, D или E");
        return;
      }
      if(inputDir == "c" || inputDir == "c:" || inputDir == "C" || inputDir == "C:") { inputDir = "C:\\"; }
      if(inputDir == "d" || inputDir == "d:" || inputDir == "D" || inputDir == "D:") { inputDir = "D:\\"; }
      if(inputDir == "e" || inputDir == "e:" || inputDir == "E" || inputDir == "E:") { inputDir = "E:\\"; }

      string tempItem = inputDir + " - Достъпът е отказан\n";

      try
      {
        dirArray = Directory.GetDirectories(inputDir);
        foreach(var item in dirArray)
        {
          richTextBox1.AppendText(item + "\n");
          count++;
          GetFolders(item);
        }
      }
      catch(UnauthorizedAccessException) { richTextBox1.AppendText(tempItem); }
    }
    //========================================================Метод за файловете====================================================================
    static int count = 0; string pattern = null;
    private void GetFoldersFiles(string inputDir)//-----Метод за подпапките и метода за файловете-(не използвам същия метод за папките като горния защото малко се различават)
    {
      if(inputDir == "Директория C, D или E")
      {
        MessageBox.Show("Опа Error-че\n Директория C, D или E");
        return;
      }
      if(inputDir == "c" || inputDir == "c:" || inputDir == "C" || inputDir == "C:") { inputDir = "C:\\"; }
      if(inputDir == "d" || inputDir == "d:" || inputDir == "D" || inputDir == "D:") { inputDir = "D:\\"; }
      if(inputDir == "e" || inputDir == "e:" || inputDir == "E" || inputDir == "E:") { inputDir = "E:\\"; }

      try
      {
        dirArray = Directory.GetDirectories(inputDir);
        GetFiles(inputDir);
        foreach(var item in dirArray) { GetFoldersFiles(item); }
      }
      catch(UnauthorizedAccessException) { richTextBox2.AppendText(" - Достъпът е отказан\n"); }
    }
    string inputName = null;
    public void GetFiles(string directory)//-----Метод за файловете------
    {
      try
      {
        pattern = inputName;
        string[] files = Directory.GetFiles(directory);
        foreach(var item in files)
        {
          //string exeFile = new System.IO.FileInfo(item).Extension; //< --Така се взима разширението на файла
          Match exeFile = Regex.Match(item, pattern);
          if(exeFile.Success)
          {
            richTextBox2.AppendText(item + "\n");
            count++;
          }
        }
      }
      catch(UnauthorizedAccessException) { richTextBox2.AppendText(" - Достъпът е отказан\n"); }
    }
    //===================================================================================================================================
    public SourceCode()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void button1_Click(object sender, EventArgs e)//За ПАПКИТЕ
    {
      richTextBox2.Clear();
      richTextBox2.Visible = false;
      string inputDir = textBox1.Text;
      if(inputDir == "") { return; }
      richTextBox1.AppendText("Директория: " + inputDir);
      richTextBox1.AppendText("\n");
      richTextBox1.AppendText("-----------------------------------------\n");
      GetFolders(inputDir);
      richTextBox1.AppendText("----------------------------");
      richTextBox1.AppendText("\n");
      richTextBox1.AppendText("Папките са " + count + " броя\n");
      richTextBox1.AppendText(new string('=', 50));
      richTextBox2.AppendText("\n");
      count = 0;
    }
    private void button3_Click(object sender, EventArgs e)//За Файловете
    {
      richTextBox1.Clear();
      richTextBox2.Visible = true;
      string inputDir = textBox1.Text;
      if(inputDir == "") { return; }
      inputName = textBox2.Text;
      richTextBox2.AppendText("Директория: " + inputDir);
      richTextBox2.AppendText("\n");
      richTextBox2.AppendText("-----------------------------------------\n");
      GetFoldersFiles(inputDir);
      richTextBox2.AppendText("----------------------------");
      richTextBox2.AppendText("\n");
      richTextBox2.AppendText("Резултат: " + "'" + pattern + "'" + " намерени " + count + " броя\n");
      richTextBox2.AppendText(new string('=', 50));
      richTextBox2.AppendText("\n");
      count = 0;
    }
    private void button2_Click(object sender, EventArgs e)
    {
      richTextBox1.Clear();
      richTextBox2.Clear();
    }


    private void textBox1_MouseClick(object sender, MouseEventArgs e)
    {
      if(textBox1.Text == "Директория C, D или E")
      {
        textBox1.Clear();
      }
      if(textBox2.Text == "")
      {
        Thread.Sleep(200);
        textBox2.Text = "Търсене на файл:";
      }
    }

    private void textBox2_MouseClick(object sender, MouseEventArgs e)
    {
      if(textBox2.Text == "Търсене на файл:")
      {
        textBox2.Clear();
      }
      if(textBox1.Text == "")
      {
        Thread.Sleep(200);
        textBox1.Text = "Директория C, D или E";
      }
    }

    private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
    {
      if(textBox2.Text == "")
      {
        Thread.Sleep(200);
        textBox2.Text = "Търсене на файл:";
      }
      if(textBox1.Text == "")
      {
        Thread.Sleep(200);
        textBox1.Text = "Директория C, D или E";
      }
    }
  }
}

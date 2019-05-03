using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //11.Напишете програма, която обхожда директорията C:\Windows\ и всичките и 
      //поддиректории рекурсивно и отпечатва всички файлове, който имат разширение *.exe
      //...............................................Решена..........................................
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new SourceCode());
    }
  }
}

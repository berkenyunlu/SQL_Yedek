using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Yedek
{
    class Dizinler
    {
        public static string Base = Application.StartupPath;      
        public static string Mutabakat = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Mutabakat";
        public static string Data = Base + "\\Data";
        public static string Tools = Base + "\\Tools";
        public static string Yedek = Data + @"\SQL_Backup\";
        public static void Olustur()
        {
            if (!Directory.Exists(Dizinler.Yedek))
                Directory.CreateDirectory(Dizinler.Yedek);
        }
    }
   
}

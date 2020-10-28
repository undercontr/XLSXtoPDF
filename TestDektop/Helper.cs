using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace XLSXtoPDF
{
    class Helper
    {

        public static bool isRoot(FolderBrowserDialog root)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (var letter in alpha)
            {
                if (root.SelectedPath == letter + ":\\" || root.SelectedPath == letter + @":\")
                {
                    return true;
                }
            }

            return false;
        }

        public static string GetPath(FolderBrowserDialog path)
        {
            string strPath = path.SelectedPath;

            return strPath;
        }

    }
}

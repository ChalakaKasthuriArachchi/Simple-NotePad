using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public static class Functions
    {
        public static void SaveFile(string path,string text)
        {
            string[] lines = text.Split('\n');
            File.WriteAllLines(path, lines);
        }
    }
}

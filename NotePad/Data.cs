using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public static class Data
    {
        #region Printing
        public static List<string> Lines = new List<string>();
        public static int X = 0;
        public static int Y = 0;
        public static int MinX = 0;
        public static int MinY = 0;
        public static int MaxX = 0;
        public static int MaxY = 0;
        public static int CurrentLine = 0;
        public static int PageWidth { get { return MaxX - MinX; } }
        public static int PageHeight { get { return MaxY - MinY; } }
        #endregion

        public static frm_NotePad Form;
        public static string FullPath
        {
            get
            {
                return Path + "\\" + FileName;
            }
            set
            {
                Path = "";
                string[] lst = value.Split('\\');
                for(int x = 0; x < lst.Length - 1; x++)
                {
                    Path += lst[x];
                    if (x < lst.Length - 1)
                        Path += ("\\");
                }
                FileName = lst[lst.Length - 1];
            }
        }
        public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string FileName
        {
            get { return _FileName; }
            set
            {
                _FileName = value;
                Form.Text = value;
            }
        }
        public static bool Saved = false;
        private static string _FileName = "";
    }
}

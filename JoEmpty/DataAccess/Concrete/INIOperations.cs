using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DataAccess.Concrete
{
    public class INIOperations : IINIOperations
    {
        #region imports
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion

        public string Read(string path, string key)
        {
            StringBuilder StrBuild = new StringBuilder(256);
            GetPrivateProfileString("SETTINGS", key, string.Empty, StrBuild, 255, path);
            return StrBuild.ToString();
        }

        public void Write(string path, string key, string value)
        {
            WritePrivateProfileString("SETTINGS", key, value, path);
        }
    }
}

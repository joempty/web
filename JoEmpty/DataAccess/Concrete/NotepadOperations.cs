using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class NotepadOperations : INotepadOperations
    {
        private static readonly object _lock = new object();

        public void Write(string path, string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            lock (_lock)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true)) file.WriteLine(text);
            }
        }

        public void Delete(string path, string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            lock (_lock)
            {
                try { if (System.IO.File.Exists(path)) System.IO.File.WriteAllLines(path, System.IO.File.ReadLines(path).Where(l => l != text).ToList()); }
                catch (System.Exception) { }
            }
        }

        public string[] Read(string path)
        {
            if (string.IsNullOrEmpty(path)) return new string[0];

            lock (_lock)
            {
                return System.IO.File.ReadAllLines(path);
            }
        }
    }
}

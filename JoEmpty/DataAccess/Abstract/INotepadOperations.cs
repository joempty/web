using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface INotepadOperations
    {
        string[] Read(string path);
        void Write(string path, string text);
        void Delete(string path, string text);
    }
}

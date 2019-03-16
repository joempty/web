using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IINIOperations
    {
        void Write(string path, string key, string value);
        string Read(string path, string key);
    }
}

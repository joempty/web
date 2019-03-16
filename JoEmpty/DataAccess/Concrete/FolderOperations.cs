using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class FolderOperations : IFolderOperations
    {
        public string[] GetImages(string filepath)
        {
            return Directory.EnumerateFiles(filepath).Where(x => x.EndsWith(".jpg") || x.EndsWith(".JPG") || x.EndsWith(".jpeg") || x.EndsWith(".JPEG") || x.EndsWith(".png") || x.EndsWith(".PNG")).ToArray();
        }
    }
}

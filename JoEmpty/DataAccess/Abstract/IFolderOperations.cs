using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IFolderOperations
    {
        string[] GetImages(string filepath);
    }
}

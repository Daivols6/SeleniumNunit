using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Core
{
    internal class DirectoryHelper
    {
        public static string GetTestDataFolderPath()
        {
            return Environment.CurrentDirectory + "\\TestData\\";
        }
    }
}

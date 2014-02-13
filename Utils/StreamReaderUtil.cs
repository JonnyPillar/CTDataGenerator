using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Utils
{
    class StreamReaderUtil
    {
        private const string _projectFileURL = @"C:\Code\Calorie Tracker\CTDataGenerator\CTDataGenerator\Data\DataFiles";
        public static StreamReader CreateStreamReader(string fileName)
        {
            string fileURL = Path.Combine(_projectFileURL, fileName);
            return new StreamReader(fileURL);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Utils
{
    public class EncodingUtils
    {

        public static void ConvertFileToUTF8(string path)
        {
            string bytes = File.ReadAllText(path, Encoding.Default);
            File.WriteAllText(path, bytes, Encoding.UTF8);
        }
    }
}

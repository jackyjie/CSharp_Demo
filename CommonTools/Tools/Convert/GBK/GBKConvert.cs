using CommonTools.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Tools.Convert.GBK
{
    public class GBKConvert : AGBKConvert
    {
        public override void GBK2UTF8(FileInfo file)
        {
            EncodingUtils.ConvertFileToUTF8(file.FullName);
        }

        public override void Iterator(DirectoryInfo info, ref List<FileInfo> list)
        {
            getFileInfoByDirectory(info, ref list);
        }

        public override bool RecognizeGBK(FileInfo file)
        {
            EncodingRecognize recognize = new EncodingRecognize();
            Encoding encoding = recognize.GetEncoding(file.FullName);
            return encoding == Encoding.GetEncoding("GBK") ? true : false;
        }

        public void IteratorDictory(string directory)
        {
            base.IteratorDictory(directory);
        }

        public void getFileInfoByDirectory(DirectoryInfo info, ref List<FileInfo> infos){
            
            infos.AddRange(info.GetFiles());
            foreach(DirectoryInfo item in info.GetDirectories())
            {
                getFileInfoByDirectory(item, ref infos);
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonTools.Tools.Convert.GBK
{
    public abstract class AGBKConvert:IGBKConvert
    {
        public abstract bool RecognizeGBK(FileInfo file);
        public abstract void GBK2UTF8(FileInfo file);

        // 文件夹遍历
        public abstract void Iterator(DirectoryInfo info, ref List<FileInfo> list);

        // 接口遍历
        public void IteratorDictory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                return; 
            }
            List<FileInfo> fileInfos = new List<FileInfo>();
            DirectoryInfo _directory = Directory.CreateDirectory(directory);
            fileInfos.AddRange(_directory.GetFiles());
            Iterator(_directory, ref fileInfos);
            if (fileInfos != null)
            {
                foreach (FileInfo info in fileInfos)
                {
                    try
                    {
                        if (RecognizeGBK(info))
                        {
                            GBK2UTF8(info);
                        }
                    }catch(Exception ex)
                    {

                    }
                }
            }

        }
    }
}

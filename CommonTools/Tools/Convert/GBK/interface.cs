using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonTools.Tools.Convert.GBK
{
    public interface IGBKConvert
    { 

        //2.GBK识别
        bool RecognizeGBK(FileInfo file);

        //3.UTF8转换
        void GBK2UTF8(FileInfo file);
    }
}

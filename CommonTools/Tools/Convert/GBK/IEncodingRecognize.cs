using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Tools.Convert.GBK
{
    public abstract class AEncodingRecognize : IEncodingRecognize
    {

        // 文件流
        public byte[] bytes;

        // 2.验证GBK/UTF8 GBK byte > UTF8Bytes
        public Encoding GetEncoding(String fileName)
        {
            ReadFile(fileName);

            if(bytes.Length < 4)
            {
                throw new ArgumentException("文件长度小于4，没有获取文件签名");
            }

            byte[] bom = bytes.Take(4).ToArray();

            // 签名文件Encoding
            Encoding encoding = GetSignedEncoding(bom);

            // uft8无签名
            if (encoding.Equals(Encoding.ASCII)) //GBK utf8
            {
                //如果都是ASCII，那么无法知道编码
                //如果属于 Utf8的byte数大于 GBK byte数，那么编码是 utf8，否则是GBK
                //如果两个数相同，那么不知道是哪个

                var countUtf8 = CountUtf8();
                if (countUtf8 == 0)
                {
                    encoding = Encoding.ASCII;
                }
                else
                {
                    var countGbk = CountGbk();
                    if (countUtf8 > countGbk)
                    {
                        encoding = Encoding.UTF8;
                    }
                    else
                    {
                        encoding = Encoding.GetEncoding("GBK");
                    }
                }
            }

            return encoding;
        }

        // 2.1 获取GBKbyte
        public abstract int CountGbk();

        // 2.2 获取UTF8byte
        public abstract int CountUtf8();

        // 1.验证是否是签名
        public abstract Encoding GetSignedEncoding(byte[] bom);

        public abstract void ReadFile(string fileName);  
        
    }

    public interface IEncodingRecognize
    {
        // 1.验证是否是签名
        Encoding GetSignedEncoding(byte[] bom);

        // 2.1 获取GBKbyte
        int CountGbk();

        // 2.2 获取UTF8byte
        int CountUtf8();
    }
}

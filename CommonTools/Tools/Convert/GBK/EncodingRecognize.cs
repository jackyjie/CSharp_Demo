using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Tools.Convert.GBK
{
    public class EncodingRecognize : AEncodingRecognize
    {

        public Encoding GetEncoding(string fileName)
        {
            return  base.GetEncoding(fileName);
        }

        public override int CountGbk()
        {
            var count = 0; //存在GBK的byte
            var length = bytes.Length; //总长度
            var buffer = bytes; // 字符数

            const char head = (char)0x80; //小于127 通过 &head==0

            for (var i = 0; i < length; i++)
            {
                var firstByte = buffer[i]; //第一个byte，GBK有两个
                if ((firstByte & head) == 0) //如果是127以下，那么就是英文等字符，不确定是不是GBK
                {
                    continue; //文件全部都是127以下字符，可能是Utf-8 或ASCII
                }
                if (i + 1 >= length) //如果是大于127，需要两字符，如果只有一个，那么文件错了，但是我也没法做什么
                {
                    break;
                }
                var secondByte = buffer[i + 1]; //如果是GBK，那么添加GBK byte 2
                if (firstByte >= 161 && firstByte <= 247 &&
                    secondByte >= 161 && secondByte <= 254)
                {
                    count += 2;
                    i++;
                }
            }
            return count;
        }

        public override int CountUtf8()
        {
            var count = 0;
            var length = bytes.Length;
            var buffer = bytes;

            const char head = (char)0x80;
            //while ((n = stream.Read(buffer, 0, n)) > 0)
            {
                for (var i = 0; i < length; i++)
                {
                    var temp = buffer[i];
                    if (temp < 128) //  !(temp&head)
                    {
                        //utf8 一开始如果byte大小在 0-127 表示英文等，使用一byte
                        //length++; 我们记录的是和CountGBK比较
                        continue;
                    }
                    var tempHead = head;
                    var wordLength = 0; //单词长度，一个字使用多少个byte

                    while ((temp & tempHead) != 0) //存在多少个byte
                    {
                        wordLength++;
                        tempHead >>= 1;
                    }

                    if (wordLength <= 1)
                    {
                        //utf8最小长度为2
                        continue;
                    }

                    wordLength--; //去掉最后一个，可以让后面的 point大于wordLength
                    if (wordLength + i >= length)
                    {
                        break;
                    }
                    var point = 1; //utf8的这个word 是多少 byte
                    //utf8在两字节和三字节的编码，除了最后一个 byte 
                    //其他byte 大于127 
                    //所以 除了最后一个byte，其他的byte &head >0
                    for (; point <= wordLength; point++)
                    {
                        var secondChar = buffer[i + point];
                        if ((secondChar & head) == 0)
                        {
                            break;
                        }
                    }

                    if (point > wordLength)
                    {
                        count += wordLength + 1;
                        i += wordLength;
                    }
                }
            }
            return count;
        }

        public override Encoding GetSignedEncoding(byte[] bom)
        {
            if (bom.Length != 4)
            {
                throw new ArgumentException("EncodingScrutator.AutoEncoding 参数大小不等于4");
            }

            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76)
                return Encoding.UTF7; //85 116 102 55    //utf7 aa 97 97 0 0
            //utf7 编码 = 43 102 120 90

            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf)
                return Encoding.UTF8; //无签名 117 116 102 56
            // 130 151 160 231
            if (bom[0] == 0xff && bom[1] == 0xfe)
                return Encoding.Unicode; //UTF-16LE

            if (bom[0] == 0xfe && bom[1] == 0xff)
                return Encoding.BigEndianUnicode; //UTF-16BE

            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff)
                return Encoding.UTF32;

            return Encoding.ASCII; //如果返回ASCII可能是GBK 无签名utf8
        }

        public override void ReadFile(string fileName)
        {
            FileInfo info = new FileInfo(fileName);
            bytes = new byte[info.Length];
            FileStream stream = info.OpenRead();
            stream.Read(bytes, 0, System.Convert.ToInt32(stream.Length));
            stream.Close();
        }
    }
}

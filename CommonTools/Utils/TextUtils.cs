using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CommonTools.Utils
{
    public static class TextUtils
    {
        public enum SplitOption{
            NOTNULL = 1, // 去除空的
            ALL = 2 // 全部
        }

        /*
         * 截取字符串（字符串）
         * 0 成功 1 字符串问题 2 截取字段问题
         */
        public static string[] MySplit(this string text, string strSplit, SplitOption option = SplitOption.ALL)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null; 
            }
            if (string.IsNullOrEmpty(strSplit))
            {
                return null;
            }
            string[] resultString = Regex.Split(text, strSplit, RegexOptions.IgnoreCase);

            if(option == SplitOption.NOTNULL)// 删除空白字符串
            {
                resultString = resultString.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            }
            return resultString;
        }

        /*
         * 截取字符串（字符）
         */
        public static string[] MySplit(this string text, char cSplite, SplitOption option = SplitOption.ALL)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null; 
            }
            string[] resultString = text.Split(cSplite);
            if (option == SplitOption.NOTNULL)  // 删除空白字符串
            {
                resultString = resultString.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            }
            return resultString;
        }
    }
}

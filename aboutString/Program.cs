using System;

namespace aboutString
{
    class Program
    {
        static void Main(string[] args)
        {
            // 字符串的一些方法：
            // 1.Length
            string name = "szcc";
            Console.WriteLine(name.Length); // 4

            // 2.IndexOf: 返回指定字符串在原字符串中第一次出现的位置
            Console.WriteLine(name.IndexOf("c")); // 2

            // 3.LastIndexOf: 返回指定字符串在原字符串中最后一次出现的位置
            Console.WriteLine(name.LastIndexOf("c")); // 3

            // 4.StartsWith: 返回布尔值，判断某个字符串是否以指定字符串开头
            Console.WriteLine(name.StartsWith("szc")); // True

            // 5.EndsWith： 返回布尔值，判断某个字符串是否以指定的字符串结尾
            Console.WriteLine(name.EndsWith("zcc")); // True

            // 6.ToLower： 返回一个新的字符串，将原字符串中的大写全部转为小写
            Console.WriteLine("Szc1212CCc".ToLower()); // szc1212ccc

            // 7.ToUpper： 返回一个新的字符串，将字符串中的小写字母全部转为大写
            Console.WriteLine("szccc89*".ToUpper()); // SZCCC89*

            // 8.Trim： 返回一个新的字符串，不带任何参数时表示将原字符串中前后的空格删除。
            // 参数为字符时表示将原字符串中含有的字符数组中的字符删除
            string str = " aaaabbbb ";
            Console.WriteLine(str.Trim()); // aaaabbbb

            // 9.TrimStart： 返回一个新字符串，将字符串左侧空格删除
            Console.WriteLine(str.TrimStart()); // aaaabbbb 

            // 10.TrimEnd： 返回一个新字符串，将字符串中右侧空格删除
            Console.WriteLine(str.TrimEnd()); //  aaaabbbb

            // 11.Remove: 返回一个新的字符串，将字符串中指定位置的字符串移除
            Console.WriteLine(str.Remove(4,2));// 第一个参数index， 第二个参数count(当不传第二个参数时默认remove到结束)

            // 12.PadLeft: 返回一个新的字符串，从字符串左侧填充空格达到指定的字符串查长度
            string padstr = "szc";
            Console.WriteLine(padstr.PadLeft(6)); //    szc(szc前面三个空格)

            // 13.PadRight: 返回一个新的字符串，从字符串的右侧填充空格达到指定的字符串长度
            Console.WriteLine(padstr.PadRight(6)); // szc   （szc后面三个空格）

            // 14.Split: 字符串转数组
            string strArrs = "a,b,v";
            string[] arrs = strArrs.Split(','); // [a, b, v]
            Console.WriteLine(arrs.Length); // 3

            // 15.Replace: 返回一个新的字符串，用于将指定字符串替换给原字符串中指定的字符串
            string rplc = "abcda";
            Console.WriteLine(rplc.Replace('a', 'b')); // bbcdb  第一个参数： 目标字符   第二个参数：待替换参数

            // 16.Substring: 返回一个新的字符串，用于截取指定的字符串
            string sub = "szcisabigpig";
            Console.WriteLine(sub.Substring(1)); // zcisabigpig 只有一个参数时返回从开始位置到字符串结束的字符
            Console.WriteLine(sub.Substring(3, 7)); // isabigp 第二个参数是截取字符串的个数 这里不同于js js的第二个参数是结束位置 但是不包含第二个参数
            
            // 17.Insert: 返回一个新的字符串，将一个字符串插入到另一个字符串中指定索引的位置
            string ist = "szc";
            Console.WriteLine(ist.Insert(1, "is")); // siszc  第一个参数是索引位置，第二个参数是insert的字符串

            // 18.Concat: 返回一个新的字符串，将多个字符串合并成一个字符串
            string cct = "szc";
            Console.WriteLine(string.Concat(cct, "szcccc", "12122")); // szcszcccc12122
        }
    }
}

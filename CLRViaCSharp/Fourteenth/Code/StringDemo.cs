using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourteenth.Code
{
    #region 字符串是不可变的
    /*
     * 1.String对象是不可变的，也就是说，字符串一经创建便不能更改，不能变长，变短，
     *  或修改其中任何字符。
     * 2.使字符串不可变，还意味着在操作或访问一个字符串时不会发生线程同步问题。
     *  CLR可以通过一个String对象共享多个完全一致的String内容，这样能减少系统
     *  中的字符串数量--从而节省内存。
     * 
     * **/
    #endregion

    public class StringDemo
    {
        //'\0'
        public char minValue = char.MinValue;
        //'\ufff'
        public char maxValue = char.MaxValue;

        #region string.Format使用

        public void StringFormat()
        {
            //字符串的数字格式
            //N# 表示格式化成带千分位(,)的字符串，#表示数字，格式化后保留的小数位数
            string str1 = string.Format("{0:N1}", 56789);//result:56,789.0
            string str2 = string.Format("{0:N2}", 56789);//result:56,789.00
            string str3 = string.Format("{0:N3}", 56789);//result:56,789.000
            //F表示定点格式
            string str8 = string.Format("{0:F1}", 56789);//result:56789.0
            string str9 = string.Format("{0:F2}", 56789);//result:56789.00

            string str11 = (56789 / 100.0).ToString("#.##");//result:567.89
            string str12 = (56789 / 100).ToString("#.##");//result:567

            //C# 表示格式化货币，默认保留两位小数，#表示格式化后保留的小数位数
            string str14 = string.Format("{0:C}", 5.369);//result:¥5.37
            string str13 = string.Format("{0:C1}", 5.369);//result:¥5.4

            //格式化十进制的数字(将格式化成固定位数，位数不能少于未格式化前，只支持整型)
            string str15 = string.Format("{0:D3}", 23);//result:023
            string str16 = string.Format("{0:D2}", 1223);//result:1223

            //P 格式化百分比（默认保留两位小数）
            string str17 = string.Format("{0:P}", 0.2456789);//result:24.57%
            string str18 = string.Format("{0:P3}", 0.2456789);//result:24.568%

            //零占位符： 如果格式化的值在格式字符串中出现"0"的位置有一个数字，则此数字被复制到结果字符串中。
            string str19 = string.Format("{0:0000.00}", 12394.039);//result:12394.04
            string str20 = string.Format("{0:0000.00}", 194.039);//result:0194.04

            //数字占位符： 如果格式化字符串中出现"#",则此数字被复制到结果字符串中。否则字符串中此位置不存储任何值。
            string str21 = string.Format("{0:###.##}", 12394.039);//result:12394.04
            string str22 = string.Format("{0:####.#}", 194.039);//result:194
        }
        #endregion

        #region 字符串的留用
        /*
         * 如果在内存中复制同一个字符串的多个实例，会造成内存的浪费，
         * 因为字符串是"不可变"的。如果只在内存中保留字符串的一个实例， 
         * 那么将显著提高内存的利用率。
         * 
         * 如果应用程序经常对字符串进行区分大小写的，序号式的比较，或者】
         * 事先知道许多字符串对象都有相同值，就可以利用CLR字符串留用(string interning)
         * 机制来显著提高性能。
         * 
         * CLR在初始化时会创建一个内部哈希表。在这个表中，key是字符串，value是对托管堆中的
         * string对象的引用。
         * 
         * string提供了连个方法来访问这个内部哈希表：
         * ① Intern(string str):在内部哈希表中检查是否有相匹配的。如果存在一个相匹配的字符串，
         * 就返回这个已经存在的string对象的一个引用。如果不存在完全相同的字符串，就创建字符串的副本，
         * 将副本添加到内部哈希表中，并返回对这个副本的一个引用。如果应用程序不在保持对原始string对象的
         * 一个引用，垃圾回收器就可以释放那个字符串的内存。
         * ②IsInterned(string str):也获取一个string并在内部哈希表中查找它，如果哈希表中有一个匹配的字符串
         * 就返回对这个字符串的引用。如果哈希表中没有一个匹配的字符串，IsIntern额度会返回null，它不会将字符串
         * 添加到哈希表中。
         * **/
        /// <summary>
        /// 字符串留用
        /// </summary>
        public void StringIntern()
        {
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(object.ReferenceEquals(s1, s2));//False  在.net 4.0以上版本会显示True，CLR选择忽视C# 编译器生成的attribute/flag标志

            s1 = string.Intern(s1);
            s2 = string.Intern(s2);
            Console.WriteLine(object.ReferenceEquals(s1, s2));//True

        }
        #endregion

        #region string内存分配
        public void DistributionMemory()
        {
            //变量a 一共进行了两次内存分配
            //①在堆中分配内存
            //②由于字符串留用，CLR会在内部哈希表中，存储字符串及对字符串地址的引用，再分配一次内存。
            //所以一共分配两次内存
            string a = "hello world";
            Console.WriteLine(a);

            //变量b 一共进行了两次内存分配
            //为什么是两次呢？？
            //因为C#编译器对这段代码进行了优化
            //在所有字符串都是文本常量字符串时，编译器会在编译时将它们连接成一个字符串。
            string b = "hello" + "world";
            Console.WriteLine(b);
        }
        #endregion


    }

}

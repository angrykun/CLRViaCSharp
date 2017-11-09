using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fourteenth.Code;

namespace Fourteenth
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //MethodOne();
            //MethodFour();
            MethodFive();
            Console.ReadKey();
        }

        private static void MethodOne()
        {
            StringDemo demo = new StringDemo();
            Console.WriteLine($"minValue={demo.minValue},maxValue={demo.maxValue}");
        }

        private static void MethodTwo()
        {
            char d;
            int c;
            d = ((IConvertible)65).ToChar(null);
        }

        /// <summary>
        /// 字符串格式
        /// </summary>
        private static void MethodThree()
        {
            new StringDemo().StringFormat();
        }

        /// <summary>
        /// 字符串留用
        /// </summary>
        private static void MethodFour()
        {
            new StringDemo().StringIntern();
        }

        /// <summary>
        /// 字节数组和字符转换
        /// </summary>
        private static void MethodFive()
        {
            new StringDemo().CharsChangeToUnicode();
        }
    }
}
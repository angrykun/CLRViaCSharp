using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fourteenth.Code;

namespace Fourteenth
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodOne();

            MethodFour();

            Console.ReadKey();
        }
        static void MethodOne()
        {
            StringDemo demo = new StringDemo();
            Console.WriteLine($"minValue={demo.minValue},maxValue={demo.maxValue}");
        }
        static void MethodTwo()
        {
            char d;
            int c;
            d = ((IConvertible)65).ToChar(null);
        }

        /// <summary>
        /// 字符串格式
        /// </summary>
        static void MethodThree()
        {
            new StringDemo().StringFormat();
        }

        /// <summary>
        /// 字符串留用
        /// </summary>
        static void MethodFour()
        {
            new StringDemo().StringIntern();
        }
    }
}

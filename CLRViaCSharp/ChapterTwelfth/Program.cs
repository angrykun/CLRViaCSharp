using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterTwelfth.Code;

namespace ChapterTwelfth
{
    class Program
    {
        static void Main(string[] args)
        {

            MethodOne();
            Console.ReadKey();
        }
        /// <summary>
        /// ArrayList 和List性能测试
        /// </summary>
        static void MethodOne()
        {
            new ListCompareToArrayList().ValueTypePerfTest();
        }
    }
}

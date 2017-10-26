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

            //MethodOne();

            MethodTwo();
            Console.ReadKey();
        }
        /// <summary>
        /// ArrayList 和List性能测试
        /// </summary>
        static void MethodOne()
        {
            new ListCompareToArrayList().ValueTypePerfTest();
        }

        static void MethodTwo()
        {
            Node head = new NodeType<char>(',');

            head = new NodeType<DateTime>(DateTime.Now,head);
            head = new NodeType<string>("Today is ",head);
          Console.WriteLine(  head.ToString());
        }
    }
}

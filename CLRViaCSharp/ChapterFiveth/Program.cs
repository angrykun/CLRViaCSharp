using ChapterFiveth.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFiveth
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOne();
        }
        private static void MethodOne()
        {
            new EnumCode().EnumMethod();
            Console.ReadKey();
        }
    }
}

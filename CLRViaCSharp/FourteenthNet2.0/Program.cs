using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenthNet2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string s11 = "abc";
            Console.WriteLine(string.IsInterned(s11) ?? "null");
            string s22 = "a";
            Console.WriteLine(string.Intern(s22) ?? "null");
        }
    }
}

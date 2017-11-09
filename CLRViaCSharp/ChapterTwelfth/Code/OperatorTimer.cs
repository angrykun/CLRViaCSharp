using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwelfth.Code
{
    /// <summary>
    /// 运算性能时 计时
    /// </summary>
    internal sealed class OperatorTimer : IDisposable
    {
        private long m_startTime;
        private string m_text;
        private int m_CollectionCount;

        public OperatorTimer(string text)
        {
            PrepareForOperation();
            m_text = text;
            m_CollectionCount = GC.CollectionCount(0);

            //这应该是方法的最后一个语句，从而最大程度保证计时的准确性
            m_startTime = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            Console.WriteLine("{0,6:###.00} seconds (GCs={1,3}) {2}", (Stopwatch.GetTimestamp() - m_startTime) / (double)Stopwatch.Frequency, GC.CollectionCount(0) - m_CollectionCount, m_text);
        }
        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}

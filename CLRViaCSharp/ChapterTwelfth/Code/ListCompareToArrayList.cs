using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwelfth.Code
{
    /// <summary>
    /// ArrayList 和List性能测试
    /// </summary>
    public class ListCompareToArrayList
    {
        public void ValueTypePerfTest()
        {
            const int count = 10000000;
            //List 值类型
            using (new OperatorTimer("List<int>"))
            {
                List<int> l = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    l.Add(i);
                    int x = l[i];
                }
                l = null;//确保进行垃圾回收
            }

            //ArrayList 值类型
            using (new OperatorTimer("ArrayList<int>"))
            {
                ArrayList l = new ArrayList();
                for (int i = 0; i < count; i++)
                {
                    l.Add(i);
                    int x = (int)l[i];
                }
                l = null;//确保进行垃圾回收
            }
            //List 引用类型
            using (new OperatorTimer("List<string>"))
            {
                List<string> l = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    l.Add("X");
                    string x = l[i];
                }
                l = null;//确保进行垃圾回收
            }


            //ArrayList 引用类型
            using (new OperatorTimer("ArrayList<string>"))
            {
                ArrayList l = new ArrayList();
                for (int i = 0; i < count; i++)
                {
                    l.Add("X");
                    string x = (string)l[i];
                }
                l = null;//确保进行垃圾回收
            }
        }
    }
}

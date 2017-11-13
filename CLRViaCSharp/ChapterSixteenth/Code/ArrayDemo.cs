using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixteenth.Code
{
    /// <summary>
    /// 数组
    /// </summary>
    public class ArrayDemo
    {
        #region 数组 定义
        /*
         * 数组是允许多个数据项作为集合来处理的机制。
         * 所有数字都隐式派生自System.Array抽象类，
         * System.Array 又派生自System.Object 所以数组
         * 是引用类型。
         * 
         * **/
        #endregion
        public void ArrayMethod()
        {
            //一维数组
            int[] myIntegers = new int[100];

            //多维数组
            double[,] myDoubles = new double[10, 20];

            //初始化数组  数组初始化器
            string[] names = new string[] { "Aidan", "Grant" };
            //隐式类型局部变量
            var names2 = new string[] { "Aidan", "Grant" };
            //C#隐式类型的局部变量和隐式类型的数组
            var names3 = new[] { "Aidan", "Grant" };
        }
    }
}

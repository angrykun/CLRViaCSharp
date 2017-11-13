using System;
using System.Collections.Generic;
using System.Diagnostics;
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
         * CLR内部支持两种不同的数组：
         * ① 下限为0的一维数组。这些数组有时成为SZ数组或向量。
         * ② 下限未知的一维或多维数组。
         * **/
        #endregion
        public void ArrayMethod()
        {
            #region 数组声明
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

            #endregion

            #region 动态创建数组
            //动态创建数组
            int[] lowerBounds = { 2005, 1 };
            //每维 数组长度
            int[] lengths = { 5, 4 };
            //动态创建数组
            decimal[,] quarterlyRevenue = (decimal[,])Array.CreateInstance(typeof(decimal), lengths, lowerBounds);
            #endregion


        }

        #region MyRegion
        const int c_numElements = 100000;
        public void RankArrayMethod()
        {

            const int testCount = 10;
            Stopwatch sw;
            int[,] a2Dim = new int[c_numElements, c_numElements];

            //将一个二维数组声明为交错数组
            int[][] aJagged = new int[c_numElements][];
            for (int x = 0; x < c_numElements; x++)
            {
                aJagged[x] = new int[c_numElements];
            }

            //1.用普通安全技术访问数组中所有元素
            sw = Stopwatch.StartNew();
            for (int test = 0; test < testCount; test++)
            {
                Safe2DimArrayAccess(a2Dim);
            }
            Console.WriteLine("{0}:Safe2DimArrayAccess",sw.Elapsed);
            //2.用交错技术访问数组中所有元素
            sw = Stopwatch.StartNew();
            for (int test = 0; test < testCount; test++)
            {
                SafeJaggedArrayAccess(aJagged);
            }
            Console.WriteLine("{0}:SafeJaggedArrayAccess", sw.Elapsed);
        }

        private int Safe2DimArrayAccess(int[,] a)
        {
            int sum = 0;
            for (int x = 0; x < c_numElements; x++)
            {
                for (int y = 0; y < c_numElements; y++)
                {
                    sum += a[x, y];
                }
            }
            return sum;
        }
        private int SafeJaggedArrayAccess(int[][] a)
        {
            int sum = 0;
            for (int x = 0; x < c_numElements; x++)
            {
                for (int y = 0; y < c_numElements; y++)
                {
                    sum += a[x][y];
                }
            }
            return sum;
        }

        //private unsafe int Unsafe2DimArrayAccess(int[,] a)
        //{
        //    int sum = 0;
        //    fixed (int* pi = a)
        //    {
        //        for (int x = 0; x < c_numElements; x++)
        //        {
        //            int baseOfDim = x * c_numElements;
        //            for (int y = 0; y < c_numElements; y++)
        //            {
        //                sum += pi[baseOfDim + y];
        //            }
        //        }
        //    }
        //    return sum;
        //}
        #endregion
    }
}

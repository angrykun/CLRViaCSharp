using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwelfth.Code
{

    #region 定义泛型委托
    /// <summary>
    /// 定义泛型委托
    /// </summary>
    /// <typeparam name="TReturn"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public delegate TReturn CallMe<TReturn, TKey, TValue>(TKey key, TValue value);

    #endregion

    #region 委托和接口的逆变和协变泛型类型实参
    /**
     * 委托的每个泛型类型参数都可以标记为协变量或逆变量。
     * 不变量：泛型类型参数不能更改
     * 逆变量：泛型类型参数可以从一个基类更改为该类的派生类。用in关键字标记逆变量，逆变量只出现在输入位置。
     * 协变量：泛型类型参数可以从一个派生类更改为它的基类。用out关键字标记协变量，协变量只能出现在输出位置。
     */
    public delegate TResult FuncDele<in T, out TResult>(T arg);
    #endregion



    public class GeneicDelegate
    {
        public void MethodOne()
        {
            //声明一个变量
            FuncDele<object, ArgumentException> fn1 = null;
            //可以将fn1转型为另一个泛型类型参数不同的FuncDele类型
            FuncDele<string, Exception> fn2 = fn1;  //这里不需要显示转型
            Exception e = fn2("");
        }

        #region 泛型方法
        /**
         * 定义泛型类、结构或接口时，这些类型中定义的任何方法都可引用由类型指定的一个类型参数。
         * 类型参数可以作为方法的参数，方法的返回值，局部变量来使用，然而，CLR 还允许一个方法
         * 指定它独有的类型参数，这些类型参数可以用于参数，返回值或者局部变量。
         * */
        public void Swap<T>(ref T o1, ref T o2)
        {
            T temp = o1;
            o1 = o2;
            o2 = temp;
        }
        #endregion

        #region 泛型类型约束
        /**
         * 1.编译器和CLR支持约束机制，可以限制指定的泛型实参的类型。 
         * 2.指定一个引用类型约束时，相当于向编译器承诺：一个指定的
         *  类型实参要么是与约束类型相同的类型，要么是派生自约束类型
         *  的派生类。
         *  3.一个类型默认约束类型是：Object，但是如果显示指定类型的
         *  约束类型为System.Object 则会编译报错，因为不能指定约束类型
         *  为特殊类。
         *  4.类型参数约束：它允许一个泛型类型或方法规定，在指定的类型
         *  实参之间，必须存在一个关系。一个类型参数可以指定0个或多个类型参数约束。
         *  5.构造器约束：指定构造器约束相当于向编译器承诺：一个指定的类型实参
         *  是实现了公共无参构造器的一个非抽象类型。
         *  
         *  6.将一个泛型类型变量设为默认值，C#编译器允许使用default关键字
         *  来实现这个操作。
         *  T temp=default(T);
         *  default关键字 告诉C#编译器和CLR的JIT编译器，如果T是一个引用类型就将temp设为null；
         *  如果T是一个值类型 ，就将temp的所有位设为0。
         *  
         * **/

        public T Min<T>(T o1, T o2) where T : IComparable<T>
        {
            if (o1.CompareTo(o2) < 0) return o1;
            return o2;
        }

        /// <summary>
        /// class 约束 (主要约束)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public void MethodTwo<T>(T obj) where T : class
        {
            obj = null;
        }

        /// <summary>
        /// struct 约束 (主要约束)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public T MethodThree<T>(T value) where T : struct
        {
            //所有值类型都隐式的有一个无参构造函数
            return new T();
        }

        /// <summary>
        /// 类型参数约束 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TBase"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<TBase> ConvertList<T, TBase>(IList<T> list) where T : TBase
        {
            List<TBase> list_return = new List<TBase>();

            return list_return;
        }

        /// <summary>
        /// 构造函数约束(目前CLR及C#编译器 只支持无参构造函数约束，Microsoft认为这已经满足所有情况了)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T Factory<T>(T obj) where T : new()
        {
            //所有值类型 都有一个默认的无参构造函数
            //要求引用类型要有一个无参构造函数
            return new T();
        }
        #endregion
    }
}

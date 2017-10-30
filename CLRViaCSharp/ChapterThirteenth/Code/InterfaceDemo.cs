using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThirteenth.Code
{

    #region 类和接口的继承
    /**
     * 1.类继承的一个重要特点：凡是能使用基类实例的地方，都可以
     * 使用派生类的实例。
     * 2.接口继承一个重要特点：凡是能使用具名接口类型实例的地方，
     * 都可以使用实现了接口的一个类型的实例。
     * 3.接口实际上只是对一组方法签名进行统一的命名。这些方法没有
     * 提供任何实现。
     * */
    #endregion

    #region 隐式接口和显示接口
    /*
     * 1.C#中将定义方法的那个接口名称作为方法名的前缀，
     * 建的就是一个显示接口方法实现。在定义一个显示接口(EIMI)
     * 方法时，不允许指定可访问性，编译器自动将访问性设置为Private。
     * 2.泛型接口好处：
     *  ①提供了出色的编译时类型安全性；
     *  ②处理值类型时，装箱次数少的多；
     *  ③类可以实现一个接口若干次，只要每次使用不同的类型参数。
     * 3.将泛型类型参数约束为接口时的好处：
     *  ①可将一个泛型类型参数约束为多个接口；
     *  ②传递值类型参数时，可以减少装箱操作；
     * 
     * **/

    #endregion
    public class InterfaceDemo
    {
        Comparer
            
    }

    public interface ICompare
    {

    }
}

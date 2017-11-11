using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFiveth.Code
{
    /// <summary>
    /// 枚举类型和标志位
    /// </summary>
    public class EnumCode
    {
        #region 枚举类型 
        /*
         * 枚举类型:定义了一组“符号名称/值”配对 .
         * 枚举类型优点：
         * ①使用枚举类型使程序更容易编写，阅读和维护。
         * ②枚举类型是强类型。例如将Color.Orange作为参数
         * 传递给要求Fruit枚举类型的方法，编译器会报错。
         * **/
        internal enum Color:byte
        {
            White,
            Red,
            Green,
            Bule,
            Orange
        }
        public void EnumMethod()
        {
            //返回容纳一个枚举类型值的基元类型
            Type type = Enum.GetUnderlyingType(typeof(Color));
            Console.WriteLine(type);//"System.Byte"

            //Enum.Formar 格式化枚举类型值
            Console.WriteLine(Enum.Format(typeof(Color),(byte)2,"G"));     //Blue

            // Bule
            Color c = (Color)Enum.Parse(typeof(Color), "Bule", true);
            //由于Color中没有定义Brown 所以会抛出 ArgumentException
            //Color c2 = (Color)Enum.Parse(typeof(Color),"Brown",false);

            Color c3;
            Enum.TryParse<Color>("2", out c3);
            Enum.TryParse<Color>("Red", out c3);
            Enum.TryParse<Color>("23", out c3);

            #region Enum.IsDefined 方法判断枚举类型是否合法
            //Enum.IsDefined()方法可以判断数值对于某个枚举类型是否合法。
            //返回True  因为Color将Red定义为1
            Console.WriteLine(Enum.IsDefined(typeof(Color), 1));
            //返回True 因为Color将White定义为0
            Console.WriteLine(Enum.IsDefined(typeof(Color), "White"));

            //返回False  因为Color没有定义white
            Console.WriteLine(Enum.IsDefined(typeof(Color), "white"));
            //返回False   因为Color中没有和10 对应的符号
            Console.WriteLine(Enum.IsDefined(typeof(Color), "10")); 
            #endregion

        }
        #endregion
    }
}

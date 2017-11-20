using System;
using System.Collections.Generic;
using System.Text;

namespace FourteenthNet2._0
{
    [System.Runtime.InteropServices.Guid("70C495FC-997C-45C5-B4A6-354DEA307B53")]
    class Program
    {
        static void Main(string[] args)
        {
            List<TestClass> tests = new List<TestClass> {
            new TestClass {   Age=1,Name="A"}  ,

               new TestClass {   Age=1,Name="A"}  ,
                new TestClass {   Age=1,Name="A"}  ,
                 new TestClass {   Age=1,Name="A"}  ,
                  new TestClass {   Age=1,Name="A"}  ,
                   new TestClass {   Age=1,Name="A"}  ,
                    new TestClass {   Age=1,Name="A"}  ,
                     new TestClass {   Age=1,Name="A"}  ,
                new TestClass {   Age=1,Name="A"}  ,

            };
            foreach (var item in tests)
            {
                item.Name = "B";

            }
            tests.ForEach(item => Console.WriteLine("Name={0},Age={1}", item.Name, item.Age));


        }

        class TestClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

    }
}


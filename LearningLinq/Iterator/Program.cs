using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// http://www.cnblogs.com/gc2013/p/4055925.html
    /// </summary>
    class Program
    {
        /// <summary>
        /// 1、yield return能返回一个"按需供给"的集合 
        /// 2、yield return是"语法糖"，其背后是一个实现了IEnuerable,IEnumerator泛型、非泛型接口的类，该类维护着一个状态字段，以保证yield return产生的集合能"按需供给" 
        /// 3、yield break配合yield return使用，当产生集合达到某种条件的时候使用yield break，以终止继续创建集合
        /// </summary>
        static void Main(string[] args)
        {
            //凡是返回IEnumerable<T>接口都可以使用foreach();
            //1.
            new MyIteratorCode().Call();
            //2.
            foreach (var item in MyIterator())
            {
                Console.WriteLine(item);
            }

            //一个实际场景；
            //。。。
            Console.ReadLine();
        }

        static IEnumerable<int> MyIterator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        class MyIteratorCode
        {
            public void Call()
            {
                foreach (var item in MyIterator())
                {
                    Console.WriteLine(item);
                }
            }

            IEnumerable<int> MyIterator()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }
        }

    }
}

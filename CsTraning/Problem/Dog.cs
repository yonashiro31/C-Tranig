using System;
using System.Collections.Generic;
using System.Text;

namespace CsTraning.Problem
{
    /// <summary>
    /// 練習用サンプルクラス
    /// </summary>
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string breeds { set;get }
        public void ShowProfile()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(breeds);
        }
    }
}

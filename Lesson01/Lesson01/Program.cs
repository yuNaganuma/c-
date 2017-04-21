using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Program
    {
        /// <summary>
        /// 1から100までの整数のうち、3の倍数と3がつく値を出力するプログラムを作成してください。
        /// </summary>
        /// <param name="args">実行引数</param>
        static void Main(string[] args)
        {

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}

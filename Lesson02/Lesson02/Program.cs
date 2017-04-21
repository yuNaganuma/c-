using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        /// <summary>
        /// 配列dataを逐次決定法で昇順にソートして結果を出力するプログラムを作成してください。
        /// </summary>
        /// <param name="args">実行引数</param>
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 100回ランダム入れ替え
            for (int i = 0; i < 100; i++)
            {

                System.Random rng1 = new System.Random();
                int k = rng1.Next(10);
                System.Threading.Thread.Sleep(10);
                int n = rng1.Next(10);
                if (k != n)
                {
                    int tmp = data[k];
                    data[k] = data[n];
                    data[n] = tmp;

                    // for (int j = 0; j < 10; j++)
                    // {
                    //     Console.Write(data[j] + " ");
                    // }
                    // Console.WriteLine();
                }
            }

            // 逐次決定法ここから
            for (int i = 0; i < data.Length - 1; i++)
            {
                int min = i;

                // 配列のi番目から末尾までで最少の値を探す
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[min] > data[j])
                    {
                        min = j;
                    }
                }


                //入れ替え
                if (i != min)
                {
                    int tmp = data[i];
                    data[i] = data[min];
                    data[min] = tmp;

                    string space = "";
                    for (int j = 0; j < data.Length; j++)
                    {
                        Console.Write(space + data[j]);
                        space = " ";
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    class Program
    {
        /// <summary>
        /// 配列dataを隣接交換法で昇順にソートして結果を出力するプログラムを作成してください。
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

            // 隣接交換法ここから
            for (int i = data.Length - 1; i >= 0; --i)
            {
                // ソート済みフラグ
                Boolean sorted = true;

                for (int j = 0; j < i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        //入れ替え
                        int tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;

                        sorted = false;
                    }
                }

                // ソート済みであれば終了
                if (sorted)
                {
                    break;
                }

                //コンソール出力
                string space = "";
                for (int k = 0; k < data.Length; k++)
                {
                    Console.Write(space + data[k]);
                    space = " ";
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}

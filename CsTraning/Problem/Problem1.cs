using System;

namespace CsTraning.Problem
{
    /// <summary>
    /// C#練習問題　（http://kitako.tokyo/lib/CsExercise.aspx）
    /// </summary>
    class Problem6
    {
        // 整数の 2 乗を計算するメソッドを作成しなさい。１つの int 型引数を取り、結果を int 型の戻り値として返すこと。
        public int Problem6_1(int value)
        {
            var result = value * value;
            return result;
        }

        // ２つの整数の平均を計算するメソッドを作成しなさい。２つの int 型引数を取り、結果を int 型の戻り値として返すこと。
        public int Problem6_2(int firstValue, int secondValue)
        {
            var result = (firstValue + secondValue) / 2;
            return result;
        }

        // ２つの整数の大きい方を選ぶメソッドを作成しなさい。２つの int 型引数を取り、大きい方の数値を戻り値として返すこと。
        public int Problem6_3(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            };
            return secondValue;
        }

        // サイズを示す数値（ int 型）を引数とし、何等かの文字で例のような三角形を表示するメソッドを作成しなさい。
        public void Problem6_4(int value)
        {
            var triangle = "$";
            for (var count = 0; value > count; count++)
            {
                if (value > count)
                {
                    for (var count2 = 0; count2 <= count ; count2++)
                    {
                        Console.Write(triangle);

                    }
                }
                Console.WriteLine();
            }
        }

        // サイズを示す数値と、表示する文字を引数とし、三角形を表示するメソッドを作成しなさい。
        public void Problem6_5(int value,string str)
        {
            var triangle = str;
            for (var count = 0; value > count; count++)
            {
                if (value > count)
                {
                    for (var count2 = 0; count2 <= count; count2++)
                    {
                        Console.Write(triangle);

                    }
                }
                Console.WriteLine();
            }
        }
        // 九九のひとつの段を表示するメソッドを作成しなさい。何の段（ 1 ～ 9 ）であるかを引数とします。
        public void Problem6_6(int value)
        {
            for (int count = 1; count <= 9; count++) {
                var result = value * count;
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }
        // ある数が素数かどうかを判定するメソッドを作成しなさい。
        public bool Problem6_7(int value)
        {
            // 1000未満を受け付ける
            if (value > 1000) return false;

            for (int n = 2; n * n <= value; n++)
			{
                if (value % n == 0)
                {
                    return false;
                }
			}
            return true;
        }
    }
}

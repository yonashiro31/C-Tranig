using System;
using System.Collections.Generic;
using System.Text;

namespace CsTraning.Problem
{
    // 硬貨の入れ物のようなクラス、CoinCase を作成しなさい。 http://kitako.tokyo/lib/CsExercise.aspx?id=7
    class CoinCase
    {
        public int Yen500 { get; set; }
        public int Yen100 { get; set; }
        public int Yen50 { get; set; }
        public int Yen10 { get; set; }
        public int Yen5 { get; set; }
        public int Yen1 { get; set; }
        public void AddCoins(int kind, int count)
        {
            switch (kind)
            {
                case 500:
                    Yen500 += count;
                    break;
                case 100:
                    Yen100 += count;
                    break;
                case 50:
                    Yen50 += count;
                    break;
                case 10:
                    Yen10 += count;
                    break;
                case 5:
                    Yen5 += count;
                    break;
                case 1:
                    Yen1 += count;
                    break;
            }
        }
        public int GetCoins(int kind)
        {
            switch (kind)
            {
                case 500:
                    return Yen500;
                case 100:
                    return Yen100;
                case 50:
                    return Yen50;
                case 10:
                    return Yen10;
                case 5:
                    return Yen5;
                case 1:
                    return Yen1;
                default:
                    return 0;
            }
        }

        public int GetCoins()
        {
            return Yen1 + Yen5 + Yen10 + Yen50 + Yen100 + Yen500;
        }

        public int GetAmount()
        {
            var sum1 = 1 * Yen1;
            var sum5 = 5 * Yen5;
            var sum10 = 10 * Yen10;
            var sum50 = 50 * Yen50;
            var sum100 = 100 * Yen100;
            var sum500 = 500 * Yen500;
            return sum1 + sum5 + sum10 + sum50 + sum100 + sum500;
        }

        public int GetAmount(int kind)
        {
            switch (kind)
            {
                case 500:
                    return 500 * Yen500;
                case 100:
                    return 100 * Yen100;
                case 50:
                    return 50 * Yen50;
                case 10:
                    return 10 * Yen10;
                case 5:
                    return 5 * Yen5;
                case 1:
                    return 1 * Yen1;
                default:
                    return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CsTraning.Problem
{
    //* 練習問題7-1～4まで　以下の Dog クラスを使用して、次のプログラムを作成しなさい。http://kitako.tokyo/lib/CsExercise.aspx?id=7
    class Problem2
    {
        //  Dog クラスのインスタンスを作成する。Name プロパティで名前を設定する。ShowProfile メソッドで名前を表示する。
        public Problem2()
        {
            var dog = new Dog();
            var dog2 = new Dog();

            dog.Name = "名前1";
            dog.Age = 1;
            dog.breeds = "ポメラニアン";

            dog2.Name = "名前2";
            dog2.Age = 2;
            dog2.breeds = "ハスキー";

            dog.ShowProfile();
            dog2.ShowProfile();
        }
    }
}


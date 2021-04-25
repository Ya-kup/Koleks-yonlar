using System;
using System.Collections.Generic;
using System.Text;

namespace Koleksıyonlar
{
    class MyList<T>
    {
        T[] elemanlar;
        public MyList()
        {
            elemanlar = new T[0];
        }

        public void Add(T eleman)
        {
            T[] tempArray = elemanlar;
            elemanlar = new T[elemanlar.Length + 1];
            for (int i = 0; i < tempArray.Length  ; i++)
            {
                elemanlar[i] = tempArray[i];
            }
            elemanlar[elemanlar.Length - 1] = eleman;
        }

    }
}

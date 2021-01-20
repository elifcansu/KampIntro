using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //BANA BİR TİP VER AŞAĞIYI ONA GÖRE YAPILANDIRICAM
    {
        T[] items;
        //constructor
        public MyList()//classı newlersek otomatik çalışıyor.
        {
            items = new T[0]; //Arrayi  0 elemanlı olarak oluşturduk
        }

        public void Add(T item) //generic tip demek sen o an hangi tipi vericeksen o olur.
        {
            T[] tempArray = items;//geçici dizinin referansı itemın referansı oldu.Aklında tuttu gibi düşün.aşağıda newlendiğinde önceki değerler silinmesin diye yaptık.
            items = new T[items.Length+1];//eleman sayısını 1 arrttırdık
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //items eski değerlerine kavuştu.
            }

            items[items.Length - 1] = item; //son index uzunluğun 1 eksiği olur.
        }
    }
}

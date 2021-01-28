using System;

namespace DictionaryExample
{
    class MyDictionary<T, E>
    {
        T[] _arrNumber;
      //  E[] _arrValue; // tanımlamasına gerek olmadan da çalıştı.
        

        public MyDictionary()
        {
            _arrNumber = new T[0];
            //_arrValue = new E[0];
        }

        public void Added(T item1, E item2)
        {
            T[] _tempNumber = _arrNumber;
           // E[] _tempValue = _arrValue;

            //_arrNumber = new T[_arrNumber.Length + 1]; // Eleman sayısını göstermek istersek yorum satırından çıkarabiliriz. 
            //_arrValue = new E[_arrValue.Length + 1];

            for (int i = 0; i < _tempNumber.Length; i++)
            {

                _arrNumber[i] = _tempNumber[i];
                _arrNumber[_arrNumber.Length - 1] = item1;

            }
           Console.WriteLine(item1+" No'lu kullanıcı " + item2);
          }
    }
}

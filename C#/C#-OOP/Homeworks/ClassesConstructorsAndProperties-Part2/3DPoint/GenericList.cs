using System;
using System.Collections.Generic;

namespace ThreeDPoint
{
    public class GenericList<T>
    {
        public static int capacitet;
        private int adding = 0;
        public GenericList(int value)
        {
            capacitet = value;
        }
        public static List<T> elements = new List<T>();

        public static T[] arrOfList = new T[capacitet];

        public void Add(T value)
        {
            arrOfList[adding] = value;
        }

        public T GetValue(int index)
        {
            return arrOfList[index];
        }

        public void RemoveELement(int index)
        {
          //
        }

        public void CleanList()
        {
            elements.Clear();
        }

        public void GetIndex(T value)
        {
            //
        }

        public override string ToString()
        {
            return "nothing";
        }


        public T Min<T>(T element1, T element2)
        {
            
            return element1;
        }

        public static bool operator >(T element, T element2)
        {

        }

        public static bool operator <(T element, T element2)
        {

        }
    }

   
}

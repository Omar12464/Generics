using System;
using System.Collections;

namespace Generics1
{
    internal class Program
    {
        public static void Reverse(ArrayList arrayList)
        {
            if (arrayList == null || arrayList.Count == 0)
            {
                Console.WriteLine("ArrayList is null or empty");
                return;
            }

            int temp;
            int start = 0;
            int end = arrayList.Count - 1;

            while (start < end)
            {
                temp = (int)arrayList[start];
                arrayList[start] = arrayList[end];
                arrayList[end] = temp;

                start++;
                end--;
            }
        }

        static void Main(string[] args)
        {
            #region Q1
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            array.Add(6);

            Reverse(array);

            foreach (var number in array)
            {
                Console.Write($"{number} ");
            } 
            #endregion
        }
    }
}

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
            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add(2);
            //array.Add(3);
            //array.Add(4);
            //array.Add(5);
            //array.Add(6);

            //Reverse(array);

            //foreach (var number in array)
            //{
            //    Console.Write($"{number} ");
            //}
            #endregion
            #region Q2
            //List<int> List = new List<int>();
            //List<int> list= new List<int>();
            //List.Add(1);
            //List.Add(2);
            //List.Add(3);
            //List.Add(4);
            //List.Add(5);
            //List.Add(6);
            //List.Add(7);
            //List.Add(8);
            //for (int i = 0; i < List.Count; i++)
            //{
            //    if (List[i] % 2 == 0)
            //    {
            //        int even=(int)List[i];
            //        list.Add(even);
            //    }
            //}
            //foreach(var num in list)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
        }
    }
}

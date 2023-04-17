using System;
using System.Collections;
using System.Text;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("size of arry list");
            //creat 
            int a = int.Parse(Console.ReadLine());
           ArrayList arrayList = new ArrayList(a);


            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter");

                var b = Console.ReadLine();
                arrayList.Add(b);
            }

            //retrive
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("enter value wich u want to change ");
            var find = Console.ReadLine();
            Console.WriteLine("enter new value u want");

            var update = Console.ReadLine();

            for (int i = 0; i < arrayList.Count; i++)
            {
                var iteme = arrayList[i];

                if (find.Contains((string)iteme))
                {
                    // arrayList.RemoveAt(i);
                    arrayList[i] = update;
                    break;

                }

            }
            //    arrayList[2] = update;

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);

            }


        }
    }
}

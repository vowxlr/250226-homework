using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _260224_аисд_дз
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1");

            Console.WriteLine("Сколько массивов хотите: ");
            int k = IsInt();
            int[][] arrnum1 = new int[k][];

            for(int i = 0; i < k; i++)
            {
                //метод, создающий массив
                int cnt = 0; //длина созданного массива
                arrnum1[i][cnt] = 0; //передпем созданный массив
            }

            //------------------------
            Console.WriteLine("#2");
            Console.WriteLine("Напишите числа через пробел: ");
            string[] arrnum2 = IsIntArr();
            Array.Sort(arrnum2);
            Array.Reverse(arrnum2);

            foreach (var i in arrnum2)
            {
                Console.WriteLine(i);
            }

            string s = "";
            for (int i = 0; i < arrnum2.Length;i++)
            {
                s += arrnum2[i];
            }
            Console.WriteLine($"Ответ: {s}");

        }
        static int IsInt()
        {
            while(true)
            {
                string n = Console.ReadLine().Trim();
                if(int.TryParse(n, out int newn))
                {
                    return newn;
                }
            }
        }
        static string[] IsIntArr()
        {
            while(true)
            {
                string[] n = Console.ReadLine().Trim().Split();
                int[] arr = new int[n.Length];
                bool flag = true;
                for(int i = 0; i < n.Length; i++)
                {
                    if(!int.TryParse(n[i], out int newn))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    return n;
                }
            }
        }
    }
}

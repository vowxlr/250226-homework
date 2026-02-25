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
                int[] arr = CreateArray();
                Array.Sort(arr);
                int cnt = arr.Length;
                arrnum1[i] = arr;
            }
            int cnt2 = 0;
            for (int i = 0; i < arrnum1.Length; i++)
            {
                cnt2 += arrnum1[i].Length;
            }

            int[] arrnum1full = new int[cnt2];
            int ind = 0;
            for (int i = 0; i < arrnum1.Length; i++)
            {
                for (int j = 0; j < arrnum1[i].Length; j++)
                {
                    arrnum1full[ind] = arrnum1[i][j];
                    ind++;
                }
            }
            arrnum1full = BubbleSort(arrnum1full);

            foreach(var j in arrnum1full)
            {
                Console.WriteLine(j);
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
        static int[] BubbleSort(int [] arrnum1full)
        {
            int temp = 0;
            for (int i = 0; i < arrnum1full.Length - 1; i++)
            {
                for (int j = 0; j < arrnum1full.Length - i - 1; j++)
                {
                    if (arrnum1full[j] > arrnum1full[j + 1])
                    {
                        temp = arrnum1full[j];
                        arrnum1full[j] = arrnum1full[j + 1];
                        arrnum1full[j + 1] = temp;
                    }
                }
            }
            return arrnum1full;
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
        static int[] CreateArray()
        {
            while(true)
            {
                Console.WriteLine("Введите числа через пробел: ");
                string[] n = Console.ReadLine().Trim().Split();
                bool flag = true;
                foreach (string s in n)
                {
                    if (!int.TryParse(s, out int newn))
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    int[] arr = new int[n.Length];
                    for(int i = 0;i < n.Length;i++)
                    {
                        arr[i] = int.Parse(n[i]);
                    }
                    return arr;
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

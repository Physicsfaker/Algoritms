using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "fasion is my profession";
            //Console.WriteLine(str);
            //Console.WriteLine(Revers(str));


            //int fact = 5;
            //Console.WriteLine("\n" + fact);
            //Console.WriteLine(Factorial(fact) + "\n");


            //int[] binArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //for (int i = 0; i < binArr.Length; i++)
            //{
            //    Console.Write(binArr[i] + " ");
            //}
            //BSearch(binArr, 8);
            //LSearch(binArr, 10);
            //LSearch(binArr, 15);


            //Console.WriteLine();
            //int[] ssArr = { 21, 54, 45, 4, 56, 45, 87, 98, 78, 1, 4, 3, 2, 6, 7, 5 };
            //for (int i = 0; i < ssArr.Length; i++)
            //{
            //    Console.Write(ssArr[i] + " ");
            //}
            //SelectSort(ssArr);
            //Console.WriteLine();
            //for (int i = 0; i < ssArr.Length; i++)
            //{
            //    Console.Write(ssArr[i] + " ");
            //}

            //Console.WriteLine("\n");
            //int[] inArr = { 21, 54, 45, 4, 56, 45, 87, 98, 78, 1, 4, 3, 2, 6, 7, 5 };
            //for (int i = 0; i < inArr.Length; i++)
            //{
            //    Console.Write(inArr[i] + " ");
            //}
            //InsertSort(inArr);
            //Console.WriteLine();
            //for (int i = 0; i < inArr.Length; i++)
            //{
            //    Console.Write(inArr[i] + " ");
            //}

            //Console.WriteLine("\n");
            //Fibo(20);
            //Console.WriteLine("\n");

            //double number = double.Parse("34.42", CultureInfo.InvariantCulture);

            //Console.WriteLine(number);
            //Console.WriteLine("\n");

            Ulam(2);

            Console.ReadKey();
        }

        //Факториал
        static int Factorial(int x)
        {
            if (x == 1) return 1;
            return x * Factorial(x - 1);
        }

        //Разворот строки
        static string Revers(string x)
        {
            StringBuilder strB = new StringBuilder(x);
            char temp;

            for (int i = 0, j = strB.Length - 1; i < j; i++, j--)
            {
                temp = strB[i];
                strB[i] = strB[j];
                strB[j] = temp;
            }
            return strB.ToString();
        }

        //Бинарный поиск
        static int BSearch(int[] arr, int value)
        {
            int size = arr.Length;
            int low = 0;
            int hight = size - 1;

            while(low <= hight)
            {
                int mid = (low + hight) / 2;
                if (value == arr[mid])
                {
                    Console.WriteLine("\nЗначение: " + value + " найдено и его индекс = " + mid); return 0;
                }
                else if (value > arr[mid]) low = mid + 1;
                else hight = mid - 1;
            }

            return 1;
        }

        //Линейный поиск
        static int LSearch(int[] arr, int value)
        {
            int size = arr.Length;

           for (int i = 0; i < size; i++)
            {
                if (value == arr[i])
                {
                    Console.WriteLine("\nЗначение: " + value + " на йдено и его индекс = " + i); return 0;
                }
            }
            Console.WriteLine("\nЗначение: " + value + " не найдено!"); 
            return 1;
        }

        //Сортировка выбором
        static void SelectSort(int[] arrs)
        {
            for(int i = 0; i < arrs.Length - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < arrs.Length; j++)
                {
                    if (arrs[j] < arrs[min]) min = j;
                }
                int buf = arrs[i];
                arrs[i] = arrs[min];
                arrs[min] = buf;
            }
        }

        //Сортировка методом вставок
        static void InsertSort(int[] arrs)
        {
            int buf;
            for (int i = 1; i < arrs.Length; i++)
            {
                for (int j = i; j > 0 && arrs[j-1] > arrs[j]; j--)
                {
                    buf = arrs[j];
                    arrs[j] = arrs[j-1];
                    arrs[j-1] = buf;
                }
            }
        }

        //Сортировка слиянием


        //Числа Фибоначчи
        static void Fibo(int lenght)
        {
            if (lenght < 0)
            {
                Console.WriteLine("Отрицательный размер последовательности.");
                return;
            }

            switch (lenght)
            {
                case 0: { Console.WriteLine("0"); break;}
                case 1: { Console.WriteLine("0 1"); break; }
                case 2: { Console.Write("0 1 1"); break; }
                default:
                    {
                        int a1 = 1, a2 = 1, a = 0;
                        Console.Write("0 1 1");
                        for (int i = 3; i != lenght; i++)
                        {
                            a = a1 + a2;
                            Console.Write(" " + a);
                            a1 = a2;
                            a2 = a;
                        }
                        break;
                    }
            }

        }

        //Квадрат Улама
        static void Ulam(int lenght)
        {
            if (lenght < 2)
            {
                Console.WriteLine("\n Неверно заданно ребро квадрата!");
                return;
            }

            int[,] kvadrat = new int[lenght, lenght];
            int zapolnenie = 1;
            int rebro = lenght;
            int x = 0, y = 0;

            while (zapolnenie < lenght * lenght)
            {
                for (int i = 1; i < rebro; i++, x++, zapolnenie++)
                {
                    kvadrat[x, y] = zapolnenie;
                }

                for (int i = 1; i < rebro; i++, y++, zapolnenie++)
                {
                    kvadrat[x, y] = zapolnenie;
                }

                for (int i = 1; i < rebro; i++, x--, zapolnenie++)
                {
                    kvadrat[x, y] = zapolnenie;
                }

                for (int i = 1; i < rebro; i++, y--, zapolnenie++)
                {
                    kvadrat[x, y] = zapolnenie;
                }

                x++;
                y++;
                rebro -= 2;
            }

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write(kvadrat[j, i] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

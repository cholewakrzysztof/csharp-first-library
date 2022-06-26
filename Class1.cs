using System;

namespace FirstLibrary
{
    public class MySpeaker
    {
        public static void SayHello() 
        {
            Console.WriteLine("Hello!");
        }

        public static void Say(string statement) 
        {
            Console.WriteLine(statement);
        }

        public static void Say(string statement, int count) 
        {
            for (int i = 0; i < count; i++) 
                Console.WriteLine(statement);
        }

        public static string Read() 
        {
            return Console.ReadLine();
        }

        public static string[] Read(int count) 
        {
            string[] lines = new string[count];
            for (int i = 0; i < count; i++)
                lines[i] = Console.ReadLine();
            return lines;
        }

        public static string[] ReadWhileNot(string condition) //ZMIENIĆ NAZWY NA CZYTELNE | INNE ROZWIĄZANIE??
        {
            ReadWhile_tab = ReadWhile_newTab;
            ReadWhile_count++;
            string input = Console.ReadLine();
            ReadWhile_newTab = new string[ReadWhile_count];

            for (int i = 0; i < ReadWhile_tab.Length; i++)
                ReadWhile_newTab[i] = ReadWhile_tab[i];

            if (input != condition)
            {
                ReadWhile_newTab[ReadWhile_count - 1] = input;
                return ReadWhileNot(condition);
            }
            else
            {
                ReadWhile_count = 0;
                ReadWhile_tab = new string[0];
                return ReadWhile_newTab;
            }
        }
        private static int ReadWhile_count = 0;
        private static string[] ReadWhile_tab = new string[0];
        private static string[] ReadWhile_newTab = new string[0];
    }
    public class MyMath
    {
        public static int NWD(int a, int b) 
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b) 
                if (a > b)
                    a = a - b;
                else
                    b = b - a;

            return a;
        }

        public static int NWW(int a, int b) 
        {
            return a * b / NWD(a, b);
        }

        public static bool IsPrime(int number) 
        {
            if (number<2)
                return false;

            if (number < 4)
                return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++) 
                if (number % i == 0)
                    return false;

            return true;
        }

        public static int[] PrimeNumbers(int count)
        {
            int[] tab = new int[count];

            int j = 0;
            for (int i = 0; j < count; i++) 
                if (MyMath.IsPrime(i)) 
                {
                    tab[j] = i;
                    j++;
                }

            return tab;
        }

        public static int IndexOfMax(int[] tab) 
        {
            if(tab.Length==0)
                return -1;

            int idx = 0;
            for (int i = 1; i < tab.Length; i++) 
                if (tab[i] > tab[idx]) 
                    idx = i;

            return idx;
        }

        public static int IndexOfMin(int[] tab) 
        {
            if (tab.Length == 0)
                return -1;

            int idx = 0;
            for (int i = 1; i < tab.Length; i++)
                if (tab[i] < tab[idx])
                    idx = i;

            return idx;
        }

        public static int[] Fibonacci(int count) 
        {
            int[] tab = new int[count];
            for (int i = 0,j = 0; i < count;i++) 
            {
                tab[i] = j;
                if (j == 0)
                    j = 1;
                else
                    j = tab[i] + tab[i - 1];
            }

            return tab;
        }

        public static int[] Fibonacci(int from,int to) //OPTYMALIZACJA!!!!!
        {
            if (from >= to)
                return new int[1] { -1 };

            int[] tab = new int[to];
            for (int i = 0, j = 0; i < to; i++)
            {
                tab[i] = j;
                if (j == 0)
                    j = 1;
                else
                    j = tab[i] + tab[i - 1];
            }

            int count = to - from;
            int[] tab2 = new int[count];
            for (int i = 0; i < count; i++)
                tab2[i] = tab[from + i];

            return tab2;
        }

        public static bool Contain(int[] tab, int number) 
        {
            for (int i = 0; i < tab.Length; i++) 
                if (tab[i] == number)
                    return true;
            return false;
        }

        public static int[] BubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                for (int j = 0; j < tab.Length - 1; j++)
                    if (tab[j + 1] < tab[j])
                    {
                        int tmp = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = tmp;
                    }

            return tab;
        }

        public static int[] SelectSort(int[] tab) 
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int min = tab[i];
                int idx = i;
                for (int j = i; j < tab.Length; j++)
                {
                    if (min > tab[j])
                        idx = j;
                        min = tab[j];
                }
                int tmp = tab[idx];
                tab[idx] = tab[i];
                tab[i] = tmp;
            }
            return tab;
        }

        public static int ArraySum(int[] tab) 
        {
            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
                sum += tab[i];
            return sum;
        }

        public static int[] Dividers(int number) //OPTYMALIZACJA?
        {
            int[] tmp = new int[number+1];
            int count = 0;
            for (int i = 1; i <= number; i++) 
                if (number % i == 0)
                { tmp[i] = i; count++; }
                else
                    tmp[i] = 0;

            int[] tab = new int[count];
            for (int i = 1; i < tmp.Length; i++) 
                if (tmp[i] != 0)
                { tab[count-1] = i; count--; }

            return tab;
        }

        public static int BinarySearch(int[] tab,int number,int from,int to) 
        {
            //WARTOŚĆI GRANICZNE I POZA TABLICĄ
            if (tab[from] > number)
                return -1;
            if (tab[to] < number)
                return -1;
            if (tab[to] == number)
                return to;
            if (tab[from] == number)
                return from;
            if (from + 1 == to)
                return -1;

            //WARTOŚĆ MOGĄCE WYSTĄPIĆ W TABLICY
            int mid_idx = Convert.ToInt32(Math.Floor(Convert.ToDecimal((from + to) / 2)));
            if (tab[mid_idx] == number)
                return mid_idx;
            if (tab[mid_idx] > number)
                return BinarySearch(tab, number, from, mid_idx);
            if (tab[mid_idx] < number)
                return BinarySearch(tab, number, mid_idx, to);

            //NIE ZNALEZIENIE WARTOŚCI
            return -1;
        }

        public static int[] Swap(int[] tab, int a, int b) 
        {
            int tmp = tab[a];
            tab[a] = tab[b];
            tab[b] = tmp;
            return tab;
        }
    }
}

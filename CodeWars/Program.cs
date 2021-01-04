using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            //Console.WriteLine(Kata.CountPositivesSumNegatives(array));

            //Kata.Persistence(39) == 3  because 3*9 = 27, 2*7 = 14, 1*4=4
            // and 4 has only one digit

            Console.WriteLine(Kata.Wave("       hello")); 
            Console.ReadKey();
        }
    }
    public class Kata
    {
        public static string GetDrinkByProfession(string p)
        {
            string outputDrink;
            string profession;
            profession = p.ToLower();

            if (profession == "jabroni") { outputDrink = "Patron Tequila"; }
            else if (profession == "school counselor") { outputDrink = "Anything with Alcohol"; }
            else if (profession == "programmer") { outputDrink = "Hipster Craft Beer"; }
            else if (profession == "bike gang member") { outputDrink = "Moonshine"; }
            else if (profession == "politician") { outputDrink = "Your tax dollars"; }
            else if (profession == "rapper") { outputDrink = "Cristal"; }
            else { outputDrink = "Beer"; }
            return outputDrink;

        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }

        public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;

        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0 || number == 0)
                return "Even";
            else
                return "Odd";
        }


        public static int Persistence(long n)
        {
            if (n.ToString().Length == 1)
            {
                return 0;
            }
            string str = Convert.ToString(n);
            var result10 = str.Select(e => int.Parse(e.ToString())).ToArray();
            int mult = 1;
            for (int i = 0; i < result10.Length; i++)
            {

                mult *= Convert.ToInt32(result10[i]);
            }

            return 1 + Persistence(mult);


            //int count = 0;
            //while (n > 9)
            //{
            //    count++;
            //    n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            //}
            //return count;
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            if (a + b <= c || a + c <= b || c + b <= a)
            {
                return false;
            }
            return true;
        }

        public static string repeatStr(int n, string s)
        {
            for (int i = 0; i < n; i++)
            {
                s = s + "" + s;
            }
            return s;
        }

        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * 2;
            }

            return x;
            // Best practice return x.Select(e => e*2).ToArray();
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            str.ToLower();
            var ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;

            //return str.Count(i => "aeiou".Contains(i));
        }

        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
            {
                return -1;
            }
            int result = -1;

            do
            {
                result += 2;
                h *= bounce;
            } while (h > window);

            return result;
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                numbers.Clear();
                return numbers;
            }
            numbers.Remove(numbers.Min());

            return numbers;
        }

        public static string LongestConsec(string[] strarr, int k)
        {
            if (k > strarr.Length || strarr.Length == 0 || k <= 0)
            {
                return string.Empty;
            }
            string str = "";
            string result = "";
            int resultLen = 0;

            for (int i = 0; i <= strarr.Length; i++)
            {
                for (int j = i; j < k + i && j < strarr.Length; j++)
                {
                    str += strarr[j];
                }
                if (str.Length > resultLen)
                {
                    resultLen = str.Length;
                    result = str;
                }
                str = String.Empty;
            }
            Console.WriteLine(result);
            return result;
        }

        public static List<string> Wave(string str)
        {

            List<String> list = new List<string>();
            str.ToLower();
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    continue;
                }
                string upperStr = arr[i].ToString().ToUpper();
                char[] upar = upperStr.ToCharArray();
                arr[i] = upar[0];
                string res = String.Join("", arr);
                list.Add(res);
                string lowerStr = arr[i].ToString().ToLower();
                char[] lowar = lowerStr.ToCharArray();
                arr[i] = lowar[0];
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            return list;

            //return str
            //.Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
            //.Where(x => x != str)
            //.ToList();
        }
    }
}

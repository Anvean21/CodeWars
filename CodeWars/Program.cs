using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //changes
            Console.ReadKey();
        }
    }
    public class Kata
    {
        //never mind
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

        // 1701 -> 18, 1700 -> 17
        public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;

        //even or odd num
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0 || number == 0)
                return "Even";
            else
                return "Odd";
        }

        //idk
        public static int Persistence(long n)
        {
            //if (n.ToString().Length == 1)
            //{
            //    return 0;
            //}
            //string str = Convert.ToString(n);
            //var result10 = str.Select(e => int.Parse(e.ToString())).ToArray();
            //int mult = 1;
            //for (int i = 0; i < result10.Length; i++)
            //{

            //    mult *= Convert.ToInt32(result10[i]);
            //}

            //return 1 + Persistence(mult);


            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }

        //math
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

        //n = 2, string = some; -> somesome
        public static string RepeatStr(int n, string s)
        {
            for (int i = 0; i < n; i++)
            {
                s = s + "" + s;
            }
            return s;
        }

        //[] {2,2,4,8} -> {4,4,8,16}
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * 2;
            }

            return x;
            // Best practice return x.Select(e => e*2).ToArray();
        }

        //vowel counter
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

        //try
        public static int BouncingBall(double h, double bounce, double window)
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

        //[] {1,5,8,9,2,1,5,3} -> {5,8,9,2,1,5,3}
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

        //Try
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

        //string -> String sTring stRing strIng striNg strinG
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

        //Some string -> emoS gnirts
        public static string ReverseWords(string str)
        {
            List<string> sl = new List<string>();// List to hold the reversed words

            string[] words = str.Split(' ');// convert str to string array

            foreach (string s in words)  // loop through string array
            {
                char[] scharr = s.ToCharArray();//convert string to char array
                Array.Reverse(scharr);//reverse char array

                string sreverse = new string(scharr);// create string with char array

                sl.Add(sreverse);//add string to the list
            }
            string strk = string.Join(" ", sl.ToArray());

            return strk; //Return the list as a string
        }

        //Print diamonds.. just try..
        public static string Print(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            int middle = n / 2;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < n; index++)
            {
                sb.Append(' ', Math.Abs(middle - index));
                sb.Append('*', n - Math.Abs(middle - index) * 2);
                sb.Append("\n");
            }
            Console.WriteLine(sb);

            return sb.ToString();
        }

        public static string PrinterError(string s)
        {
            int counter = s.Count(i => "mnopqrstuvwxyz".Contains(i));
            string str = counter + "/" + s.Length;
            return str;
        }

        //str: some, ending:ome -> true
        public static bool Solution(string str, string ending)
        {
            bool res = false;
            if (str.EndsWith(ending))
            {
                res = true;
            }

            return res;
        }

        // "1 2 3 4 5 6 7" -> 1 7
        public static string HighAndLow(string numbers)
        {
            string[] str = numbers.Split(' ');
            List<int> list = new List<int>();
            foreach (var i in str)
            {
                list.Add(Int32.Parse(i));
            }
            string min = list.Min().ToString();
            string max = list.Max().ToString();

            return min + "" + max;
        }

        //fight game
        public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            if (fighter1.Name == firstAttacker)
            {
                while (true)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        return fighter1.Name;
                    }
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                    {
                        return fighter2.Name;
                    }
                }
            }
            else if (fighter2.Name == firstAttacker)
            {
                while (true)
                {

                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                    {
                        return fighter2.Name;
                    }
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        return fighter1.Name;
                    }
                }
            }
            return null;







        }

        //StingOfMyLove -> String Of My Love
        public static string BreakCamelCase(string str)
        {

            return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }

        //{9,9,2,5,6,7 } -> 2. first odd amount
        public static int Find_It(int[] seq)
        {
            int count = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                count = seq.Count(x => x == seq[i]);
                if (count % 2 != 0)
                {
                    return seq[i];
                }
            }
            return -1;
        }

        //Min & Max array element
        public static int[] MinMax(int[] lst)
        {
            return new int[] { lst.Min(), lst.Max() };
        }

        //Deposit year counter
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            while (principal < desiredPrincipal)
            {
                double principalPerYear = principal * interest;
                double taxPerYear = principalPerYear * tax;
                principalPerYear = principalPerYear - taxPerYear;
                principal = principal + principalPerYear;
                years++;
                Console.WriteLine($"After {years} " + principal);

            }

            return years;
        }

        public static string OddOrEven(int[] array)
        {
            string str = array.Sum() % 2 == 0 ? "Odd" : "Even";
            return str;
        }

        // to jaden case -> To Jaden Case
        public static string ToJadenCase(string phrase)
        {
            TextInfo inf = CultureInfo.CurrentCulture.TextInfo;
            string[] str = phrase.Split(' ');

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = inf.ToTitleCase(str[i]);
            }
            return String.Join(" ", str);

        }

        //123 -> 321
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

        }

        // REC. 5 -> 120
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12)
                throw new ArgumentOutOfRangeException();
            return n > 0 ? n * Factorial(n - 1) : 1;
        }

        // some -> SoMe sOmE
        public static string[] Capitalize(string s)
        {
            StringBuilder s1 = new StringBuilder(s.ToLower());
            StringBuilder s2 = new StringBuilder(s.ToLower());

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s1[i] = char.ToUpper(s1[i]);
                }
                else
                {
                    s2[i] = char.ToUpper(s1[i]);
                }
            }
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            return new string[] { s1.ToString(), s2.ToString() };
        }

        //1234 -> 10
        public static int SumDigits(int number)
        {
            number = Math.Abs(number);
            var digitArray = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int result = 0;
            for (int i = 0; i < digitArray.Length; i++)
            {

                result += Math.Abs(digitArray[i]);
            }
            return result;
        }

        public static string ExpandedForm(long num)
        {
            var str = num.ToString();
            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
        }

        // s32?fsdf -> fdsfs
        public static string ReverseLetter(string str)
        {
            return new String(str.Where(Char.IsLetter).Reverse().ToArray());
        }

        //сумирует все числа меньше value && кратные 3м и 5ти
        public static int Solution(int value)
        {
            var sum = 0;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            return sum;
        }

        //aaabb -> a 3, b 2
        public static Dictionary<char, int> Count(string str)
        {
            return  str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }

        //REC. 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
        public static int DigitalRoot(long n)
        {
           
            string str = n.ToString();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += Convert.ToInt32(str[i].ToString()); ;
            }
            if (sum > 9)
            {
               return DigitalRoot(sum);
            }
            return sum;

            //while (n >= 10)
            //{
            //    long sum = 0;
            //    while (n > 0)
            //    {
            //        sum += n % 10;
            //        n /= 10;
            //    }
            //    n = sum;
            //}
            //return (int)n;
        }

        //"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }
    }
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}

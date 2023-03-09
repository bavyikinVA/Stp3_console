using System;
using System.IO;

namespace stp3_bavykin_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int intro;
            Console.WriteLine("Enter 1 - task 1, 2 - task 2, 0 - exit:");
            intro = Convert.ToInt32(Console.ReadLine());
            if (intro == 0) Environment.Exit(0); ;

            if (intro == 1) { Task1(); }

            if (intro == 2) { Task2(); }
        }

        public static void Task1()
        {
            string str = Reader1();
            str = str.ToLower();
            string[] s = str.Split(';');
            string s1 = s[0];
            string s2 = s[1];
            string[] words1 = s1.Split(' ');
            // words(s1);
            foreach (var word in words1)
            {
                Console.WriteLine($"<{word}>");
            }
            //words(s2);
            string[] words2 = s2.Split(' ');
            foreach (var word in words2)
            {
                Console.WriteLine($"<{word}>");
            }
            int Lmax = Math.Max(words1.Length, words2.Length);
            double m = check(words1, words2, Lmax);
            Console.WriteLine("Процент совпадения");
            Console.WriteLine((m / Lmax) * 100);
            
        }
        public static void Task2()
        {
            string str1 = Reader2_1();
            string str2 = Reader2_2();

            string[] words1 = Strings(str1);
            string[] words2 = Strings(str2);
            
            int Lmax = Math.Max(words1.Length, words2.Length);
            double m = check(words1, words2, Lmax);
            
            Console.WriteLine("Процент совпадения");
            Console.WriteLine((m / Lmax) * 100);
        }
        
        public static string [] Strings(string str)
        {
            str = str.ToLower();
            string[] words = str.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            }
            return words;
        }


        public static string Reader1()
        {
            bool flag = true;
            StreamReader file = null;
            do
            {
                try
                {
                    string fname;
                    Console.WriteLine("Введите название файла, из которого будут считываться строки");

                    fname = Console.ReadLine();

                    file = new StreamReader(fname);
                    flag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Данный файл не найден!");
                    Environment.Exit(0); // выход из программы
                    flag = false;
                }
            } while (!flag);

            string text = "";
            while (true)
            {
                string s0 = file.ReadLine();
                if (s0 == null) break;
                text += s0;
                text += ";";
            }
            return text;
        }


        public static int SMaxLength(string s1, string s2)
        {
            int result = Math.Max(s1.Length, s2.Length);
            return result;
        }

        public static double check(string[] words1, string[] words2, int Lmax)
        {
            int k = 0;

            foreach (var word1 in words1)
            {
                foreach (var word2 in words2)
                {
                    if (word1 == word2)
                    {
                        k++;
                    }
                }
            }


            return k;
        }


        public static string Reader2_1()
        {
            Console.Write("Enter the first line:\n");
            string s = Console.ReadLine();
            return s;
        }
        public static string Reader2_2()
        {
            Console.Write("Enter the second line:\n");
            string s = Console.ReadLine();
            return s;
        }

    }
}

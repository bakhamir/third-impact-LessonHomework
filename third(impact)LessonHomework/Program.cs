using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_impact_LessonHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iHateTheLetterA();
        }
        /// <summary>
        /// Первым трем кто выполнит задание сникерс
        /// </summary>
        static void snickers()
        {

            int sum = 0;
            string str = " 1234 555 6665 7456 1233 4332  54 634 12  333";
            Console.WriteLine(str);
            var numstr = str.Split(' ');
            for (int i = 0; i < numstr.Length; i++)
            {
                if (numstr[i].EndsWith("3") || numstr[i].EndsWith("4"))
                {
                    sum += Int32.Parse(numstr[i]);
                }
            }
            Console.WriteLine("Сумма всех чисел оканчивающихся на 3 и 4 в строке выше - {0}",sum);
        }
        /// <summary>
        /// Считает слова в строке с одинаковым символом в начале и конце
        /// </summary>
        static void theBeginningAndTheEnd()
        {
            int sum = 0;
            string str = "Lorem ipsumi rolor sits ameta at anem et qui";
            var strarr = str.Split(' ');
            for (int i = 0; i < strarr.Length; i++)
            {
                char firstLetter = strarr[i][0];//получаем первую букву текущего слова в массиве
                char secondLetter = strarr[i][strarr[i].Length - 1];//получаем последнюю букву текущго слова в массиве через Length
                if (firstLetter == secondLetter)
                {
                    sum++;
                }
            }
            Console.WriteLine("В строке {0} - {1} слов с одинаковыми буквами в начале и конце",str,sum);
        }
        /// <summary>
        /// считает количество вхождений буквы "P" в тексте
        /// </summary>
        static void pCounter()
        {
            int sum = 0;
            string str = "Pushing P";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'P' || str[i] == 'p')
                {
                    sum++;
                }
            }
            Console.WriteLine("В строке {0} - {1} вхождений буквы P и p", str, sum);
        }
        /// <summary>
        /// заточает слова у которых первая и последняя буква равны в квадратные скобки
        /// </summary>
        static void trimCounter()
        {
            string str = "Lorem ispum dolord sits ameta";
            var arrstr = str.Split(' ');
            for (int i = 0; i < arrstr.Length; i++)
            {
                char firstLetter = arrstr[i][0];
                char lastLetter = arrstr[i][arrstr[i].Length - 1];
                if (firstLetter == lastLetter)
                {
                    Console.Write("[{0}] ", arrstr[i]);
                    continue;
                }
                Console.Write(arrstr[i] + " ");
            }

        }
        /// <summary>
        /// удаляет слэши
        /// </summary>
        static void slashDeleter()
        {
            string str = @" /// THE ONE AND ONLY \\\";
            Console.WriteLine(str);
            Console.WriteLine("строка после изменения - {0}", str.Replace("/", " ").Replace(@"\", " "));
        }
        /// <summary>
        /// принимает символы до точки
        /// </summary>
        static void inputFunc()
        {
            string str = string.Empty;
            char enter = ' ';
            while (enter != '.')
            {
                bool rez = Char.TryParse(Console.ReadLine(), out enter);
                if (!rez)
                {
                    Console.WriteLine("ДЛИНА СИМВОЛА НЕ БОЛЬШЕ ОДНОГО ЗНАКА");
                    continue;
                }
                str += enter;
            }
            Console.WriteLine(str);
        }
        /// <summary>
        /// определяет количество цифр в строке
        /// </summary>
        static void stringCalc()
        {
            int temp = 0;
            int sum = 0;
            string str = "инцидент 2001 11 09 является самой крупной террористической атакой на данный момент";
            for (int i = 0; i < str.Length; i++)
            {
                bool rez = Int32.TryParse(Convert.ToString(str[i]),out temp);
                if (rez)
                {
                    sum++;
                }
            }
            Console.WriteLine("В данной строке {0} цифр",sum);
        }
        /// <summary>
        /// определяет есть ли в тексте спецсимволы
        /// </summary>
        static void specialSymbols()
        {
            string str = "Я гуляю! Пышны юбки, Алы губки! Лихо тренькает рояль...";
            bool isSpecial = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetterOrDigit(str[i]))
                {
                    isSpecial= true;
                }
            }
            if (isSpecial == true)
            {
                Console.WriteLine("В ТЕКСТЕ ЕСТЬ СПЕЦСИМВОЛЫ");
            }
            else if (!isSpecial)
            {
                Console.WriteLine("В ТЕКСТЕ НЕТ СПЕЦ СИМВОЛОВ");
            }
        }
        /// <summary>
        /// простая функция для вывода слов и их количества в столбик
        /// </summary>
        static void inputWords()
        {
            string str = Console.ReadLine();
            var strarr = str.Split(' ');
            for (int i = 0; i < strarr.Length; i++)
            {
                Console.WriteLine(strarr[i]);
            }
            Console.WriteLine("В данном тексте {0} слов",strarr.Length);
        }
        /// <summary>
        /// удаляет все слова с буквой А
        /// </summary>
        static void iHateTheLetterA()
        {
            string str = "Имен деяний не стяжают. Ах,Офелия. О нимфа, помянь Греха моего в своей молитве";
            Console.WriteLine(str);
            var strarr = str.Split(' ');
            for (int i = 0; i < strarr.Length; i++)
            {
                if (strarr[i].Contains('А') == true || strarr[i].Contains('а') == true)
                {
                    strarr[i] = " ";
                    continue;
                }
                Console.Write(strarr[i] + " ");
            }
            Console.WriteLine();
        }

    }
}

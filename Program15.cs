using System;

namespace _15032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            string Text1 = "  Hello Azerbaijan ";
            Console.WriteLine(Text1);
            Console.WriteLine(Text1.Split( ' '));
            Console.ReadLine();

            #endregion

            #region Task2
            string Text2 = "26Iyun";
            Console.WriteLine(checkString(Text2)); ;
            #endregion

            #region Task4
            int[] array = { 244, 441, 1296, 4589365, 785236 };
            int number = 5;
            AddElement(number, ref array);
            foreach (var numbers in array)
            {
                Console.WriteLine(numbers);
            }
            #endregion

            #region task2-metod
            static bool checkString(string Task2Text)
            {
                bool isDigit = false;
                bool isUpperLetter = false;
                bool isLowerLetter = false;
                for (int i = 0; i < Task2Text.Length; i++)
                {
                    if (Char.IsDigit(Task2Text[i]))
                    {
                        isDigit = true;
                    }
                    if (char.IsUpper(Task2Text[i]))
                    {
                        isUpperLetter = true;
                    }
                    if (Char.IsLower(Task2Text[i]))
                    {
                        isLowerLetter = true;
                    }
                    return isLowerLetter && isDigit && isLowerLetter;
                }
                #endregion
                #region Task4 metod
                static void AddElement(int number,ref int[] numberss)
                {
                    Array.Resize(ref numberss, numberss.Length + 1);
                    numberss[numberss.Length - 1] = number;
                }
                #endregion
            }

        }
    }
}

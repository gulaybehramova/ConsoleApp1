using System;

namespace Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1
            Console.WriteLine("Text daxil edin: ");
            string yazi = Console.ReadLine();
            TersMetn(yazi);

            //Method2
            Console.WriteLine("Metn daxil edin: ");
            string str = Console.ReadLine();
            SozSay(str);

            //Method3
            string deyer = "salam";
            char index = 'a';
            Array(deyer, index);
        }
        #region Method1
        static int TersMetn(string yazi)
        {
            for (int i = 0; i <= yazi.Length - 1; i++)
            {
                Console.Write(yazi[yazi.Length - i - 1]);
            }
            return i;
        }
        #endregion

        #region Method2
        static int SozSay(string str)
        {
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' + str[i])
                    count++;
            }
            return count;
        }
        #endregion

        #region Method3
        static int Array(string deyer, char index)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < deyer.Length; i++)
            {
                if (index == digits[i])
                    return digits[i];
            }
            return -1;
        }
        #endregion
    }
}
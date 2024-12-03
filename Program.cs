using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StringForYod
{
    internal class Program
    {
        // יש לסרוק ולהדפיס כל תו במחרוזת בשורה חדשה

        public static void PrintString()
        {
            String str = "Hello World";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }


        }

      


        public static void CountaInString()
        {
            Console.WriteLine("Enter a string");
            String str = Console.ReadLine();
            Console.WriteLine("Enter a char");
            char ch = char.Parse(Console.ReadLine());
            bool isThere = false;
            int i = 0;
          while  (i < str.Length&& isThere==false)
            {
                if (str[i] == ch)
                {
                    isThere = true;
                }
                i++;
            }
        }

        public static void ReverseString()
        {
            string str = "Hello World";
            string reverseString = "";


            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString+= str[i];
            }
        } 

        public static void IsCharInString()
        {
            Console.WriteLine("Enter a string");
            String str = Console.ReadLine();
            Console.WriteLine("Enter a char");
            char c = char.Parse(Console.ReadLine());
            bool isCharInString = false;
            for (int i = 0; i < str.Length; i++)
            {
                bool boo = str[i] == c;
                if (str[i] == c)
                {
                    isCharInString = true;
                }
            }
            if (isCharInString)
            {
                Console.WriteLine("The char " + c + " is in the string");
            }
            else
            {
                Console.WriteLine("The char " + c + " is not in the string");
            }
        }

        public static void CountWordsInString()
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();


            int count = 1;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == ' ')
                {
                    count++;
                }
            }


            Console.WriteLine($"the number of words is {count}");
        }
        public static void checkPassword()
        {
            Console.WriteLine("enter password");
            string myPassword = Console.ReadLine();
            bool isPasswordValid = false;
            bool isPasswordLongEnough = false;
            bool isPasswordHasUpperCase = false;
            bool isPasswordHasNumber = false;
            if (myPassword.Length >= 6 && myPassword.Length <= 8)
            {
                isPasswordLongEnough = true;
            }
            for (int i = 0; i < myPassword.Length; i++)
            {
                if (myPassword[i] >= 65 && myPassword[i] <= 90)
                {
                    isPasswordHasUpperCase = true;
                }
                if (myPassword[i] >= 48 && myPassword[i] <= 57)
                {
                    isPasswordHasNumber = true;
                }
                isPasswordValid = isPasswordLongEnough
                    && isPasswordHasUpperCase &&
                    isPasswordHasNumber;

            }
        }
            public static void replaceChar()
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            Console.WriteLine("enter char to replace");
            char toReplace = char.Parse(Console.ReadLine());
            Console.WriteLine("enter new char");
            char newChar = char.Parse(Console.ReadLine());
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == toReplace)
                {
                    newStr += newChar;
                }
                else
                {
                    newStr += str[i];
                }
                Console.WriteLine(newStr);
            }
            Console.WriteLine(newStr);
        }

        
            static void Main(string[] args)
        {
            replaceChar();

        }
    }
}

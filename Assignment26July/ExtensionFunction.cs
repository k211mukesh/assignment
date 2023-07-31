using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment26July
{
    static class ExtensionMethods
    {
        public static char ShowExtendedList(this Class1 obj)
        {
            Console.Clear();
            Console.WriteLine(" 1. Display all even no.s with in a given range\r\n " +
                "2. Display all odd no.s with in a given range\r\n " +
                "3. Display all prime no.s with in a given range\r\n " +
                "4. Diplay table of an entered no.\r\n " +
                "5. Display tables from 1 to 10 of all no.s with in a given range\r\n " +
                "6. Display tables from a given range of all no.s with in a given range\r\n " +
                "7. Reverse a no." +
                "8. quit this menu");
            char respo;
            char.TryParse(Console.ReadLine(), out respo);
            return respo;


        }
        public static string EvenInRange(this Class1 obj, int r1, int r2)
        {
            string ans = "";
            for (int i = r1; i <= r2; i++)
            {
                if (i % 2 == 0)
                {
                    ans = ans + i.ToString() + " ";
                }
            }
            return ans;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        public static string OddInRange(this Class1 obj, int r1, int r2)
        {
            string ans = "";
            for (int i = r1; i <= r2; i++)
            {
                if (i % 2 != 0)
                {
                    ans = ans + i.ToString() + " ";
                }
            }
            return ans;
        }
        public static string PrimeInRange(this Class1 obj, int r1, int r2)
        {
            string ans = "";
            for (int i = r1; i <= r2; i++)
            {
                if (IsPrime(i))
                {
                    ans = ans + i.ToString() + " ";
                }
            }
            return ans;
        }
        public static string TableOf(this Class1 obj, int no)
        {
            string ans = "";
            for(int i = 1; i < 10; i++)
            {
                ans = ans + $"{no}*{i}={no*i}\n";
            }
            return ans;
        }
        public static string TablesINRange(this Class1 obj, int r1, int r2) {
            string ans = "";
            for(int no=r1; no<=r2; no++)
            for (int i = 1; i < 10; i++)
            {
                ans = ans + $"{no}*{i}={no * i}\n";
            }
            return ans;
        }

        public static int ReverseInt(this Class1 obj, int no) {
            int ans = 0;
            int temp = 0;
            while (no > 0)
            {
                temp = no % 10;
                ans *= 10;
                ans += temp;
                no /= 10;
            }
            return ans;
        }
    }
}

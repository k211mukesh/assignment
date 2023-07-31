using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment26July
{
    internal class StringFunctions
    {
        public int NoOfChar(string str)
        {
            HashSet<char> s = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                s.Add(str[i]);
            }
            return s.Count;
        }

        public bool IsPalindrome(string str)
        {
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                if(str[i] != str[j])
                {
                    return false;
                }
                i++;j--;
            }
            return true;

        }

        public string ReverseSentance(string str)
        {
            char v = ' ';
            string ans = "";
            string[] strarr = str.Split(v);
            Array.Reverse(strarr);
            foreach(string s in strarr)
            {
                ans = ans + s;
            }
            return ans;
        }

        public void KnowAllChar(string str)
        {
            int vowels = 0, consonant = 0, specialChar = 0,
    digit = 0;


            for (int i = 0; i < str.Length; i++)
            {

                char ch = str[i];

                if ((ch >= 'a' && ch <= 'z') ||
                      (ch >= 'A' && ch <= 'Z'))
                {


                    ch = Char.ToLower(ch);

                    if (ch == 'a' || ch == 'e' || ch == 'i' ||
                        ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonant++;
                }
                else if (ch >= '0' && ch <= '9')
                    digit++;
                else
                    specialChar++;
            }

            Console.WriteLine($"Vowels  : {vowels}\nConsonant  : {consonant}\nDigit  : {digit}\n Special Character  : {specialChar}\n");
        }

        public string AllToUpper(string str) {
            string ans=string.Empty;
            for(int i=0; i<str.Length; i++)
            {
                ans += char.ToUpper(str[i]);
            }
            return ans;

        }

        public string AllToTitel(string str) {
            string ans = string.Empty;
            for(int i=0; i<str.Length; i++)
            {
                if (i == 0)
                {
                    ans += char.ToUpper(str[i]);
                }
                else
                {
                    if (str[i-1]==' ')
                    {
                        ans+= char.ToUpper(str[i]);
                    }
                }
               
            }
            return ans;
        }

        public string CombineSentance(string str,string str2) {
            string ans = string.Empty;
            ans = str + str2;
            return ans;
        }

        public  string RemoveExtraSpace(string str)
        {
            string ans = string.Empty;
            for(int i=1; i<str.Length; i++) {
                if (str[i-1]!=' ' && str[i]!=' ')
                {
                    ans = ans + str[i];
                }
            }
            return ans;
        }

        public  int CountWord(string str)
        {
            string[] strarr = str.Split(' ');
            return strarr.Length;
        }

        public bool isPresent(string s1,string str)
        {
            if (str.Contains(s1))return true;
            return false;
        }

        public int CountOccurance(string s1, string str)
        {
            int mila = 0;
            int count = 0;
            do
            {
                mila = str.IndexOf(s1, mila);
                if (mila >= 0)
                {
                    count++;
                }


            } while (mila >= 0);
            return count;
        }
        

    }
}

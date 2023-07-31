using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using ClassLibrary1;

namespace Assignment26July
{
    internal class q1
    {
        public static void Main(string[] args)
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            char responce;
            bool val=true;
            while (true)
            {
                Console.WriteLine("Welcome to Numeric functions\n" +
                    "1. Enter 1 to enter n arguments\n" +
                    "2. Enter 2 to subtract two numbers\n" +
                    "3. Enter 3 to multiply two numbers\n" +
                    "4. Enter 4 to divide two numbers\n" +
                    "5. Enter 5 to get maximum number in list\n" +
                    "6. Enter 6 to get minimum number in list\n" +
                    "7. Enter 7 to check for even\n" +
                    "8. Enter 8 to check for odd num\n" +
                    "9. Enter 9 to check for prime\n" +
                    "10. Enter q to quit\n" +
                    "11. Enter e to show extended functions" +
                    "12. Enter s to show string functions");
                val = char.TryParse(Console.ReadLine(),out responce);
                bool wantexir = false;
                switch (responce)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter the no of element in array");
                            int fres;
                            try
                            {
                                fres = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                fres = 10;
                            }
                            Console.WriteLine($"Enter {fres} elements");
                            obj.EnterNArgument(fres);
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Enter 2 nos to be Subtracted");
                            int c2i1, c2i2;
                            try
                            {
                                c2i1 = Convert.ToInt32(Console.ReadLine());
                                c2i2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                c2i1 = 10;
                                c2i2 = 10;
                            }
                            Console.WriteLine($"subtraction of {c2i1} and {c2i2} is " + obj.Subtract(c2i1, c2i2));
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Enter 2 nos to be Multiplied");
                            int c3i1, c3i2;
                            try
                            {
                                c3i1 = Convert.ToInt32(Console.ReadLine());
                                c3i2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                c3i1 = 10;
                                c3i2 = 10;
                            }
                            Console.WriteLine($"Multiplication of {c3i1} and {c3i2} is " + obj.Multiply(c3i1, c3i2));
                            break;
                        }
                    case '4':{
                            Console.WriteLine("Enter 2 nos to be Divided");
                            int c4i1, c4i2;
                            try
                            {
                                c4i1 = Convert.ToInt32(Console.ReadLine());
                                c4i2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                c4i1 = 10;
                                c4i2 = 10;
                            }
                            Console.WriteLine($"Division of {c4i1} and {c4i2} is " + obj.Divide(c4i1, c4i2));
                            break;
                        }
                    case '5':
                        {
                            if(obj.GetListSize() > 0)
                            {
                                Console.WriteLine("largest element of list is " + obj.FindMax());
                            }
                            else
                            {
                                Console.WriteLine("You have not initialised the list");
                            }
                            break;
                        }
                    case '6':
                        {
                            if (obj.GetListSize() > 0)
                            {
                                Console.WriteLine("Smallest element of list is " + obj.FindMin());
                            }
                            else
                            {
                                Console.WriteLine("You have not initialised the list");
                            }
                            break;
                        }
                    case '7':{
                            Console.WriteLine("Even Numbers on list are " + obj.findEven());
                            break;
                        }
                    case '8':
                        {
                            Console.WriteLine("Even Numbers on list are " + obj.findOdd());
                            break;
                        }
                    case '9':
                        {
                            Console.WriteLine("Prime numbers in the list are: " + obj.FindPrime());
                            break;
                        }
                    case 'q':
                        {
                            wantexir = true;
                            break;
                        }
                    case 'e':
                        {
                            char res = obj.ShowExtendedList();
                            switch (res)
                            {
                                case '1':
                                    {
                                        int Ran1, Ran2;
                                        Console.WriteLine("Enter range to find all the even nos inside");
                                        Ran1 = Convert.ToInt32(Console.ReadLine());
                                        Ran2 = Convert.ToInt32(Console.ReadLine());
                                        string ans = obj.EvenInRange(Ran1, Ran2);
                                        Console.WriteLine("Even nos in range "+ans);
                                        break;
                                    }
                                case '2':
                                    {
                                        int Ran1, Ran2;
                                        Console.WriteLine("Enter range to find all the Odd nos inside");
                                        Ran1 = Convert.ToInt32(Console.ReadLine());
                                        Ran2 = Convert.ToInt32(Console.ReadLine());
                                        string ans = obj.OddInRange(Ran1, Ran2);
                                        Console.WriteLine("Odd nos in range " + ans);
                                        break;
                                    }
                                case '3':
                                    {
                                        int Ran1, Ran2;
                                        Console.WriteLine("Enter range to find all the Prime nos inside");
                                        Ran1 = Convert.ToInt32(Console.ReadLine());
                                        Ran2 = Convert.ToInt32(Console.ReadLine());
                                        string ans = obj.PrimeInRange(Ran1, Ran2);
                                        Console.WriteLine("Prime nos in range " + ans);
                                        break;
                                    }
                                case '4':
                                    {
                                        int no;
                                        Console.WriteLine("Enter the number to print table");
                                        no = Convert.ToInt32(Console.ReadLine());
                                        string ans = obj.TableOf(no);
                                        Console.WriteLine("The table is\n" + ans);
                                        break;
                                    }
                                case '5':
                                    {
                                        int Ran1, Ran2;
                                        Console.WriteLine("Enter range to find all the Tables nos inside");
                                        Ran1 = Convert.ToInt32(Console.ReadLine());
                                        Ran2 = Convert.ToInt32(Console.ReadLine());
                                        string ans = obj.TablesINRange(Ran1, Ran2);
                                        Console.WriteLine("Tables of nos in range " + ans);
                                        break;
                                    }
                                case '6':
                                    {
                                        int Ran1, Ran2;
                                        Console.WriteLine("Enter range to find all the Tables nos inside");
                                        Ran1 = Convert.ToInt32(Console.ReadLine());
                                        Ran2 = Convert.ToInt32(Console.ReadLine());
                                        string ans = obj.TablesINRange(Ran1, Ran2);
                                        Console.WriteLine("Tables of nos in range " + ans);
                                        break;
                                    }
                                case '7':
                                    {
                                        int val1;
                                        Console.WriteLine("Enter the Number to Reverse");
                                        val1 = Convert.ToInt32(Console.ReadLine());
                                        val1 = obj.ReverseInt(val1);
                                        Console.WriteLine("Reverse is " + val1);
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case 's':
                        {
                            Console.WriteLine(" 1. Find no. of characters in a sentence\r\n 2. Check for Palindrome\r\n 3. Reverse a sentencene\r\n 4. Find no. of vowels, consonants, integers and sp characters in a sentence\r\n 5. Change case to upper case\r\n 6. Change sentence to proper case\r\n 7. Combine two sentences\r\n 8. Remove extra spaces in a sentence\r\n 9. Count no. of words in a sentence\r\n 10.Search a substring in a sentence\r\n 11.Find the no. of occurences of a substring in a sentence");
                            StringFunctions sf = new StringFunctions();
                            try
                            {
                                int resres = Convert.ToInt32(Console.ReadLine());
                                switch (resres)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.NoOfChar(str));
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.IsPalindrome(str));
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.ReverseSentance(str));
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output");
                                            sf.KnowAllChar(str);
                                            break;
                                        }
                                    case 5:
                                        {

                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.AllToUpper(str));
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.AllToTitel(str));
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.WriteLine("Enter 2 sentance");
                                            string str = Console.ReadLine();
                                            string str2= Console.ReadLine();

                                            Console.WriteLine("The Output" + sf.CombineSentance(str, str2));
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.RemoveExtraSpace(str));

                                            break;
                                        }
                                    case 9:
                                        {
                                            Console.WriteLine("Enter the sentance");
                                            string str = Console.ReadLine();
                                            Console.WriteLine("The Output" + sf.CountWord(str));
                                            break;
                                        }
                                    case 10:
                                        {
                                            Console.WriteLine("Enter 2 sentance");
                                            string str = Console.ReadLine();
                                            string str2 = Console.ReadLine();

                                            Console.WriteLine("The Output" + sf.isPresent(str, str2));
                                            break;
                                        }
                                    case 11:
                                        {
                                            Console.WriteLine("Enter 2 sentance");
                                            string str = Console.ReadLine();
                                            string str2 = Console.ReadLine();

                                            Console.WriteLine("The Output" + sf.CountOccurance(str, str2));
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }
                            }
                            catch
                            {
                                break;
                            }
                            break;
                        }
                    default:
                        {
                            wantexir = true;
                            break;
                        }

                }
                if (wantexir)
                {
                    break;
                }
            }

        }

    }
}

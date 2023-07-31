namespace ClassLibrary1

{
    public class Class1
    {
        int[] ints;
        public static void clr()
        {
            Console.Clear();
        }

        public int[]  GetList()
        {
            return ints;
        }

        public void EnterNArgument(int n)
        {
            ints = new int[n];    
            for(int i=0; i < n; i++)
            {
                try
                {
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e) {
                    ints[i] = 10;
                }
            }
        }

        public int GetListSize()
        {
            return this.ints.Length;
        }

        public int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        public int Divide(int v1, int v2)
        {
            try
            {
                return v1 / v2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public int FindMax()
        {
            try
            {
                int i = int.MinValue;
                for(int j=0; j<ints.Length; j++)
                {
                    if (ints[j] > i)
                    {
                        i = ints[j];
                    }
                }
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public int FindMin()
        {
            try
            {
                int i = int.MaxValue;
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[j] < i)
                    {
                        i = ints[j];
                    }
                }
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public string findEven()
        {
            string ans = string.Empty;
            for(int i=0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    ans = ans + ints[i].ToString()+ " ";
                }
            }
            return ans;
        }

        public string findOdd()
        {
            string ans = string.Empty;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                {
                    ans = ans + ints[i].ToString() + " ";
                }
            }
            return ans;
        }

        bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2 || n == 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        public string FindPrime()
        {
            string ans = string.Empty;
            for(int i=0; i<ints.Length; i++) {
                if (IsPrime(ints[i]))
                {
                    ans = ans + ints[i].ToString() + " ";
                }
            }
            return ans;
        }

    }
}
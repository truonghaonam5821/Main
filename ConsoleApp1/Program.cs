namespace Project
{
    class program
    {
        static int GT(int n)
        {
            int p = 1;
            for (int i = 1; i <= n; i++)
            {
                p = p * i;
            }
            return p;
        }
        static int CKN(int k,int n)
        {
            int kq = GT(n) / (GT(k) * GT(n - k));
            return kq;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", CKN(4, 8));
        }
    }

}


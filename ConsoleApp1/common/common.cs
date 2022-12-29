using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.common
{
    internal class common
    {
        public static int GT(int n)
        {
            int p = 1;
            for (int i = 1; i <= n; i++)
            {
                p = p * i;
            }
            return p;
        }

        public static float calSN(float x, int n)
        {
            float p = 1;
            for (int i = 1; i <= n; i++)
            {
                p = p * x;
            }
            return p;
            static void calSN(float x, int n)
            {
                if (n >= 0)
                {
                    float kq = xn(x, n);
                    Console.WriteLine("{0}^{1}={2}", x, n, kq);
                }
                else
                {
                    n = Math.Abs(n);
                    float kq = 1.0f / xn(x, n);
                    Console.WriteLine("{0}^{1}={2}", x, n, kq);
                }
            }
        }

        public static void CBM(int x, int y, int n, int m)
        {
            double giatri = Math.Pow(x + y, (float)n / m);
            Console.WriteLine("{0}", giatri);
        }

        public static int CKN(int k, int n)
        {
            int kq = GT(n) / (GT(k) * GT(n - k));
            return kq;
        }

        public static float xn(float x,int n) { 
            float p = 1;
            for (int i = 1; i <= n; i++)
            {
                p = p* x;
    }
            return p;
            
        }
        
        public static int tong(int a,int b)
        {
            return a + b;
        }

        public static int tong(int a, int b,int c)
        {
            return a + b+c;
        }
        //cong chuoi bang toan tu :
        public static string congchuoi(string a,string b)
        {
            return a + " " + b;
        }
        //cong bang ham :
        public static string congchuoifunc(string a, string b)
        {
            return string.Concat(a, " ", b);
        }
        public static string ChuoiHoa(string x)
        {
            return x.ToUpper();
        }
        public static string ChuoiThuong(string x)
        {
            return x.ToLower();
        }

        public static bool CheckHoa(string x)
        {
            for(int i = 0; i < x.Length; i++) {
                if (x[i]>=65 && x[i] <= 90)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static bool ChecksoChuoi1(string x)
        {
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] >= 48 && x[i] <= 57)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool ChecksoChuoi2(string x)
        {
            int dem = 0;
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] >= 48 && x[i] <= 57)
                    {
                        dem++;
                    }

                }
                if (dem == x.Length)
                {
                    return true;
                }
                return false;
            }
        }

    }
}

using ConsoleApp1.common;
using System.Xml.Linq;

namespace Project
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", common.CKN(4, 8));
            Console.WriteLine("{0}", common.calSN(3, 4));
            //goi chuoi
            Console.WriteLine("{0}", common.congchuoi("Truong Hao", "Nam"));
            Console.WriteLine("{0}", common.congchuoifunc("Hao Nam", "Truong"));
            Console.WriteLine("{0}", common.ChuoiHoa("Hao Nam Truong"));
            Console.WriteLine("{0}", common.ChuoiThuong("Truong Hao Nam"));


            if (common.CheckHoa("adfhusdes"))
            {
                Console.WriteLine("co chua");
            }
            else
            {
                Console.WriteLine("khong co chua");
            }
            if (common.ChecksoChuoi1("fhsjhfs333"))
            {
                Console.WriteLine("co chua");
            }
            else
            {
                Console.WriteLine("khong co chua");
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot7
{
    internal class multicastDelegate
    {
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";
            MyDelegate MyDele01 = MyClass.Print;
            MyDelegate MyDele02 = MyClass.Show;
            Console.WriteLine("**Combine MyDele01 + MyDele02*** ");
            MyDelegate mydele = MyDele01 + MyDele02;
            mydele(msg);
            Console.WriteLine("***Combine Mydele01 + MyDele02 + MyDele03***");
            MyDelegate mydele03 = MyClass.Display;
            mydele += mydele03;
            mydele(msg);
            Console.WriteLine("---------");
            Console.WriteLine("***Remove mydele02***");
            mydele -= MyDele02;
            mydele("Hello Word");
            Console.ReadLine();

        }
    }
}

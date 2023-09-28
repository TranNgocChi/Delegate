using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot7
{
    public delegate void PrintDetail(string msg);

    internal class evenDelegate
    {
        event PrintDetail Print;
        void show(string msg) => Console.WriteLine(msg.ToUpper());    
        static void Main(string[] args)
        {
            evenDelegate e = new evenDelegate();
            e.Print += new PrintDetail(e.show);
            e.Print("Hello TG");
            Console.ReadLine();
        }
    }
}

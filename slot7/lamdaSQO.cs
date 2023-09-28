using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot7
{
    internal class lamdaSQO
    {
        static void Main(string[] args)
        {
            string[] names = { "Messi", "Ronado", "Mabppe", "Alvarez"};
            foreach(string item in names.OrderBy(a => a))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

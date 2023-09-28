using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot7
{
    public delegate void MyDelegate(string msg);
    class MyClass
    {
        public static void Print(string message) => Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) => Console.WriteLine($"{message.ToLower()}");
    }
    internal class passDelegate
    {
        static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);
        static void Main(string[] args)
        {
            string msg = "Passing Delegate as a parameter";
            InvokeDelegate(MyClass.Print, msg);
            InvokeDelegate(MyClass.Show, msg);
            Console.ReadLine();
        }        
    }
}

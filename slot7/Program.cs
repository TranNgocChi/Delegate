public delegate int MyDelegate(int numberOne, int numberTwo);
class Program
{
    static int Add(int numberOne, int numberTwo) => numberOne + numberTwo;
    static int Substract(int numberOne, int numberTwo) => numberOne - numberTwo;

    static void Main(string[] args)
    {
        int n1 = 25;
        int n2 = 15;
        int result;
        MyDelegate obj1 = new MyDelegate(Add);
        result = obj1(n1,n2);
        Console.WriteLine($"{n1}+{n2} = {result}");
        MyDelegate obj2 = Substract;
        result = obj2.Invoke(n1,n2);
        Console.WriteLine($"{n1}-{n2} = {result}");
        Console.ReadLine();
    }
}
//string a = Console.ReadLine();
//string b = "Hello my name is prakash";
//if (b[0]=='j')
//{
//   Console.WriteLine(b);
//}
//int time = 18;
//Console.WriteLine((time < 15) ? "good morning" : "good evening");

//int[] a = {1,2,3,4,5};
//foreach (int i in a)
//{   
//if (i == 2)
//    break;
//  Console.WriteLine(i);
//}

using System;
using HelloWorld;

class car
{
    public string color = "red";
}
class Program2
{
    static void MyMethod(string a)
    {
        Console.WriteLine($"MyMethod Executed {a}");
    }
    static class staticdemo
    {
        static int x = 10, y;
        public static int calculate()
        {
            return x * x;
        }
    }
    static void Main(string[] args)
    {
        MyMethod("Variable");

        car myobj = new car();
        Console.WriteLine(myobj.color);

        Ccar mycar = new Ccar();

        demo mydemo = new demo();
        Console.WriteLine(mydemo.Addition());

        partialPart partialdemo=new partialPart();
        partialdemo.method1();
        partialdemo.method2();

        Console.WriteLine(staticdemo.calculate());

    }

}
class demo
{
    int x = 5;
    int y = 8;
    /// <summary>
    /// addition of
    /// two numbers
    /// </summary>
    /// <returns>sum</returns>
    public int Addition()
    {
        return x + y;
    }
}
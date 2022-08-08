using System;
namespace oops
{
    //Base Class
    public class Father
    {

        //constructor
        public Father()
        {
            Console.WriteLine("Father class constructor");
        }

        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

    //Derived class
    public class Child : Father
    {
        public Child()
            : base()
        {
            Console.WriteLine("child class constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
    class Inheritance
    {
        //Entry point
        static void Main(string[] args)
        {
            //Here Child object can access both class methods
            Child cObj = new Child();
            cObj.FatherMethod();
            cObj.ChildMethod();
            Console.ReadKey();
        }
    }
}
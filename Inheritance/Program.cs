using System;


namespace Inheritance {
    class SuperClass
    { // Parent class 
        public virtual void output()
        {
            Console.WriteLine("In Super Class..");
        }
    }
}

namespace Inheritance {
    class SubClass : SuperClass // Child Class
    {
        public override void output()
        {
            base.output();
            Console.WriteLine("In Sub Class...");
        }
    }
}

namespace Inheritance
{
  
    class Program
    {
        
        static void Main(string[] args)
        {
            SuperClass obj = new SubClass();
            obj.output();

           Console.ReadKey();
        }
    }
}

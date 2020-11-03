using System;

namespace Show_Student_data_by_Inheeritance
{
    public class Person 
    {
        int id;
        String name;

        public virtual void setdata() {
            
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Convert.ToString(Console.ReadLine());

        }

        public virtual void showdata() {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
        }
    }

    public class Student : Person
    {
        int marks;
        String grade;

        public override void setdata()
        {
            base.setdata();

            Console.Write("Enter Marks: ");
            marks = int.Parse(Console.ReadLine());

            Console.Write("Enter Grade: ");
            grade = Convert.ToString(Console.ReadLine());

        }

        public override void showdata()
        {
            base.showdata();

            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Grade: " + grade);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Person obj = new Student();
            obj.setdata();
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("\t\tOutput");
            Console.WriteLine("__________________________________________________");
            obj.showdata();

            Console.ReadKey();
        }
    }
}

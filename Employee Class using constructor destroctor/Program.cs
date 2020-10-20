using System;

namespace Employee_class_with_constructor
{
    public class Employee {
        int id, monthly_salary;
        String name;

        public Employee(int id, string name, int monthly_salary) {
            this.id = id;
            this.name = name;
            if (monthly_salary < 0)
            {
                monthly_salary = -1;
            }
            else
                this.monthly_salary = monthly_salary;
        }

        ~Employee() {
            Console.Write("Constructor was Destroyed");
        }

        public int ID {
            get {

                return ID;
            }
            set {
                id = value;
            }
        } //ID Closing Bracket

        public string NAME {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        } // NAME Closing bracket

        public int salary {
            get {
                return monthly_salary;
            }

            set {
                if (monthly_salary < 0)
                {
                    monthly_salary = -1;
                }
                else {
                    monthly_salary = value;
                }
            }
        } // salary closing bracket

        public double yearly_salary()
        {
            int sal = monthly_salary * 12;
            double per = (4.0 / 100) * monthly_salary;
            return per;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "JOHN", 20000);
            Employee emp2 = new Employee(2, "DAVID", 70000);

            //emp2.ID = 11;
            //emp2.NAME = "DAVID";
            //emp2.salary = 200;

            Console.Write("Yearly Salary of {0} is: {1}", emp1.NAME, emp1.yearly_salary() + "\n");
            Console.Write("Yearly Salary of {0} is: {1} ", emp2.NAME, emp2.yearly_salary());

            Console.ReadKey();

        }
    }
}

using System;

namespace EmployeeDetails
{
    class Employee
    {
        int id;
        string name;
        int age;
        int mobileno;
        public void setEmployee(int id, string name, int age, int mobileno)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.mobileno = mobileno;
        }
        public void getEmployee()
        {
            Console.WriteLine("Employee_Id is: {0}", this.id);
            Console.WriteLine("Employee_Name is: {0}", this.name);
            Console.WriteLine("Employee_age is: {0}", this.age);
            Console.WriteLine("Employee_Contact number is: {0}", this.mobileno);
        }



        //class Program
        //{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee_Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee_ Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee_Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Contact Number: ");
            int mobileno = int.Parse(Console.ReadLine());
            Employee obj = new Employee();
            obj.setEmployee(id, name, age, mobileno);
            obj.getEmployee();
            Console.WriteLine("...............");
            Console.ReadLine();

        }
    }
}
//}

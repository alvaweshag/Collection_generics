using System;
using System.Collections.Generic;

namespace Collection_generics // Alva Westrin Haglund .Net22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating new employees
            Employee emp = new Employee("bamse123", "Alva", "kvinna", 12000);
            Employee emp1 = new Employee("ursula98", "Annika", "kvinna", 20900);
            Employee emp2 = new Employee("Peter_Pan", "Alfred", "man", 35020);
            Employee emp3 = new Employee("Na11epuh", "Alex", "ickebinär", 42000);
            Employee emp4 = new Employee("ayayay12345", "Arnold", "man", 22222);

            // Making a stack and pushing in employees
            Stack<Employee> employeeStack = new Stack<Employee>();

            employeeStack.Push(emp);
            employeeStack.Push(emp1);
            employeeStack.Push(emp2);
            employeeStack.Push(emp3);
            employeeStack.Push(emp4);

            // Writes out all the current employees in stack
            foreach (Employee e in employeeStack)
            {
                Console.WriteLine("Employee: " + e.Id + ", " + e.Name + ", " + e.Gender + ", " + e.Salary);

                Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            }

            Console.WriteLine("  ");

            // POP method
            Employee em = employeeStack.Pop();
            Console.WriteLine("Employee: " + em.Id + ", " + em.Name + ", " + em.Gender + ", " + em.Salary);
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Employee em1 = employeeStack.Pop();
            Console.WriteLine("Employee: " + em1.Id + ", " + em1.Name + ", " + em1.Gender + ", " + em1.Salary);
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Employee em2 = employeeStack.Pop();
            Console.WriteLine("Employee: " + em2.Id + ", " + em2.Name + ", " + em2.Gender + ", " + em2.Salary);
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Employee em3 = employeeStack.Pop();
            Console.WriteLine("Employee: " + em3.Id + ", " + em3.Name + ", " + em3.Gender + ", " + em3.Salary);
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Employee em4 = employeeStack.Pop();
            Console.WriteLine("Employee: " + em4.Id + ", " + em4.Name + ", " + em4.Gender + ", " + em4.Salary);
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
            Console.WriteLine();

            // Pushes the employees back in stack
            employeeStack.Push(emp);
            employeeStack.Push(emp1);
            employeeStack.Push(emp2);
            employeeStack.Push(emp3);
            employeeStack.Push(emp4);

            Console.WriteLine("  ");

            // PEEK method
            Employee empl = employeeStack.Peek();
            Console.WriteLine("Employee: " + empl.Id + ", " + empl.Name + ", " + empl.Gender + ", " + empl.Salary);
            Console.WriteLine("Number of elements in Stack: {0}", employeeStack.Count);

            Employee emplo = employeeStack.Peek();
            Console.WriteLine("Employee: " + emplo.Id + ", " + emplo.Name + ", " + emplo.Gender + ", " + emplo.Salary);
            Console.WriteLine("Number of elements in Stack: {0}", employeeStack.Count);

            Console.WriteLine("  ");

            // Checks if stack contains object 3
            Console.WriteLine(employeeStack.Contains(emp3));

            Console.WriteLine("  ");
            Console.WriteLine("  ");

            // LIST 
            Employee employee = new Employee("lilleskutt123", "Barbro", "kvinna", 124000);
            Employee employee1 = new Employee("ariel98", "Birgitta", "kvinna", 204900);
            Employee employee2 = new Employee("tingeling", "Bengt", "man", 350200);
            Employee employee3 = new Employee("na55e", "Boris", "ickebinär", 4200000);
            Employee employee4 = new Employee("yayayaya111", "Billy", "man", 22222000);

            List<Employee> EmployeeList = new List<Employee>();

            // Adds all employees to list
            EmployeeList.Add(employee);
            EmployeeList.Add(employee1);
            EmployeeList.Add(employee2);
            EmployeeList.Add(employee3);
            EmployeeList.Add(employee4);

            // Check if employee2 exists in list
            if (EmployeeList.Contains(employee2) == true)
            {
                Console.WriteLine(employee2.Name + " " + "object exists in the list");
            }
            else
            {
                Console.WriteLine(employee2.Name + " " + "object does not exist in the list");
            }

            Console.WriteLine("  ");

            // Finds and writes out the first employee with gender "man"
            var male = (EmployeeList.Find(x => x.Gender == "man"));
            Console.WriteLine(male.Id + " " + male.Name);

            Console.WriteLine(" ");

            // Finds and writes out all employees with gender "man"
            List<Employee> GenderResult = new List<Employee>(EmployeeList.FindAll(i => i.Gender == "man"));

            foreach (Employee a in GenderResult)
            {
                Console.WriteLine(a.Id + ", " + a.Name + ", " + a.Gender + ", " + a.Salary);
            }
        }
    }
}

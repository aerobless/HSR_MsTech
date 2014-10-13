using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries1
{
    static class Program
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
                action(item);
        }

        static void Main(string[] args)
        {
            var departments = new List<Department>
            {
                new Department {Name = "Engineering", Id = 1},
                new Department {Name = "Marketing", Id = 2}
            };

            var employees = new List<Employee> 
            {
                new Employee { Name = "Michael", Address = "SW Liverpool Lane", State = "WA", Salary = 5675, DepId = 1},
                new Employee { Name = "Jennifer", Address = "1245 NW Baypony Dr", State = "OR", Salary = 6555,DepId = 1},
                new Employee { Name = "Sean", Address = "55217 SW Estate Dr", State = "WA", Salary = 8888, DepId = 1},
                new Employee { Name = "Peter", Address = "Ma Lane", State = "WA", Salary = 9999, DepId = 2},
                new Employee { Name = "Henry", Address = "Ma Dr", State = "OR", Salary = 3209, DepId = 2}
            };

            
            // ------------------------------------------------------------------------------------------- //
            // Liste der Mitarbeiter die im State WA wohnen. 

            //var queryWashington = ;
            var queryWashington = ;

            Console.WriteLine("Names in the state of Washington: ");
            queryWashington.ForEach(e => Console.WriteLine(e.Name));

            
            // ------------------------------------------------------------------------------------------- //
            // Liste der Namen und Adressen der Mitarbeiter im State WA. 
            // Sortiert nach Name absteigend. 

            //var queryWashingtonSorted = ;
            var queryWashingtonSorted = ;

            Console.WriteLine("Names and Contacts in the state of Washington: ");
            queryWashingtonSorted.ForEach(e => Console.WriteLine("Name: {0}, Phone: {1}", e.Name, e.Address));


            // ------------------------------------------------------------------------------------------- //
            // Liste der Namen und der Anzahl Mitarbeiter der Departments.  

            //var queryDepartments = ;
            var queryDepartments = ;

            Console.WriteLine("Departments and Employee Count: ");
            queryDepartments.ForEach(d => Console.WriteLine("Department: {0}, EmployeeCount: {1}", d.Department, d.EmployeeCount));

            
            // ------------------------------------------------------------------------------------------- //
            // Liste der Departments mit ihren Mitarbeitern. 
            // Ausgabe: Name des Departments, Name des Mitarbeiters
            // Sortiert nach Departmentname 

            //var empQuery = ;
            var empQuery = employees ;


            Console.WriteLine("Employees and their departments: ");
            empQuery.ForEach(c => Console.WriteLine("Name: {0}, Department: {1}", c.EmployeeName, c.DepartmentName));
            
            Console.WriteLine("press key to exit");
            Console.ReadLine();
        }
    }
}

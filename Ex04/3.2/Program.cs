using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries2
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

            var queryTeuerster = employees.Where(e => e.State == "WA").MaxElement(e => e.Salary);

            if (queryTeuerster != null)
                Console.WriteLine("Teuerster Mitarbeiter in WA / Name: {0}, Salary {1}", queryTeuerster.Name, queryTeuerster.Salary);
            else
                Console.WriteLine("Kein Eintrag gefunden.");

            
            Console.WriteLine("press key to exit");
            Console.ReadLine();
        }
    }
}

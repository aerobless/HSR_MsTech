namespace Queries1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int Salary { get; set; }
        public int DepId { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}

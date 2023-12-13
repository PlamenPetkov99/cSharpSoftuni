using System.Xml.Linq;

namespace company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4
            Peter 120.00 Development
            Tony 333.33 Marketing
            Jony 840.20 Development
            George 0.20 Nowhere
             */
            string nameOfDepartmentWithMostSalary = string.Empty;
            double maxAverage = double.MinValue;
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split().ToArray();
                string name = inputLine[0];
                double salary = double.Parse(inputLine[1]);
                string department = inputLine[2];

                Employee employee = new Employee(name,salary,department);
                employees.Add(employee);
            }

            foreach (Employee employee in employees)
            {
                string currentDepartment = employee.Department;
                List<Employee> currentDepartList = employees.Where(x => x.Department == currentDepartment).ToList();
                int peopleInDepartment = currentDepartList.Count;
                double currentTotal = 0;
                foreach (Employee employeeInDepart in currentDepartList)
                {
                    currentTotal += employeeInDepart.Salary;
                }
                currentTotal = currentTotal / peopleInDepartment;
                if(currentTotal > maxAverage)
                {
                    nameOfDepartmentWithMostSalary = currentDepartment;
                    maxAverage = currentTotal;
                }
            }

            List<Employee> toPrintList = employees.Where(x => x.Department == nameOfDepartmentWithMostSalary).ToList();
            toPrintList = toPrintList.OrderByDescending(x=> x.Salary).ToList();
            
            Console.WriteLine($"Highest Average Salary: {nameOfDepartmentWithMostSalary}");
            foreach (Employee emp in toPrintList)
            {
                Console.WriteLine($"{emp.Name} {emp.Salary,0:F2}");
            }

        }

        public class Employee
        {
            public string Name { get; set; }

            public double Salary { get; set; }

            public string Department { get; set; }

            public Employee(string name , double salary , string department) 
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
            
            public Employee() { 
            }

            public override string ToString()
            {
                return $"{Name} {Salary,0:F2}";
            }

        }
    }
    
}

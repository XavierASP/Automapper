using System.Collections.Generic;

public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public int Salary { get; set; }

    public static IEnumerable<Employee> SetupEmployee()
    {
        return new List<Employee>()
        {
            new Employee(){EmployeeId = 1, EmployeeName ="First", Salary=10000},
            new Employee(){EmployeeId = 2, EmployeeName ="Second", Salary=20000},
            new Employee(){EmployeeId = 3, EmployeeName ="Third", Salary=30000},
            new Employee(){EmployeeId = 4, EmployeeName ="Fourth", Salary=40000},
            new Employee(){EmployeeId = 5, EmployeeName ="Fifth", Salary=50000}
        };
    }

}
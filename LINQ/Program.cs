public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public decimal Salary { get; set; }
    public List<string?> Skills { get; set; }
}

public class Project
{
    public int ProjectId { get; set; }
    public int EmployeeId { get; set; }
    public string? ProjectName { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Ankit Ranjan",
                Department = "IT",
                Salary = 75000m,
                Skills = new List<string> { "C#", "ASP.NET", "LINQ" }
            },
            new Employee
            {
                Id = 2,
                Name = "Sandeep Reddy",
                Department = "HR",
                Salary = 60000m,
                Skills = new List<string> { "Recruitment", "Communication" }
            },
            new Employee
            {
                Id = 3,
                Name = "Rahul Sharma",
                Department = "Finance",
                Salary = 68000m,
                Skills = new List<string> { "Accounting", "Excel", "Communication" }
            },
            new Employee
            {
                Id = 4,
                Name = "Priya Singh",
                Department = "IT",
                Salary = 82000m,
                Skills = new List<string> { "Java", "Spring Boot" ,"Communication"}
            },
            new Employee
            {
                Id = 5,
                Name = "Amit Verma",
                Department = "Marketing",
                Salary = 55000m,
                Skills = new List<string> { "SEO", "Content Marketing" }
            },
            new Employee
            {
                Id = 6,
                Name = "Neha Gupta",
                Department = "IT",
                Salary = 90000m,
                Skills = new List<string> { "React", "TypeScript" }
            },
            new Employee
            {
                Id = 7,
                Name = "Rohit Kumar",
                Department = "Support",
                Salary = 48000m,
                Skills = new List<string> { "Customer Support", "CRM" }
            },
            new Employee
            {
                Id = 8,
                Name = "Pooja Mehta",
                Department = "Finance",
                Salary = 72000m,
                Skills = new List<string> { "Taxation", "Auditing" }
            },
            new Employee
            {
                Id = 9,
                Name = "Vikas Patel",
                Department = "IT",
                Salary = 88000m,
                Skills = new List<string> { "DevOps", "AWS" }
            },
            new Employee
            {
                Id = 10,
                Name = "Kiran Rao",
                Department = "HR",
                Salary = 50000m,
                Skills = new List<string> { "Office Management", "Documentation" }
            }
        };

        List<Project> projects = new List<Project>
        {
            new Project
            {
                ProjectId = 1,
                EmployeeId = 1,
                ProjectName = "E-Commerce Platform"
            },
            new Project
            {
                ProjectId = 2,
                EmployeeId = 4,
                ProjectName = "Mobile Banking App"
            },
            new Project
            {
                ProjectId = 3,
                EmployeeId = 6,
                ProjectName = "Customer Portal"
            },
            new Project
            {
                ProjectId = 4,
                EmployeeId = 9,
                ProjectName = "Cloud Migration"
            },
            new Project
            {
                ProjectId = 5,
                EmployeeId = 1,
                ProjectName = "Inventory Management"
            },
            new Project
            {
                ProjectId = 6,
                EmployeeId = 3,
                ProjectName = "Financial Reporting System"
            },
            new Project
            {
                ProjectId = 7,
                EmployeeId = 8,
                ProjectName = "Tax Calculation Module"
            },
            new Project
            {
                ProjectId = 8,
                EmployeeId = 5,
                ProjectName = "Digital Marketing Campaign"
            },
            new Project
            {
                ProjectId = 9,
                EmployeeId = 7,
                ProjectName = "Help Desk System"
            },
            new Project
            {
                ProjectId = 10,
                EmployeeId = 2,
                ProjectName = "Employee Onboarding Portal"
            }
        };

        // Salary Review Candidates
        // HR needs a list of employees earning more than ₹60,000 for annual salary review
        var SalaryEmp = employees.Where(s => s.Salary > 60000)
                                 .ToList();
        foreach(var sal in SalaryEmp)
        {
            Console.WriteLine($"Name: {sal.Name} \nDepartment: {sal.Department}\nSalary: {sal.Salary}");
        }

        var OnlyEmp = employees.Where(s => s.Skills.Contains("Communication")).Select(s => s.Name).ToList();
        foreach(var i in OnlyEmp)
        {
            Console.WriteLine($"Skill with communication {i}");
        }

        // HR Department Presence
        var HrEmp = employees.Any(s => s.Department.Equals("HR"));
        Console.WriteLine(HrEmp);

        // Department-Wise Headcount
        // Create a report showing number of employees in each department.
        // Output:
        // {Department, Count}
        var DepartmentCount = employees.GroupBy(s => s.Department)
                                       .ToDictionary(g => g.Key,g => g.Count());
                                    
        foreach(var i in DepartmentCount)
        {
            Console.WriteLine($"Department Name : {i.Key} and DepartmentCount: {i.Value}");
        }

        // Highest-Paid Employee
        var HighestEmp = employees.OrderByDescending(s => s.Salary)
                                  .First();
        Console.WriteLine($"Heighest Salary Paid in Organization {HighestEmp.Name}");

        // Salary-Based Sorting
        // Produce a list of employees:
        // Sorted by salary (descending)
        // If salaries match, sorted by name (ascending)
        var SortingBased = employees.OrderByDescending(s => s.Salary)
                                    .ThenBy(e => e.Name);
        foreach(var i in SortingBased)
        {
            Console.WriteLine($"Name : {i.Name} and Salary : {i.Salary}");
        }

        // Project Allocation Report
        // Output: { EmployeeName, ProjectName }
        var ProjectAllocated = employees.Join(projects,
                                              e => e.Id,
                                              p => p.ProjectId,
                                              (e,p)=> new {
                                                EmployeeName = e.Name,
                                                ProjectName = p.ProjectName
                                            }).ToList();
        foreach(var i in ProjectAllocated)
        {
            Console.WriteLine($"Employee Name: {i.EmployeeName} and ProjectName: {i.ProjectName}");
        }
        // Top Earners by Department
        // For each department, retrieve the top 3 highest-paid employees.
        // Output:
        // {
        // Department,
        // TopEmployees
        // }
        var topstudents = employees.GroupBy(e => e.Department)
                                   .Select(s => new
                                   {
                                       Department = s.Key,
                                       TopEarners = s.OrderByDescending(x => x.Salary)
                                                     .Take(3)
                                                     .ToList()
                                   }).ToList();
        foreach(var i in topstudents)
        {
            Console.WriteLine($"Department {i.Department}");
            foreach(var j in i.TopEarners)
            {
                Console.WriteLine($"Top {j.Salary} and Name: {j.Name}");
            }
        }
    }
}

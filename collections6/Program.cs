using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var college = new College("VTU University");
            college.AddDepartment("Computer Science");
            college.AddDepartment("Mathematics");
            college.DisplayDepartments();
            college.RemoveDepartment("Mathematics");
            college.DisplayDepartments();
            Console.ReadLine();
        }

    }
}
public class College
{
    public string Name
    {
        get;
        set;
    }
    private List<string> Departments
    {
        get;
        set;
    }

    public College(string name)
    {
        Name = name;
        Departments = new List<string>();
    }
    public void AddDepartment(string departmentName)
    {
        Departments.Add(departmentName);
    }
    public void RemoveDepartment(string departmentName)
    {
        Departments.Remove(departmentName);
    }
    public void DisplayDepartments()
    {
        Console.WriteLine("Departments in (VTU University):");
        foreach (var department in Departments)
        {
            Console.WriteLine(department);
        }
    }
}

       

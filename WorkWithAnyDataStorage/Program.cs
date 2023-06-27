using WorkWithAnyDataStorage.Data;
using WorkWithAnyDataStorage.Reprository;

namespace WorkWithAnyDataStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataReprository<Employee> employeeData = new DataReprository<Employee>();

            Employee employee1 = new Employee(firstName: "Jack", lastName: "Chen");
            employeeData.Load(employee1);
            employeeData.Load(new Employee(firstName: "Doc", lastName: "Gruff"));
            employeeData.Load(new Employee(firstName: "John", lastName: "Timiy"));

            employeeData.Save();

            Console.WriteLine($"Employee with ID 1 is {employeeData.GetByID(1).FirstName}");

            DataReprository<Organization> orgData = new DataReprository<Organization>();

            orgData.Load(new Organization(name: "GitHub"));
            orgData.Load(new Organization(name: "Microsoft"));

            orgData.Save();

            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreDO.Models.DataLayer;

namespace BookStoreDO.DataAccessClasses;

public partial class BookStoreDataAccess
{
    public List<Employee> GetEmployees() => Context.Employees.ToList();

    public Employee? GetEmployee(string id) => Context.Employees.Find(id);

    public void AddEmployee(Employee employee)
    {
        Context.Employees.Add(employee);
        Context.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
        Context.Employees.Update(employee);
        Context.SaveChanges();
    }

    public void DeleteEmployee(Employee employee)
    {
        Context.Employees.Remove(employee);
        Context.SaveChanges();
    }

    //To validate employee I need job database
    public Job? GetJob(short jobId) => Context.Jobs.Find(jobId);
    public List<Job> GetJobs() => Context.Jobs.ToList();
}

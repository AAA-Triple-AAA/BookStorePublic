using BookStoreDO.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDO.DataAccessClasses;

public partial class BookStoreDataAccess
{
    public List<Employee> GetEmployees() =>     Context.Employees.ToList();

    public Employee? GetEmployee(string id) => Context.Employees.Find(id);

    public void AddEmployee(Employee employee)
    {
        Context.Employees.Add(employee);
        Context.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
        EnsurePublisherAttached(employee);
        EnsureJobAttached(employee);

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

    private void EnsurePublisherAttached(Employee employee)
    {
        var publisherNav = employee.Pub;
        if (publisherNav == null) return;

        var tracked = Context.Publishers.Local.FirstOrDefault(p => p.PubId == publisherNav.PubId)
                      ?? Context.Publishers.Find(publisherNav.PubId);

        if (tracked != null) employee.Pub = tracked;
        else Context.Entry(publisherNav).State = EntityState.Unchanged;
    }

    private void EnsureJobAttached(Employee employee)
    {
        var jobIdNav = employee.Job;
        if (jobIdNav == null) return;

        var tracked = Context.Jobs.Local.FirstOrDefault(j => j.JobId == jobIdNav.JobId)
                      ?? Context.Jobs.Find(jobIdNav.JobId);

        if (tracked != null) employee.Job = tracked;
        else Context.Entry(jobIdNav).State = EntityState.Unchanged;
    }
}

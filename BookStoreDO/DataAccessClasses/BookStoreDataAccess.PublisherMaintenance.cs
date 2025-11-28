using BookStoreDO.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDO.DataAccessClasses;

public partial class BookStoreDataAccess
{
    public List<Publisher> GetPublishers() => Context.Publishers.ToList();

    public Publisher? GetPublisher(string id) => Context.Publishers.Find(id);

    public void AddPublisher(Publisher publisher)
    {
        Context.Publishers.Add(publisher);
        Context.SaveChanges();
    }

    public void UpdatePublisher(Publisher publisher)
    {
        Context.Publishers.Update(publisher);
        Context.SaveChanges();
    }

    public void DeletePublisher(Publisher publisher)
    {
        Context.Publishers.Remove(publisher);
        Context.SaveChanges();
    }
}
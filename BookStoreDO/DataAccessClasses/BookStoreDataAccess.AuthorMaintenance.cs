using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreDO.Models.DataLayer;

namespace BookStoreDO.DataAccessClasses;

public partial class BookStoreDataAccess
{
    public List<Author> GetAuthors() => Context.Authors.ToList();

    public Author? GetAuthor(string id) => Context.Authors.Find(id);

    public void AddAuthor(Author author)
    {
        Context.Authors.Add(author);
        Context.SaveChanges();
    }

    public void UpdateAuthor(Author author)
    {
        Context.Authors.Update(author);
        Context.SaveChanges();
    }

    public void DeleteAuthor(Author author)
    {
        Context.Authors.Remove(author);
        Context.SaveChanges();
    }
}

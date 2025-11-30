using System.Collections.Generic;
using System.Linq;
using BookStoreDO.Models.DataLayer;

namespace BookStoreDO.DataAccessClasses
{
    public partial class BookStoreDataAccess
    {

        public List<Store> GetStores() => Context.Stores.ToList();

        // If you need full CRUD functionality later:
        public Store? GetStore(string storId) => Context.Stores.Find(storId);

        public void AddStore(Store store)
        {
            Context.Stores.Add(store);
            Context.SaveChanges();
        }

        public void UpdateStore(Store store)
        {
            Context.Stores.Update(store);
            Context.SaveChanges();
        }

        public void DeleteStore(Store store)
        {
            Context.Stores.Remove(store);
            Context.SaveChanges();
        }
    }
}

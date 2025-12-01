using System.Collections.Generic;
using System.Linq;
using BookStoreDO.Models.DataLayer; 
using Microsoft.EntityFrameworkCore;

namespace BookStoreBO
{
    public class StoreManager
    {
        
        private readonly BookStoreContext _context;

        public StoreManager()
        {
            _context = new BookStoreContext();
        }

        public List<Store> GetAllStores()
        {
            return _context.Stores
                           .OrderBy(s => s.StorName)
                           .ToList();
        }

        public Store? GetStoreById(string id)
        {
            return _context.Stores.Find(id);
        }

        public List<Store> SearchStores(string term)
        {
            if (term == null) term = "";
            term = term.Trim();

            return _context.Stores
                .Where(s =>
                    s.StorId.Contains(term) ||
                    (s.StorName ?? "").Contains(term) ||
                    (s.City ?? "").Contains(term))
                .OrderBy(s => s.StorName)
                .ToList();
        }

        public void AddStore(Store store)
        {
            _context.Stores.Add(store);
            _context.SaveChanges();
        }

        public void UpdateStore(Store store)
        {
            _context.Stores.Update(store);
            _context.SaveChanges();
        }

        public void DeleteStore(string id)
        {
            var store = _context.Stores.Find(id);
            if (store != null)
            {
                _context.Stores.Remove(store);
                _context.SaveChanges();
            }
        }
    }
}

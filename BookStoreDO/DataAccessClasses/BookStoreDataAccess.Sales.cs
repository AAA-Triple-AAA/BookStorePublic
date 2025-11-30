using System;
using System.Collections.Generic;
using BookStoreDO.Models.DataLayer;

namespace BookStoreDO.DataAccessClasses
{
    public partial class BookStoreDataAccess
    {
        public string CreateOrder(
            string storId,
            DateTime orderDate,
            IEnumerable<(string TitleId, int Quantity)> items,
            string payterms = "NET 30")
        {
            string ordNum = $"ORD-{DateTime.Now:yyyyMMddHHmmss}";

            foreach (var item in items)
            {
                var sale = new Sale
                {
                    StorId = storId,
                    OrdNum = ordNum,
                    OrdDate = orderDate,
                    Qty = (short)item.Quantity,
                    Payterms = payterms,
                    TitleId = item.TitleId
                };

                Context.Sales.Add(sale);
            }

            Context.SaveChanges();
            return ordNum;
        }
    }
}

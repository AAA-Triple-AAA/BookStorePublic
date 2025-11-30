using System;
using System.Collections.Generic;
using System.Linq;
using BookStoreDO.Models.DataLayer;

namespace BookStoreDO.DataAccessClasses
{
    public partial class BookStoreDataAccess
    {
        /// <summary>
        /// Returns all rows from the sales table (in case you want to see them later).
        /// </summary>
        public List<Sale> GetSales() => Context.Sales.ToList();

        /// <summary>
        /// Creates a new order in the SALES table.

        // storId -> selected store

        // ordDate -> order date

        // items -> list (TitleId, Quantity)

        // Returns the generated order number.
        /// </summary>
        public string CreateOrder(string storId, DateTime ordDate,
            List<(string TitleId, int Quantity)> items)
        {
            if (string.IsNullOrWhiteSpace(storId))
                throw new ArgumentException("storId is required.", nameof(storId));

            if (items == null || items.Count == 0)
                throw new ArgumentException("At least one item is required.", nameof(items));

            // A “nice” and unique order number within your database
            string ordNum = $"ORD-{DateTime.Now:yyyyMMddHHmmss}";

            foreach (var (titleId, qty) in items)
            {
                // SMALLINT en la tabla -> casteamos
                short quantity = (short)qty;

                var sale = new Sale
                {
                    StorId = storId,
                    OrdNum = ordNum,
                    OrdDate = ordDate,
                    Qty = quantity,
                    Payterms = "Net 30",  
                    TitleId = titleId
                };

                Context.Sales.Add(sale);
            }

            // VERY important: save the changes
            Context.SaveChanges();

            return ordNum;
        }

        /// <summary>
        /// Optional: Get all rows from a specific order.
        /// </summary>
        public List<Sale> GetSalesByOrder(string ordNum) =>
            Context.Sales.Where(s => s.OrdNum == ordNum).ToList();
    }
}

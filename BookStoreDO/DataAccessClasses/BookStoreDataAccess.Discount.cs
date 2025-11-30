using System.Collections.Generic;
using System.Linq;
using BookStoreDO.Models.DataLayer;

namespace BookStoreDO.DataAccessClasses
{
    public partial class BookStoreDataAccess
    {
        public List<Discount> GetDiscounts() => Context.Discounts.ToList();

        /// <summary>
        /// Returns the discount percentage for a store and quantity.

        // If no discount applies, returns 0.

        /// </summary>
        public decimal GetDiscountFor(string storId, int qty, bool isInitialCustomer)
        {
            var matches = Context.Discounts
                .Where(d =>

                    (

                        isInitialCustomer

                        || d.Discounttype != "Initial Customer"
                    )

                    && (d.StorId == null || d.StorId == storId)

                    && (d.Lowqty == null || qty >= d.Lowqty)
                    && (d.Highqty == null || qty <= d.Highqty)
                )
                .ToList();

            if (!matches.Any())
                return 0m;

            var totalPercent = matches.Sum(d => d.Discount1);


            return totalPercent / 100m;
        }




    }
}

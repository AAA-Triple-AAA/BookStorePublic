using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDO.DataAccessClasses;

public partial class BookStoreDataAccess
{
    public List<SalesReportItemDTO> GetReports(DateTime startTime, DateTime endTime)
    {
        var results = Context.Sales
            .Where(s => s.OrdDate >= startTime && s.OrdDate <= endTime)
            .Select(s => new
            {
                s.OrdNum,
                s.OrdDate,
                s.TitleId,
                Title = s.Title.Title1,
                Qty = (int)s.Qty,
                Price = (s.Title.Price ?? 0m)
            })
            .GroupBy(x => new { x.OrdNum, x.OrdDate, x.TitleId, x.Title })
            .Select(g => new SalesReportItemDTO(
                g.Key.OrdNum,
                g.Key.OrdDate,
                g.Key.TitleId,
                g.Key.Title,
                g.Sum(x => x.Qty),
                g.Sum(x => x.Qty * x.Price)
            ))
            .ToList();

        return results;
    }
}

public record SalesReportItemDTO(
    string OrderNum,
    DateTime OrderDate,
    string TitleId,
    string Title,
    int Qty,
    decimal TotalValue);
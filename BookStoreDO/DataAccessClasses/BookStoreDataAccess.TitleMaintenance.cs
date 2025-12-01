using System.Collections.Generic;
using System.Linq;
using BookStoreDO.Models.DataLayer;
// To avoid conflict with System.Windows.Forms.VisualStyles.VisualStyleElement.Header.Title
using TitleEntity = BookStoreDO.Models.DataLayer.Title;

namespace BookStoreDO.DataAccessClasses
{
    public partial class BookStoreDataAccess
    {

        public List<TitleEntity> GetTitles() => Context.Titles.ToList();

        public List<TitleEntity> SearchTitles(string searchText)
        {
            var query = Context.Titles.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchText = searchText.ToLower();

                query = query.Where(title =>
                    title.TitleId.ToLower().Contains(searchText) ||
                    title.Title1.ToLower().Contains(searchText));
            }

            // Those that match best first, then by alphabetical title
            return query
                .OrderByDescending(t => t.Title1.ToLower().Contains(searchText))
                .ThenBy(t => t.Title1)
                .ToList();
        }
        public TitleEntity? GetTitle(string id) => Context.Titles.Find(id);
        public void AddTitle(TitleEntity title)
        {
            Context.Titles.Add(title);
            Context.SaveChanges();
        }
        public void UpdateTitle(TitleEntity title)
        {
            Context.Titles.Update(title);
            Context.SaveChanges();
        }
        public void DeleteTitle(string id)
        {
            var title = Context.Titles.Find(id);
            if (title != null)
            {
                Context.Titles.Remove(title);
                Context.SaveChanges();
            }
        }
    }
}

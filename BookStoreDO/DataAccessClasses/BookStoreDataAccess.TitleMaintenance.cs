using BookStoreDO.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
            EnsurePublisherAttached(title);

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

        private void EnsurePublisherAttached(TitleEntity title)
        {
            var publisherNav = title.Pub;
            if (publisherNav == null) return;

            var tracked = Context.Publishers.Local.FirstOrDefault(p => p.PubId == publisherNav.PubId)
                          ?? Context.Publishers.Find(publisherNav.PubId);

            if (tracked != null) title.Pub = tracked;
            else Context.Entry(publisherNav).State = EntityState.Unchanged;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using BookStoreBO.DTOs;
using BookStoreDO.Models.DataLayer;
using System.Data;
using System.Data.SqlClient;
using BookStoreBO.DTOs;


namespace BookStoreBO
{
    public class BookStoreDataAccess
    {
        private readonly BookStoreContext _context;

        public BookStoreDataAccess()
        {
            _context = new BookStoreContext();
        }

        public List<PublisherDTO> GetPublishers(string searchTerm = "")
        {
            var query = _context.Publishers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                var term = searchTerm.ToLower();

                query = query.Where(p =>
                    p.PubName.ToLower().Contains(term) ||
                    (p.City ?? "").ToLower().Contains(term) ||
                    (p.State ?? "").ToLower().Contains(term) ||
                    (p.Country ?? "").ToLower().Contains(term));
            }

            return query
                .OrderBy(p => p.PubName)
                .Select(p => new PublisherDTO
                {
                    PubId = p.PubId,
                    PubName = p.PubName,
                    City = p.City,
                    State = p.State,
                    Country = p.Country
                })
                .ToList();
        }

        public PublisherDTO? GetPublisherById(string pubId)
        {
            var p = _context.Publishers.FirstOrDefault(x => x.PubId == pubId);
            if (p == null) return null;

            return new PublisherDTO
            {
                PubId = p.PubId,
                PubName = p.PubName,
                City = p.City,
                State = p.State,
                Country = p.Country
            };
        }

        public void InsertPublisher(PublisherDTO publisher)
        {
            var entity = new Publisher
            {
                PubId = publisher.PubId,
                PubName = publisher.PubName,
                City = publisher.City,
                State = publisher.State,
                Country = publisher.Country
            };

            _context.Publishers.Add(entity);
            _context.SaveChanges();
        }

        public void UpdatePublisher(PublisherDTO publisher)
        {
            var entity = _context.Publishers.FirstOrDefault(p => p.PubId == publisher.PubId);
            if (entity == null)
            {
                throw new InvalidOperationException("Publisher not found.");
            }

            entity.PubName = publisher.PubName;
            entity.City = publisher.City;
            entity.State = publisher.State;
            entity.Country = publisher.Country;

            _context.SaveChanges();
        }

        public void DeletePublisher(string pubId)
        {
            var entity = _context.Publishers.FirstOrDefault(p => p.PubId == pubId);
            if (entity == null) return;

            _context.Publishers.Remove(entity);
            _context.SaveChanges();
        }

    }
}

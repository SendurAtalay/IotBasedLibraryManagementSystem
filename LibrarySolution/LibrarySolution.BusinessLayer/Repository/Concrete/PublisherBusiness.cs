using LibrarySolution.BusinessLayer.Repository.Abstract;
using LibrarySolution.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySolution.BusinessLayer.Repository.Concrete
{
    public class PublisherBusiness : IDatabaseBusiness<Publisher>
    {
        public void Delete(Publisher entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Publishers.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                var entity = db.Publishers.Find(id);
                db.Publishers.Remove(entity);
                db.SaveChanges();
            }
        }

        public Publisher Get(Expression<Func<Publisher, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Publishers.Where(predicate).FirstOrDefault();
            }
        }

        public List<Publisher> GetAll()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Publishers.ToList();
            }
        }

        public List<Publisher> GetAll(Expression<Func<Publisher, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Publishers.Where(predicate).ToList();
            }
        }

        public Publisher GetById(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Publishers.Find(id);
            }
        }

        public void Insert(Publisher entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Publishers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Publisher entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Publishers.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

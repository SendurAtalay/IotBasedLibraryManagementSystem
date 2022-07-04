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
    public class CategoryBusiness : IDatabaseBusiness<BookCategory>
    {
        public void Delete(BookCategory entity)
        {
            using (var db=new LibraryManagementDbEntities())
            {
                db.BookCategories.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                var entity = db.BookCategories.Find(id);
                db.BookCategories.Remove(entity);
                db.SaveChanges();
            }
        }

        public BookCategory Get(Expression<Func<BookCategory, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.BookCategories.Where(predicate).FirstOrDefault();
            }
        }

        public List<BookCategory> GetAll()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.BookCategories.ToList();
            }
        }

        public List<BookCategory> GetAll(Expression<Func<BookCategory, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.BookCategories.Where(predicate).ToList();
            }
        }

        public BookCategory GetById(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.BookCategories.Find(id);
            }
        }

        public void Insert(BookCategory entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.BookCategories.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(BookCategory entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.BookCategories.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

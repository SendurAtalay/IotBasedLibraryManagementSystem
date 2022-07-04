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
    public class BookBusiness : IDatabaseBusiness<Book>
    {
        public void Delete(Book entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Books.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                var entity = db.Books.Find(id);
                db.Books.Remove(entity);
                db.SaveChanges();
            }
        }

        public Book Get(Expression<Func<Book, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Books.Where(predicate).FirstOrDefault();
            }
        }

        public List<Book> GetAll()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Books.ToList();
            }
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Books.Where(predicate).ToList();
            }
        }

        public Book GetById(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Books.Find(id);
            }
        }

        public void Insert(Book entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Books.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Book entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Books.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }


        public List<SP_GetBooks_Result> GetBooks()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.SP_GetBooks().ToList();
            }
        }
    }
}

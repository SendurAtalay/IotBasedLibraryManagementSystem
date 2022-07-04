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
    public class UserBusiness : IDatabaseBusiness<User>
    {
        public void Delete(User entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Users.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                var entity = db.Users.Find(id);
                db.Users.Remove(entity);
                db.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Users.Where(predicate).FirstOrDefault();
            }
        }

        public List<User> GetAll()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Users.ToList();
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Users.Where(predicate).ToList();
            }
        }

        public User GetById(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Users.Find(id);
            }
        }

        public void Insert(User entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Users.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(User entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Users.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

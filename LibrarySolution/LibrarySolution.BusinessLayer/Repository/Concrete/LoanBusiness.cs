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
    public class LoanBusiness : IDatabaseBusiness<Loan>
    {
        public void Delete(Loan entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Loans.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                var entity = db.Loans.Find(id);
                db.Loans.Remove(entity);
                db.SaveChanges();
            }
        }

        public Loan Get(Expression<Func<Loan, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Loans.Where(predicate).FirstOrDefault();
            }
        }

        public List<Loan> GetAll()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Loans.ToList();
            }
        }

        public List<Loan> GetAll(Expression<Func<Loan, bool>> predicate)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Loans.Where(predicate).ToList();
            }
        }

        public Loan GetById(int id)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.Loans.Find(id);
            }
        }

        public void Insert(Loan entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Loans.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Loan entity)
        {
            using (var db = new LibraryManagementDbEntities())
            {
                db.Loans.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<SP_GetLoans_Result> GetLoans()
        {
            using (var db = new LibraryManagementDbEntities())
            {
                return db.SP_GetLoans().ToList();
            }
        }
    }
}

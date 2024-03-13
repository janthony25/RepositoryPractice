using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPractice.Data;
using RepositoryPractice.Models;

namespace RepositoryPractice.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly ApplicationDbContext _db;
        private DbSet<tblCustomer> CustomerEntity;
        private DbSet<tblIssue> IssueEntity;
        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
            //CustomerEntity = db.Set<tblCustomer>();
            //IssueEntity = db.Set<tblIssue>();
        }

        public IEnumerable<ViewTblCustomerWithIssue> GetCustomer()
        {
            var customerWithIssue = _db.Set<ViewTblCustomerWithIssue>();
            return customerWithIssue.AsEnumerable();
        }

        
       
    }
}

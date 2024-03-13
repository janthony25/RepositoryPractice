using RepositoryPractice.Models;

namespace RepositoryPractice.Repository
{
    public interface ICustomerRepository
    {
        public IEnumerable<ViewTblCustomerWithIssue> GetCustomer();

    }
}

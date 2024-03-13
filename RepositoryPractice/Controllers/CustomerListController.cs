using Microsoft.AspNetCore.Mvc;
using RepositoryPractice.Data;
using RepositoryPractice.Repository;

namespace RepositoryPractice.Controllers
{
    public class CustomerListController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerListController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IActionResult Index()
        {
            //   ViewBag.CustomerList = _customerRepository.GetCustomer();
            ViewBag.CustomerListWithIssue = _customerRepository.GetCustomer();
            return View();
        }

        public IActionResult Create()
        {

            return PartialView("~/Views/CustomerList/_ModalCreate.cshtml");
        }

    }
}

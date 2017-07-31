using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customers> customers = new List<Customers>
            {
                new Customers {Id = 1 , Name = "Ashkan Rahmani"},
                new Customers {Id = 2 , Name = "Samane Yaghoobi"},
                new Customers {Id = 3 , Name = "Nazanin Rahmani"},
                new Customers {Id = 4 , Name = "Ali Yaghoobi"}
            };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = new Customers
            {
                Id = id,
                Name = customers[id - 1].Name
            };
            return View(customer);
        }
    }
}
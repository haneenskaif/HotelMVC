using System.Collections.Generic;
using HotelMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>();

        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            customer.CustomerId = customers.Count + 1;
            customers.Add(customer);
            return RedirectToAction("Index");
        }
    }
}


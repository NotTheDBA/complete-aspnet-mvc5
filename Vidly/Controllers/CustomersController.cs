﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                //new Customer {Name = "John Smith"},
                //new Customer {Name = "Mary Williams"}
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}
            };

            var viewModelCustomer = new DefaultCustomersViewModel
            {
                Customers = customers
            };
            
            return View(viewModelCustomer);
        }


        public ActionResult Details(int? id)
        {
            var customer = "";
            if (!id.HasValue || id <= 0)
                return new EmptyResult();
            else

            if (id == 1)
                customer = "John Smith";
            else //if (id == 2)
                customer = "Mary Williams";

            //return Content(id.ToString());
            return View(new Customer { Name = customer });

        }

    }
}
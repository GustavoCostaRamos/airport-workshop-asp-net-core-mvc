using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirportWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebMvc.Controllers
{
    public class FlightsController : Controller
    {
        public IActionResult Index()
        {
            List<Flight> list = new List<Flight>();
            list.Add(new Flight { Id = 1, Destiny = "Salvador", Origin = "São paulo", Price = 2000.00 });
            list.Add(new Flight { Id = 2, Destiny = "Rio De Janeiro", Origin = "Salvador", Price = 2000.00 });
            return View();
        }
    }
}
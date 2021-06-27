using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Services.IServices;
using TFZRAutosalon.Viewmodels;

namespace TFZRAutosalon.Controllers
{
    public class ManufacturersController : BaseController<Manufacturers>
    {
        private readonly IManufacturersService _service;
        public ManufacturersController(IManufacturersService service) : base(service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var model = _service.Get(id) as ManufacturersViewModel;
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.Get(id) as ManufacturersViewModel;
            return View(model);
        }
    }
}

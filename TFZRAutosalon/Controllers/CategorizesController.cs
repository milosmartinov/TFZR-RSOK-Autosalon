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
    public class CategorizesController : BaseController<Categorizes>
    {
        private readonly ICategorizesService _service;
        public CategorizesController(ICategorizesService service) : base(service)
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
            var model = _service.Get(id) as CategorizesViewModel;
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.Get(id) as CategorizesViewModel;
            return View(model);
        }
    }
}

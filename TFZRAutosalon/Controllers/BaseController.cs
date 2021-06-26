using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Services.IServices;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseModel
    {
        protected readonly IService<T, IBaseViewModel<T>> _service;

        public BaseController(IService<T, IBaseViewModel<T>> service)
        {
            _service = service;
        }
        public ActionResult Add([FromForm] T value)
        {
            var isValid = value.IsModelValid();
            if (isValid)
            {
                _service.Add(value);
            }

            return new JsonResult(isValid);
        }
        [HttpPatch("{id}")]
        public ActionResult Update([FromBody] T value)
        {
            try
            {
                _service.Update(value);
            }
            catch(Exception e)
            {
                return RedirectToAction("Edit");
            }
            return RedirectToAction("Index");
        }
        [HttpDelete("{id}")]
        public void Delete([FromBody] T value)
        {
            _service.Delete(value.Id);
        }
    }
}

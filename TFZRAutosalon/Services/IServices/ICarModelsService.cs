using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Services.IServices
{
    public interface ICarModelsService : IService<CarModels, IBaseViewModel<CarModels>>
    {
        IEnumerable<CarModelsViewModel> GetAll();
        SelectList GetCategoryForDropDown();
        SelectList GetManufacturersForDropDown();
    }
}

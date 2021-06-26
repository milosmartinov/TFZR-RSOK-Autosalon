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
    public interface ICarsService : IService<Cars, IBaseViewModel<Cars>>
    {
        IEnumerable<CarsViewModel> GetAll();
        SelectList GetCategoryForDropDown();
        SelectList GetModelsForDropDown();
        SelectList GetManufacturersForDropDown();
    }
}

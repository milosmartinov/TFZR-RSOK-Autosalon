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
    public interface IOrdersService : IService<Orders, IBaseViewModel<Orders>>
    {
        IEnumerable<OrdersViewModel> GetAll();
        SelectList GetUserForDropDown();
        SelectList GetCarForDropDown();
    }
}

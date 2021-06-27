using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Services.IServices
{
    public interface IManufacturersService : IService<Manufacturers, IBaseViewModel<Manufacturers>>
    {
        IEnumerable<ManufacturersViewModel> GetAll();
    }
}

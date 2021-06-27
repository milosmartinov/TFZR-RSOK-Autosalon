using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Services.IServices
{
    public interface ICategorizesService : IService<Categorizes, IBaseViewModel<Categorizes>>
    {
        IEnumerable<CategorizesViewModel> GetAll();
    }
}

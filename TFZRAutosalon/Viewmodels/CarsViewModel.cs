using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Viewmodels
{
    public class CarsViewModel : BaseViewModel<Cars>, IBaseViewModel<CarsViewModel>
    {
        public CarsViewModel(Cars model) : base(model)
        {
        }

        public CarsViewModel CreateViewModel()
        {
            return this;
        }
    }
}

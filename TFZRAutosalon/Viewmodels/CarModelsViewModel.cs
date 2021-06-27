using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Viewmodels
{
    public class CarModelsViewModel : BaseViewModel<CarModels>, IBaseViewModel<CarModelsViewModel>
    {
        public CarModelsViewModel(CarModels model) : base(model)
        {
        }

        public CarModelsViewModel CreateViewModel()
        {
            return this;
        }
    }
}

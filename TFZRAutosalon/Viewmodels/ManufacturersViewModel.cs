using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Viewmodels
{
    public class ManufacturersViewModel : BaseViewModel<Manufacturers>, IBaseViewModel<ManufacturersViewModel>
    {
        public ManufacturersViewModel(Manufacturers model) : base(model)
        {
        }

        public ManufacturersViewModel CreateViewModel()
        {
            return this;
        }
    }
}

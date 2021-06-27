using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Viewmodels
{
    public class CategorizesViewModel : BaseViewModel<Categorizes>, IBaseViewModel<CategorizesViewModel>
    {
        public CategorizesViewModel(Categorizes model) : base(model)
        {
        }

        public CategorizesViewModel CreateViewModel()
        {
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Viewmodels
{
    public class OrdersViewModel : BaseViewModel<Orders>, IBaseViewModel<OrdersViewModel>
    {
        public OrdersViewModel(Orders model) : base(model)
        {
        }

        public OrdersViewModel CreateViewModel()
        {
            return this;
        }
    }
}

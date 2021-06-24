using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Models;

namespace TFZRAutosalon.Viewmodels.Base
{
    public interface IBaseViewModel<out T> where T : class
    {
        public T CreateViewModel();
    }
}

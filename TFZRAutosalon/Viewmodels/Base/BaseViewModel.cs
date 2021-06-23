using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFZRAutosalon.Viewmodels.Base
{
    public abstract class BaseViewModel<T> where T : class
    {
        public BaseViewModel(T model)
        {
            Model = model;
        }
        public T Model { get; set; }
    }
}

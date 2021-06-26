﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Data.Repository.IRepository;
using TFZRAutosalon.Models;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Services.IServices
{
    public interface IService<T, O> where T : BaseModel where O : IBaseViewModel<T>
    {
        O GetAll();
        O Get(int id);
        void Update(T model);
        void Delete(int id);
        void Add(T model);
    }
}

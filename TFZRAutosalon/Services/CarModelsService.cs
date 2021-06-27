using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TFZRAutosalon.Data.Repository.IRepository;
using TFZRAutosalon.Models;
using TFZRAutosalon.Services.IServices;
using TFZRAutosalon.Viewmodels;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Services
{
    public class CarModelsService : ICarModelsService
    {
        private readonly ICarModelsRepository _repository;
        private readonly ICategorizesRepository _categorizes;
        private readonly IManufacturesRepository _manufactures;

        public CarModelsService(ICategorizesRepository categorizes, IManufacturesRepository manufactures, ICarModelsRepository repository)
        {
            _repository = repository;
            _categorizes = categorizes;
            _manufactures = manufactures;
        }
        public IEnumerable<CarModelsViewModel> GetAll()
        {
            return _repository.GetAll(includeProperties: "Categorizes , Manufacturers").Select(x => new CarModelsViewModel(x).CreateViewModel());
        }

        public SelectList GetCategoryForDropDown()
        {
            return new SelectList(_categorizes.GetAll(), nameof(Categorizes.Id), nameof(Categorizes.Name));
        }

        public SelectList GetManufacturersForDropDown()
        {

            return new SelectList(_manufactures.GetAll(), nameof(Manufacturers.Id), nameof(Manufacturers.Name));
        }

        public IBaseViewModel<CarModels> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CarModels model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(CarModels model)
        {
            _repository.Add(model);
        }

        IBaseViewModel<CarModels> IService<CarModels, IBaseViewModel<CarModels>>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

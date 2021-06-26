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
    public class CarsService : ICarsService
    {
        private readonly ICarsRepository _repository;
        private readonly ICategorizesRepository _categorizes;
        private readonly IManufacturesRepository _manufactures;
        private readonly ICarModelsRepository _carModels;


        public CarsService(ICarsRepository repository, ICategorizesRepository categorizes, IManufacturesRepository manufactures, ICarModelsRepository carModels)
        {
            _repository = repository;
            _carModels = carModels;
            _categorizes = categorizes;
            _manufactures = manufactures;
        }
        public IEnumerable<CarsViewModel> GetAll()
        {
            return _repository.GetAll().Select(x => new CarsViewModel(x).CreateViewModel());
        }

        public SelectList GetCategoryForDropDown()
        {
            return new SelectList(_categorizes.GetAll(), nameof(Categorizes.Id), nameof(Categorizes.Name));
        }

        public SelectList GetModelsForDropDown()
        {
            return new SelectList(_carModels.GetAll(), nameof(CarModels.Id), nameof(CarModels.Name));
        }

        public SelectList GetManufacturersForDropDown()
        {

            return new SelectList(_manufactures.GetAll(), nameof(Manufacturers.Id), nameof(Manufacturers.Name));
        }

        public IBaseViewModel<Cars> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Cars model)
        {
            throw new NotImplementedException();
        }

        IBaseViewModel<Cars> IService<Cars, IBaseViewModel<Cars>>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFZRAutosalon.Data.Repository.IRepository;
using TFZRAutosalon.Models;
using TFZRAutosalon.Services.IServices;
using TFZRAutosalon.Viewmodels;
using TFZRAutosalon.Viewmodels.Base;

namespace TFZRAutosalon.Services
{
    public class CategorizesService : ICategorizesService
    {
        private readonly ICategorizesRepository _repository;


        public CategorizesService(ICategorizesRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CategorizesViewModel> GetAll()
        {
            return _repository.GetAll().Select(x => new CategorizesViewModel(x).CreateViewModel());
        }

        public IBaseViewModel<Categorizes> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categorizes model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Categorizes model)
        {
            _repository.Add(model);
        }

        IBaseViewModel<Categorizes> IService<Categorizes, IBaseViewModel<Categorizes>>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

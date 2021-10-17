using LogisticsDemo.Infrastructure;
using LogisticsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticsDemo.Services
{
    public class CityService : ICityService
    {
        private readonly IRepository<Cities> _repository;
        public CityService(IRepository<Cities> repository)
        {
            this._repository = repository;

        }

        public List<Cities> getCityList()
        {
            return _repository.GetAll().ToList();
        }

        public Cities getZone(Cities city)
        {
            return _repository.Get(e => e.Id == city.Id);
        }
    }
}

using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UnitOfWorkFarm.Controllers
{
    public class FarmController : ApiController
    {

        private IFarmRepository _farmRepository;

        public FarmController()
        {
            var unitOfWork = new UnitOfWork();

            _farmRepository = unitOfWork.FarmRepository;
        }

        public IEnumerable<FarmEntity> Get()
        {
            return _farmRepository.GetAll();
        }

        public void Post([FromBody] FarmEntity farmEntity)
        {
            _farmRepository.Add(farmEntity);
        }
    }
}

using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Services
{
    class FarmServices
    {
        private UnitOfWork _unitOfWork;

        public FarmServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Farm
        public IEnumerable<FarmEntity> GetAll()
        {
            return _unitOfWork.FarmRepository.GetAll();
        }

        public void AddFarm(FarmEntity farmEntity)
        {
            _unitOfWork.FarmRepository.Add(farmEntity);
            _unitOfWork.Save();
        }

        public void DeleteFarm(FarmEntity farmEntity)
        {
            _unitOfWork.FarmRepository.Delete(farmEntity);
            _unitOfWork.Save();
        }

        public FarmEntity GetFarmById(int id)
        {
            return _unitOfWork.FarmRepository.GetById(id);
        }

        public void EditFarm(FarmEntity farmEntity)
        {
            _unitOfWork.FarmRepository.Update(farmEntity);
            _unitOfWork.Save();
        }

    }
}

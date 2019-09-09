using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class UnitOfWork
    {

        private FarmContext _farmContext;

        private IFarmRepository _farmRepository;


        public UnitOfWork()
        {
            _farmContext = new FarmContext();
        }


        public IFarmRepository FarmRepository
        {
            get
            {
                if (_farmRepository == null)
                {
                    _farmRepository = new FarmRepository(_farmContext);
                }

                return _farmRepository;
            }
        }

        public void Save()
        {
            _farmContext.SaveChanges();
        }

    }
}

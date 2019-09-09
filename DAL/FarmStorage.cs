using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FarmStorage
    {
        private readonly static List<FarmEntity> _farmInternalStoragel;
        private static int id = 1;
        static FarmStorage()
        {
            _farmInternalStoragel = new List<FarmEntity> ();
        }

        public FarmStorage() { }

        public IEnumerable<FarmEntity> GetAllFarms()
        {
            return _farmInternalStoragel.ToList();
        }

        public FarmEntity GetFarmById(int id)
        {
            return _farmInternalStoragel.FirstOrDefault(farm => farm.Id == id);
        }

        public void AddFarm(FarmEntity newFarm)
        {
            if (newFarm == null)
                throw new ArgumentNullException(nameof(newFarm));


            newFarm.Id = id++;



            _farmInternalStoragel.Add(newFarm);
        }

        public void DeleteFarm(int id)
        {
            var farm = GetFarmById(id);

            if (farm == null)
                return;

            _farmInternalStoragel.Remove(farm);


        }

    }
}

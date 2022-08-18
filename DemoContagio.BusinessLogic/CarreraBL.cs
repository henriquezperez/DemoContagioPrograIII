using DemoContagio.DataAccess;
using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.BusinessLogic
{
    public  class CarreraBL
    {
        private static CarreraBL _instace;

        public static CarreraBL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new CarreraBL();
                return _instace;
            }
        }

        public List<Carrera> SelectAll()
        {
            List<Carrera> result = null;
            try
            {
                result = CarreraDAL.Instance.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Insert(Carrera entity)
        {
            bool result = false;
            try
            {
                result = CarreraDAL.Instance.Insert(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}

using DemoContagio.Entities;
using DemoContagio.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.BusinessLogic
{
    public class CicloBL
    {
        private static CicloBL _instace;

        public static CicloBL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new CicloBL();
                return _instace;
            }
        }

        public List<Ciclo> SelectAll()
        {
            List<Ciclo> result = null;
            try
            {
                result = CicloDAL.Instance.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Insert(Ciclo entity)
        {
            bool result = false;
            try
            {
                result = CicloDAL.Instance.Insert(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}


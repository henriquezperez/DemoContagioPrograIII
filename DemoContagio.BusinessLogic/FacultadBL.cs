using DemoContagio.DataAccess;
using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.BusinessLogic
{
    public class FacultadBL
    {
        private static FacultadBL _instace;

        public static FacultadBL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new FacultadBL();
                return _instace;
            }
        }

        public List<Facultad> SelectAll()
        {
            List<Facultad> result = null;
            try
            {
                result = FacultadDAL.Instance.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Insert(Facultad entity)
        {
            bool result = false;
            try
            {
                result = FacultadDAL.Instance.Insert(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}

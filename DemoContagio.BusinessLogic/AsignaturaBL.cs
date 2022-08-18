using DemoContagio.DataAccess;
using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.BusinessLogic
{
    public class AsignaturaBL
    {
        private static AsignaturaBL _instace;

        public static AsignaturaBL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new AsignaturaBL();
                return _instace;
            }
        }

        public List<Asignatura> SelectAll()
        {
            List<Asignatura> result = null;
            try
            {
                result = AsignaturaDAL.Instance.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Insert(Asignatura entity)
        {
            bool result = false;
            try
            {
                result = AsignaturaDAL.Instance.Insert(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}

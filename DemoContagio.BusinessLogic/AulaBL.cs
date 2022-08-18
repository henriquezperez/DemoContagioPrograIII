using DemoContagio.DataAccess;
using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.BusinessLogic
{
    public class AulaBL
    {
        private static AulaBL _instace;

        public static AulaBL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new AulaBL();
                return _instace;
            }
        }

        public List<Aula> SelectAll()
        {
            List<Aula> result = null;
            try
            {
                result = AulaDAL.Instance.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Insert(Aula entity)
        {
            bool result = false;
            try
            {
                result = AulaDAL.Instance.Insert(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}

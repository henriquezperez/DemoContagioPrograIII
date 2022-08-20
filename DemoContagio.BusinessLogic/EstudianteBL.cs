using DemoContagio.DataAccess;
using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.BusinessLogic
{
    public class EstudianteBL
    {
        private static EstudianteBL _instance;

        public static EstudianteBL Instance
        {
            get { 
                if(_instance == null)
                {
                    _instance = new EstudianteBL();
                }
                return _instance; 
            }
        }

        public List<Estudiante> SelectAll()
        {
            List<Estudiante> result = null;
            try
            {
                result = EstudianteDAL.Instance.SelectAll();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Insert(Estudiante entity)
        {
            bool result = false;
            try
            {
                result = EstudianteDAL.Instance.Insert(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}

using DemoContagio.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoContagio.DataAccess
{
    public class CarreraDAL : Connection
    {
        private static CarreraDAL _instace;

        public static CarreraDAL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new CarreraDAL();
                return _instace;
            }
        }

        public List<Carrera> SelectAll()
        {
            List<Carrera> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CarreraSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Carrera>();
                            while (dr.Read())
                            {
                                Carrera entity = new Carrera()
                                {
                                    CarreraId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),  
                                    FacultadId = dr.GetInt32(2)
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Carrera entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CarreraInsert", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                        cmd.Parameters.AddWithValue("@FacultadId", entity.FacultadId);
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException)
            {
                result = false;
            }
            return result;
        }
    }
}

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
    public class FacultadDAL : Connection
    {
        private static FacultadDAL _instace;

        public static FacultadDAL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new FacultadDAL();
                return _instace;
            }
        }

        public List<Facultad> SelectAll()
        {
            List<Facultad> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FacultadSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Facultad>();
                            while (dr.Read())
                            {
                                Facultad entity = new Facultad()
                                {
                                    FacultadId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1)
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Facultad entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_FacultadInsert", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
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

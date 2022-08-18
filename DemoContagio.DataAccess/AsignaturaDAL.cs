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
    public class AsignaturaDAL : Connection
    {
        private static AsignaturaDAL _instace;

        public static AsignaturaDAL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new AsignaturaDAL();
                return _instace;
            }
        }

        public List<Asignatura> SelectAll()
        {
            List<Asignatura> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AsignaturaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Asignatura>();
                            while (dr.Read())
                            {
                                Asignatura entity = new Asignatura()
                                {
                                    AsignaturaId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),
                                    Codigo = dr.GetString(2),
                                    AulaId = dr.GetInt32(3),
                                    CicloId = dr.GetInt32(4),
                                    FacultadId = dr.GetInt32(5)
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Asignatura entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AsignaturaInsert", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                        cmd.Parameters.AddWithValue("@Codigo", entity.Codigo);
                        cmd.Parameters.AddWithValue("@AulaId", entity.AulaId);
                        cmd.Parameters.AddWithValue("@CicloId", entity.CicloId);
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

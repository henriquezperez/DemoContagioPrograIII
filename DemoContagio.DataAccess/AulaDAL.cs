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
    public class AulaDAL : Connection
    {
        private static AulaDAL _instace;

        public static AulaDAL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new AulaDAL();
                return _instace;
            }
        }

        public List<Aula> SelectAll()
        {
            List<Aula> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AulaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Aula>();
                            while (dr.Read())
                            {
                                Aula entity = new Aula()
                                {
                                   AulaId = dr.GetInt32(0),
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

        public bool Insert(Aula entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AulaInsert", conn))
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

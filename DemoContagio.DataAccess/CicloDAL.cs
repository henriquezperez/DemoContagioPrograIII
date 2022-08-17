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
    public class CicloDAL : Connection
    {
        private static CicloDAL _instace;

        public static CicloDAL Instance
        {
            get
            {
                if (_instace == null)
                    _instace = new CicloDAL();
                return _instace;
            }
        }

        public List<Ciclo> SelectAll()
        {
            List<Ciclo> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_CicloSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Ciclo>();
                            while (dr.Read())
                            {
                                Ciclo entity = new Ciclo()
                                {
                                    CicloId = dr.GetInt32(0),
                                    Nombre = dr.GetString(1),
                                    Anio = dr.GetString(2)
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            } // Close y dispose

            return result;
        } //Cierra metodo SelectAll

        public bool Insert(Ciclo entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spCicloInsert", conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Anio", entity.Anio);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}

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
    public class EstudianteDAL : Connection
    {
        private static EstudianteDAL _instance;

        public static EstudianteDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EstudianteDAL();
                
                }
                return _instance;
            }
        }

        public List<Estudiante> SelectAll()
        {
            List<Estudiante> result = null;
            using (SqlConnection conn = new SqlConnection(_cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_EstudianteSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Estudiante>();
                            while (dr.Read())
                            {
                                Estudiante entity = new Estudiante()
                                {
                                    EstudianteId = dr.GetInt32(0),
                                    Nombres = dr.GetString(1),
                                    Apellidos = dr.GetString(2),
                                    Codigo = dr.GetString(3),
                                    CarreraId = dr.GetInt32(4),
                                    NumTelefono = dr.GetString(5),
                                    Genero = dr.GetString(6),
                                    Natalicio = dr.GetString(7),
                                    EstadoId = dr.GetInt32(8),
                                    Foto = (byte[])dr.GetValue(9)
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool Insert(Estudiante entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EstudianteInsert", conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombres", entity.Nombres);
                        cmd.Parameters.AddWithValue("@Apellidos", entity.Apellidos);
                        cmd.Parameters.AddWithValue("@Codigo", entity.Codigo);
                        cmd.Parameters.AddWithValue("@CarreraId", entity.CarreraId);
                        cmd.Parameters.AddWithValue("@NumTelefono", entity.NumTelefono);
                        cmd.Parameters.AddWithValue("@Genero", entity.Genero);
                        cmd.Parameters.AddWithValue("@Natalicio", entity.Natalicio);
                        cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);
                        cmd.Parameters.AddWithValue("@Foto", entity.Foto);
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;

                    }
                }
            }
            catch(SqlException)
            {
                result = false;
            }
            return result;
        }

    }
}

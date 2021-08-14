using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Aerolinea
{
    class BaseDatos
    {
        readonly string cadena = @"Data Source=DESKTOP-7BIOTUK\SQLEXPRESS;Initial Catalog=Aerolinea; Integrated Security=True;";

        public bool ValidarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT 1 FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo AND CLAVE = @Clave; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;

                        EsUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());

                    }
                }
            }
            catch (Exception)
            {

            }
            return EsUsuarioValido;
        }

       

       
       

       

       

        public bool InsertarUsuario(string codigo, string nombre, string clave, bool estado)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO USUARIOS ");
                consultaSQL.Append(" VALUES (@Codigo, @Nombre, @Clave, @Estado); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;
                        comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = estado;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditarUsuario(string codigo, string nombre, string clave, bool estado)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE USUARIOS ");
                consultaSQL.Append(" SET NOMBRE = @Nombre, CLAVE = @Clave, ESTAACTIVO = @Estado ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;
                        comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = estado;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT CODIGO, NOMBRE, ESTAACTIVO  FROM USUARIOS  ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;
        }

        public bool EliminarUsuarios(string codigo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

       

       

       

       
       

        public string GetNombreUsuario(string codigoUsuario)
        {
            string nombre = string.Empty;
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT NOMBRE FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigoUsuario;
                        SqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            nombre = dr["NOMBRE"].ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return nombre;
        }




        public DataTable ListarPasajeros()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT *  FROM REGISTRO DE DATOS GENERALES ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;
        }







        public bool EditarPasajeros(string nombre, string edad, bool fechasalida, bool fecharegreso)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE REGISTRO DE DATOS GENERALES ");
                consultaSQL.Append(" SET NOMBRE = @Nombre, EDAD = @edad, FECHA DE SALIDA = @fechasalida, FECHA DE REGRESO = @fecharegreso ");
                

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = nombre ;
                        comando.Parameters.Add("@edad", SqlDbType.NVarChar, 50).Value = edad ;
                        comando.Parameters.Add("@fechasalida", SqlDbType.NVarChar, 30).Value = fechasalida;
                        comando.Parameters.Add("@fecharegreso", SqlDbType.Bit).Value = fecharegreso;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool InsertarPasajero(string nombre, string edad, string  fechasalida, string  fecharegreso)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO REGISTRO DE DATOS GENERALES ");
                consultaSQL.Append(" VALUES (@Nombre, @edad, @fechasalida, @Fecharegreso); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = nombre ;
                        comando.Parameters.Add("@edad", SqlDbType.NVarChar, 80).Value = edad ;
                        comando.Parameters.Add("@fechasalida", SqlDbType.Int).Value = fechasalida ;
                        comando.Parameters.Add("@fecharegreso", SqlDbType.Decimal).Value = fecharegreso ;
                        
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}

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
        readonly string cadena = "Data Source=DESKTOP-7BIOTUK\\SQLEXPRESS";

        public bool ValidarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT 1 FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo AND CLAVE = @Clave AND ESTAACTIVO = 1; ");

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

       

        public bool InsertarProducto(string codigo, string descripcion, int idCategoria, decimal precio, int existencia, byte[] imagen)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO PRODUCTOS ");
                consultaSQL.Append(" VALUES (@Codigo, @Descripcion, @IdCategoria, @Precio, @Existencia, @Imagen); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = descripcion;
                        comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;
                        comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
                        comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
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

        public DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT P.CODIGO, P.DESCRIPCION, C.DESCRIPCION CATEGORIA, P.PRECIO, P.EXISTENCIA  FROM PRODUCTOS P ");
                consultaSQL.Append(" INNER JOIN CATEGORIAS C ON C.ID = P.IDCATEGORIA ");

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

        public bool EditarProducto(string codigo, string descripcion, int idCategoria, decimal precio, int existencia, byte[] imagen)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE PRODUCTOS ");
                consultaSQL.Append(" SET DESCRIPCION = @Descripcion, IDCATEGORIA = @IdCategoria, PRECIO = @Precio, EXISTENCIA = @Existencia, IMAGEN = @Imagen ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = descripcion;
                        comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;
                        comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
                        comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
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

        public bool EliminarProducto(string codigo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM PRODUCTOS ");
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

        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT *  FROM CLIENTES ");

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

        public bool InsertarCliente(string identidad, string nombre, int telefono, string direccion, byte[] imagen)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO CLIENTES ");
                consultaSQL.Append(" VALUES (@Identidad, @Nombre, @Telefono, @Direccion, @Imagen); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = telefono;
                        comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 80).Value = direccion;
                        comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
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

        public bool EditarCliente(int id, string identidad, string nombre, int telefono, string direccion, byte[] imagen)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE CLIENTES ");
                consultaSQL.Append(" SET IDENTIDAD = @Identidad, NOMBRE = @Nombre, TELEFONO = @Telefono, DIRECCION = @Direccion, IMAGEN = @Imagen");
                consultaSQL.Append(" WHERE ID = @Id; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = telefono;
                        comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 80).Value = direccion;
                        comando.Parameters.Add("@Imagen", SqlDbType.Image).Value = imagen;
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

        public bool EliminarCliente(int id)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM CLIENTES ");
                consultaSQL.Append(" WHERE ID = @Id; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
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

        public byte[] SeleccionarImagenCliente(int id)
        {
            byte[] _imagen = new byte[0];
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT IMAGEN FROM CLIENTES ");
                consultaSQL.Append(" WHERE ID = @Id; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        SqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            _imagen = (byte[])dr["IMAGEN"];
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
            return _imagen;
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

        public List<KeyValuePair<int, string>> GetClienteParaFactura(string identidad)
        {
            List<KeyValuePair<int, string>> miLista = new List<KeyValuePair<int, string>>();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT ID, NOMBRE FROM CLIENTES ");
                consultaSQL.Append(" WHERE IDENTIDAD = @Identidad ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = identidad;
                        SqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            miLista.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"].ToString()), dr["NOMBRE"].ToString()));
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return miLista;
        }

        public DataTable SeleccionarClientesParaFacturaPorNombre(string nombre)
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT *  FROM CLIENTES WHERE NOMBRE LIKE ('%" + nombre + "%') ");

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

      

               
        
    }
}

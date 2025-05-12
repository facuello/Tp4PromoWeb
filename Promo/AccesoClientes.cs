using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Promo
{
    public class AccesoClientes
    {
        private List<Clientes> clientes = null;
        private AccesoDatos datos = null;

        public List<Clientes> listar()
        {
            clientes = new List<Clientes>();
            datos = new AccesoDatos();

            datos.Conectar();
            datos.Consultar("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes");
            datos.Leer();

            try
            {
                Clientes aux = new Clientes();
                while (datos.Lector.Read())
                {
                    aux.id = datos.validarNullInt32(datos.Lector["Id"]);
                    aux.documento = datos.validarNullInt32(datos.Lector["Documento"]);
                    aux.nombre = datos.validarNullString(datos.Lector["Nombre"]);
                    aux.apellido = datos.validarNullString(datos.Lector["Apellido"]);
                    aux.email = datos.validarNullString(datos.Lector["Email"]);
                    aux.direccion = datos.validarNullString(datos.Lector["Direccion"]);
                    aux.ciudad = datos.validarNullString(datos.Lector["Ciudad"]);
                    aux.codigoPostal = datos.validarNullInt32(datos.Lector["CP"]);

                    clientes.Add(aux);
                }
            }
            catch (Exception er)
            {

                throw er;
            }
            finally
            {
                datos.Cerrar();
            }

            return clientes;
        }
        public void agregarCliente(Clientes nuevo)
        {
            datos = new AccesoDatos();
            try
            {
                datos.Conectar();
                datos.Consultar("INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setearParametro("@Documento", nuevo.documento);
                datos.setearParametro("@Nombre", nuevo.nombre);
                datos.setearParametro("@Apellido", nuevo.apellido);
                datos.setearParametro("@Email", nuevo.email);
                datos.setearParametro("@Direccion", nuevo.direccion);
                datos.setearParametro("@Ciudad", nuevo.ciudad);
                datos.setearParametro("@CP", nuevo.codigoPostal);
                datos.EjecutarNonQuery();
            }
            catch (Exception er)
            {

                throw er;
            }
            finally
            {
                datos.Cerrar();
            }
        }

        public Clientes obtenerClientePorDni(int dni)
        {
            datos = new AccesoDatos();
            SqlConnection connection = new SqlConnection();
            Clientes cliente = null;
            {
                string query = "SELECT * FROM Clientes WHERE documento = @Dni";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Dni", dni);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        cliente = new Clientes
                        {
                            documento = (int)reader["documento"],
                            nombre = reader["nombre"].ToString(),
                            apellido = reader["apellido"].ToString(),
                            email = reader["email"].ToString(),
                            direccion = reader["direccion"].ToString(),
                            ciudad = reader["ciudad"].ToString(),
                            codigoPostal = (int)reader["codigoPostal"]
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el cliente: " + ex.Message);
                }
            }
            return cliente;
        }
    }
}

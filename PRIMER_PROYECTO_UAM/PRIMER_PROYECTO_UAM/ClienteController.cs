using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace PRIMER_PROYECTO_UAM
{
    
        public class ClienteController : Form1
        {


            public bool REGISTRAR_CLIENTE(ClienteBE cliente)
            {
                bool result = false;
                try
                {
                    Conexion myconexion = new Conexion();
                    SqlConnection conexion = myconexion.CreateConnection();
                    SqlCommand comando = myconexion.CreateCommand(conexion);

                    comando.CommandText = "REGISTRAR_CLIENTE";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@NOMBRES", cliente.Nombres);
                    comando.Parameters.AddWithValue("@APELLIDOS", cliente.Apellidos);
                    comando.Parameters.AddWithValue("@DNI", cliente.Dni);
                    comando.Parameters.AddWithValue("@EDAD", cliente.Edad);
                    comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                    comando.Parameters.AddWithValue("@PROVINCIA", cliente.Provincia);
                    //comando.Parameters.AddWithValue("@FOTO", binData);
                    //comando.Parameters.AddWithValue("@FECHA", cliente.Fecha);
                    //comando.Parameters.AddWithValue("@FOTO", binData);



                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    result = true;
                }
                catch (SqlException e)
                {
                    //insert error in a log
                    result = false;
                }
                return result;

            }

            public List<ClienteBE> RetrieveAllStudent()
            {
                List<ClienteBE> listResult = new List<ClienteBE>();
                try
                {
                    Conexion myConnection = new Conexion();
                    SqlConnection conexion = myConnection.CreateConnection();
                    SqlCommand comando = myConnection.CreateCommand(conexion);
                    SqlDataReader infoclienteReader;

                    comando.CommandText = "clientes";
                    comando.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    infoclienteReader = comando.ExecuteReader();

                    while (infoclienteReader.Read())
                    {
                        ClienteBE cliente = new ClienteBE();
                        cliente.Nombres = infoclienteReader["NOMBRES"].ToString();
                        cliente.Apellidos = infoclienteReader["APELLIDOS"].ToString();
                        cliente.Dni = infoclienteReader["DNI"].ToString();
                        cliente.Edad = Convert.ToInt16(infoclienteReader["EDAD"]);
                        cliente.Direccion = infoclienteReader["DIRECCION"].ToString();
                        cliente.Provincia = infoclienteReader["PROVINCIA"].ToString();

                        // cliente.Fecha = Convert.ToDateTime(infoclienteReader["FECHA"]);
                        // cliente.pic = Convert.ToSByte(infoclienteReader["FOTO"]);



                        listResult.Add(cliente);
                    }

                    conexion.Close();
                }
                catch (SqlException e)
                {

                }
                return listResult;
            }


        }
    }


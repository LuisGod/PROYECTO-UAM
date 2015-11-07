using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
   public   class ClienteController
    {
      // Conexion myconexion = new Conexion();
       SqlConnection miconexion = new SqlConnection(Conexion.sqlConnection);
        //SqlCommand comando = myconexion.CreateCommand(conexion);
       

       private string buscar;
        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public void listarclientes(DataGridView data)
       {
          
           
           miconexion.Open();
           SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE", miconexion);
           comando.Connection = miconexion;
           comando.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(comando);
           da.Fill(dt);
           data.DataSource = dt;
           data.Columns[0].Width = 60;
           data.Columns[1].Width = 165;
           data.Columns[2].Width = 165;
           data.Columns[3].Width = 90;
           data.Columns[4].Width = 50;
           data.Columns[5].Width = 165;
           data.Columns[6].Width = 100;
           data.Columns[7].Width = 125;

           miconexion.Close();
       }
       public void buscarcedula(DataGridView data)
       {
           miconexion.Open();
           SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE where DNI like ('" + buscar + "%')", miconexion);
           comando.Connection = miconexion;
           comando.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(comando);
           da.Fill(dt);
           data.DataSource = dt;
           miconexion.Close();
       }

       public void buscarapellido(DataGridView data)
       {
           miconexion.Open();
           SqlCommand comando = new SqlCommand("SELECT * FROM CLIENTE where APELLIDOS like ('" + buscar + "%')", miconexion);
           comando.Connection = miconexion;
           comando.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(comando);
           da.Fill(dt);
           data.DataSource = dt;
           miconexion.Close();
       }
       public void eliminar(DataGridView dataelimina)
       {
           DialogResult resultado = MessageBox.Show("¿Estas Seguro de Eliminar al cliente?");
           if (resultado == DialogResult.No)
           {
               return;
           }
       
           {
               SqlCommand comando = new SqlCommand("BORRAR_CLIENTE", miconexion);
               comando.CommandType = CommandType.StoredProcedure;
               comando.Parameters.AddWithValue("ID", dataelimina.CurrentRow.Cells["ID"].Value);
               miconexion.Open();
               comando.ExecuteNonQuery();
               miconexion.Close();

              MessageBox.Show("El cliente ha sido eliminado");
           }
           
       }

    }
}

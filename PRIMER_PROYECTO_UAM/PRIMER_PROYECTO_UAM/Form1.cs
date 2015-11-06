using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//libreria para imagen
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public OpenFileDialog examinar = new OpenFileDialog();
        private void Form1_Load(object sender, EventArgs e)
        {

            ////////////////////////////////////////////////////////////////////////////////
            List<ProvinciaBE> listaP = new List<ProvinciaBE>();
            ProvinciaController provinciacontrola = new ProvinciaController();
            listaP = provinciacontrola.CONSULTAPROVINCIA();

            BindingSource provinciasourse = new BindingSource();
            provinciasourse.DataSource = listaP;
            cmbprovincia.DataSource = provinciasourse;
            cmbprovincia.DisplayMember = "PROVINCIA";
            cmbprovincia.ValueMember = "IDPROVINCIAS";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool result;

            ClienteBE ingresa = new ClienteBE();
            ingresa.Nombres = txtnombre.Text;
            ingresa.Edad = Convert.ToInt32(txtedad.Text);
            ingresa.Provincia = cmbprovincia.Text;
            ingresa.Dni = txtcedula.Text;
            ingresa.Direccion = txtdireccion.Text;
            ingresa.Apellidos = txtapellido.Text;





            ClienteController controller = new ClienteController();
            if (result = controller.REGISTRAR_CLIENTE(ingresa))
            {
                MessageBox.Show("!!!!Datos almacenados correctamente!!!!");
            }
            else
            {
                MessageBox.Show("La inserción fallo");
            }




        }

        private void btnbuscarfoto_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            txtexaminar.Text = examinar.FileName;
            picfoto.Image = Image.FromFile(examinar.FileName);
        }
    }
}

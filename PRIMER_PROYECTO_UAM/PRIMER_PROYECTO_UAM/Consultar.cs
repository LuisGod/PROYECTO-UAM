using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Consultar : Form
    {
   
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
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
    }
}

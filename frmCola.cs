using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMigotti_ED_POO
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void gpElementoEliminado_Enter(object sender, EventArgs e)
        {
           
        }

        clsCola FilaDePersonas = new clsCola();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodigoE.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombreE.Text = FilaDePersonas.Primero.Nombre;
                lblTramiteE.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(lsbCola);
            }
            else
            {
                lblCodigoE.Text = "";
                lblNombreE.Text = "";
                lblTramiteE.Text = "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo1.Text);
            ObjNodo.Nombre = txtNombre1.Text;
            ObjNodo.Tramite = txtTramite1.Text;

            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer(lsbCola);
            txtCodigo1.Text = "";
            txtNombre1.Text = "";
            txtTramite1.Text = "";
        }
    }
}

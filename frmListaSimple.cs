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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple ListaSimple = new clsListaSimple();
        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo3.Text);
            objNodo.Nombre = txtNombre3.Text;
            objNodo.Tramite = txtTramite3.Text;

            ListaSimple.Agregar(objNodo);
            ListaSimple.Recorrer(dgvListaSimple);
            ListaSimple.Recorrer(lsbListaSimple);
            ListaSimple.Recorrer(cbCodigo);


            txtCodigo3.Text = "";
            txtNombre3.Text = "";
            txtTramite3.Text = "";
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            if (ListaSimple.Primero != null)
            {
                Int32 Codigo = Convert.ToInt32(cbCodigo.Text);
                ListaSimple.Eliminar(Codigo);
                ListaSimple.Recorrer(dgvListaSimple);
                ListaSimple.Recorrer(lsbListaSimple);
                ListaSimple.Recorrer(cbCodigo);
            }
            else
            {
                lsbListaSimple.SelectedIndex = -1;
            }
        }

        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

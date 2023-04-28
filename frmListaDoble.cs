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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble ListaDoble = new clsListaDoble();
        private void btnAgregar4_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo4.Text);
            objNodo.Nombre = txtNombre4.Text;
            objNodo.Tramite = txtTramite4.Text;

            ListaDoble.Agregar(objNodo);
            ListaDoble.Recorrer(dgvListaDoble);
            ListaDoble.Recorrer(lsbListaDoble);
            ListaDoble.Recorrer(cbCodigo4);

            txtCodigo4.Text = "";
            txtNombre4.Text = "";
            txtTramite4.Text = "";
        }

        private void btnEliminar4_Click(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {

                Int32 Codigo = Convert.ToInt32(cbCodigo4.Text);
                ListaDoble.Eliminar(Codigo);
                ListaDoble.Recorrer(dgvListaDoble);
                ListaDoble.Recorrer(lsbListaDoble);
                ListaDoble.Recorrer(cbCodigo4);
            }
            else
            {
                cbCodigo4.SelectedIndex = -1;
            }
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.Recorrer(dgvListaDoble);
            ListaDoble.Recorrer(lsbListaDoble);
            ListaDoble.Recorrer(cbCodigo4);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.RecorrerDescendente(dgvListaDoble);
            ListaDoble.RecorrerDescendente(lsbListaDoble);
            ListaDoble.RecorrerDescendente(cbCodigo4);
        }
    }
}

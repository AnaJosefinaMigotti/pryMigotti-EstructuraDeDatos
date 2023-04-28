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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }


        //ayudaaa
        clsPila Pila = new clsPila();
        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo2.Text);
            ObjNodo.Nombre = txtNombre2.Text;
            ObjNodo.Tramite = txtTramite2.Text;

            Pila.Agregar(ObjNodo);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lsbPila);

            txtCodigo2.Text = "";
            txtNombre2.Text = "";
            txtTramite2.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {

                lblCodigoP.Text = Pila.Primero.Codigo.ToString();
                lblNombreP.Text = Pila.Primero.Nombre;
                lblTramiteP.Text = Pila.Primero.Tramite;

                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lsbPila);
            }
            else
            {
                lblCodigoP.Text = "";
                lblNombreP.Text = "";
                lblTramiteP.Text = "";
            }
        }
    }
}

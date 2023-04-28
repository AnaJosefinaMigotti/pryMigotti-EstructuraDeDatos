using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sino no hace referencia a una grilla
using System.Windows.Forms;

namespace pryMigotti_ED_POO
{
    class clsCola
    {
        //creo nodos
        public clsNodo Primero;
        public clsNodo Ultimo;

        public void Agregar(clsNodo Nuevo)
        {
            //posiciono
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                //siguiente = enlaza
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView dgvCola)
        {
            clsNodo Auxiliar = Primero;
            dgvCola.Rows.Clear();
            while (Auxiliar != null)
            {
                dgvCola.Rows.Add(Auxiliar.Codigo, Auxiliar.Nombre, Auxiliar.Tramite);
                Auxiliar = Auxiliar.Siguiente;
            }
        }

        public void Recorrer(ListBox lsbCola)
        {
            clsNodo Auxiliar = Primero;
            lsbCola.Items.Clear();
            while (Auxiliar != null)
            {
                lsbCola.Items.Add(Auxiliar.Codigo + "" + Auxiliar.Nombre + "" + Auxiliar.Tramite + "");
                Auxiliar = Auxiliar.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Auxiliar = Primero;
            Combo.Items.Clear();
            while (Auxiliar != null)
            {
                Combo.Items.Add(Auxiliar.Nombre);
                Auxiliar = Auxiliar.Siguiente;
            }
        }

    }
}

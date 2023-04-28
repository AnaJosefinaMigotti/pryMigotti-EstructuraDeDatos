using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMigotti_ED_POO
{
    internal class clsListaDoble
    {
        //Punteros
        public clsNodo pri;
        public clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo >= Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo Ant = Primero;

                        while (aux.Codigo <= Nuevo.Codigo)
                        {
                            Ant = aux;
                            Ant = aux.Siguiente;

                            if (aux == null)
                            {
                                break;
                            }
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                        aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo Ant = Primero;

                        while (aux.Codigo != Codigo)
                        {
                            Ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        Ant.Siguiente = aux;
                        aux.Anterior = Ant; 
                    }
                }
            }
        }

        // Recorroooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        // ascendentemente 
        public void Recorrer(DataGridView dgvGrilla)
        {
            clsNodo Aux = Primero;
            dgvGrilla.Rows.Clear();

            while (Aux != null)
            {
                dgvGrilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lstListado)
        {
            clsNodo Aux = Primero;
            lstListado.Items.Clear();
            while (Aux != null)
            {
                lstListado.Items.Add(Aux.Codigo + "" + Aux.Nombre + "" + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox lstCodigo)
        {
            clsNodo Aux = Primero;
            lstCodigo.Items.Clear();
            while (Aux != null)
            {
                lstCodigo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }
        }

        //descendente para el botón de opción
        public void RecorrerDescendente(DataGridView dgvGrilla)
        {
            clsNodo Aux = Ultimo;
            dgvGrilla.Rows.Clear();

            while (Aux != null)
            {
                dgvGrilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
            }
        }
        public void RecorrerDescendente(ListBox lstListado)
        {
            clsNodo Aux = Ultimo;
            lstListado.Items.Clear();
            while (Aux != null)
            {
                lstListado.Items.Add(Aux.Codigo + "" + Aux.Nombre + "" + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void RecorrerDescendente(ComboBox lstCodigo)
        {
            clsNodo Aux = Ultimo;
            lstCodigo.Items.Clear();
            while (Aux != null)
            {
                lstCodigo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMigotti_ED_POO
{
    class clsNodo
    {
        //Declaracion de campos a utilizar

        private Int32 cod;
        private String nom;
        private String tra;

        //Puntero 
        private clsNodo sig;
        private clsNodo ant;

        //Punteros - Árbol Binario
        private clsNodo izq;
        private clsNodo der;

        //Propiedad
        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value;}
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        //Lista Doble
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        //Arbol Binario
        public clsNodo Izquierdo
        {
            get { return izq; }
            set { izq = value; }
        }
        public clsNodo Derecho
        {
            get { return der; }
            set { der = value; }
        }

    }
}

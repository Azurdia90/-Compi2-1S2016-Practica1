using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Compi2_Practica1_201020331
{
    class Core
    {
        private ArrayList lista_conjuntos;
        private ArrayList lista_expresiones;
        private ArrayList lista_afnd;
        public Core()
        {
            lista_conjuntos = new ArrayList();
            lista_expresiones = new ArrayList();
            lista_afnd = new ArrayList();
        }

        public Core(ArrayList l1, ArrayList l2)
        {
            lista_conjuntos = l1;
            lista_expresiones = l2;
        }

        public ArrayList getListaConjuntos()
        {
            return this.lista_conjuntos;
        }

        public ArrayList getListaExpresiones()
        {
            return this.lista_expresiones;
        }

        public ArrayList ModListaAFND
        {
            get { return this.lista_afnd; }
            set { this.lista_afnd = value; }
        }
    }
}

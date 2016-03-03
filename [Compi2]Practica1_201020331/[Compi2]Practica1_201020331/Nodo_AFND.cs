using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Compi2_Practica1_201020331
{
    class Nodo_AFND
    {
        //id del nodo
        private int id;
        //propiedades del nodo que sigue
        private Nodo_AFND siguiente;
        private String transicion;
        //en case que se quede en el mismo estado
        private bool tope;
        //en caso de que se tomen decisiones
        private Nodo_AFND decision;
        private String transicion_decision;
        

        public Nodo_AFND()
        {
            this.id = 0;
            this.siguiente = null;
            this.transicion = "";
            this.tope = false;
            this.decision = null;
            this.transicion_decision = "";
        }

        public int ModId
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public Nodo_AFND ModSiguiente
        {
            get { return this.siguiente; }
            set { this.siguiente = value; }
        } 
        public String ModTransicion
        {
            get { return this.transicion; }
            set { this.transicion = value; }
        }
        public bool ModTope
        {
            get { return this.tope; }
            set { this.tope = value; }
        }
        public Nodo_AFND ModDecision
        {
            get { return this.decision; }
            set {this.decision = value; }
        }
        public String ModTransicion_decision
        {
            get { return this.transicion_decision; }
            set { this.transicion_decision = value; }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Compi2_Practica1_201020331
{
    class Conjunto
    {
        private String nombre;
        private ArrayList conjunto;

        public Conjunto()
        {
            this.nombre = "";
            this.conjunto = new ArrayList();
        }
        public Conjunto(String n)
        {
            this.nombre = n;
            this.conjunto = new ArrayList();
        }
        
        public String getNombre()
        {
            return this.nombre;
        }
        public void setNombre(String n)
        {
            this.nombre = n;
        }
        public ArrayList getConjunto()
        {
            return this.conjunto;
        }
        public void setConjunto1(String a)
        {
            
        }
        public void setConjunto2(String a)
        {

        }
        public void rango1(String r)
        {

        }

        public void rango2(String r)
        {

        }
    }
}

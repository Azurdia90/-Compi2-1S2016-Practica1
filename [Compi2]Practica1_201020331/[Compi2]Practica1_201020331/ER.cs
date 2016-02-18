using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Compi2_Practica1_201020331
{
    class ER
    {
        private String nombre;
        private String expresion;
        private bool id;
        private bool texto;
        private bool linea;
        private bool columna;
        private string tipo;
        public ER()
        {
            this.nombre = "";
            this.expresion = "";
            this.id = false;
            this.texto = false;
            this.linea = false;
            this.columna = false;
            this.tipo = "";
        }
        public ER(String n, String e,bool i, bool te, bool l, bool c, String ti)
        {
            this.nombre = n;
            this.expresion = e;
            this.id = i;
            this.texto = te;
            this.linea = l;
            this.columna = c;
            this.tipo = ti;
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public void setNombre(String n)
        {
            this.nombre = n;
        }
        public String getExpresion()
        {
            return this.expresion;
        }
        public void setExpresion(String e)
        {
            this.expresion = e;
        }
        public bool getId()
        {
            return this.id;
        }

        public void setId(bool i)
        {
            this.id = i;
        }
        public bool getTexto()
        {
            return this.texto;
        }

        public void setTexto(bool t)
        {
            this.texto = t;
        }
        public bool getLinea()
        {
            return this.linea;
        }

        public void setLinea(bool l)
        {
            this.linea = l;
        }
        public bool getColumna()
        {
            return this.columna;
        }

        public void setColumna(bool c)
        {
            this.columna = c;
        }

        public String getTipo()
        {
            return this.tipo;
        }

        public void setTipo(String t)
        {
            this.tipo = t;
        }
    }
}

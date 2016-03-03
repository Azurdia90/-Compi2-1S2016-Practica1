using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Compi2_Practica1_201020331
{
    class AFND
    {
        //variable que identifica que afnd es 
        private int id;
        //variable que lleva el control de cuantos nodos son
        private int cont;
        private bool primero;       
        //objetos que tienen el inicio y el fin del afnd
        private Nodo_AFND root_afnd;
        private Nodo_AFND fin_afnd;
        //objeto temporal para la creacion del afnd
        private Nodo_AFND nuevo;
        private Nodo_AFND actual;
        //objeto temporal para el manejo de la concatenacion
        private Nodo_AFND tempcon;
        private Nodo_AFND tempcon2;
        //objeto temporarl para el manejo de la disyuncion
        private Nodo_AFND tempor;
        private Nodo_AFND tempor2;
        private Nodo_AFND tempor3;
        private Nodo_AFND tempor4;
        private Nodo_AFND tempor5;
        private Nodo_AFND tempor6;
        private Nodo_AFND tempor7;
        private Nodo_AFND tempor8;
        //objetos temporales para el manejo de cerradura de klean, suma e interrogacion;
        private Nodo_AFND tempk;
        private Nodo_AFND tempk2;
        private Nodo_AFND tempk3;


        System.IO.StreamWriter escribir;
        public AFND(int id)
        {
            this.id = id;
            this.cont = 0;
            this.primero = true;
            this.root_afnd = null;
            this.fin_afnd = null;
            this.actual = null;
            this.reset_tempcon();
            this.reset_tempk();
        }

        public void agregar_operacion(String token, String operador)
        {
            if (operador.Equals("*"))
            {
                if(primero == true)
                {
                    tempk = primer_nodo("-EPSILON-");
                    /*********************************************/
                    tempk3 = nuevo_nodo();
                    tempk3.ModTope = true;
                    root_afnd.ModDecision = tempk3;
                    root_afnd.ModTransicion_decision = "-EPSILON-";
                    /**********************************************/
                    tempk2 = nuevo_nodo();
                    tempk.ModSiguiente = tempk2;
                    tempk.ModTransicion = token;
                    /*************************/
                    tempk2.ModSiguiente = tempk3;
                    tempk2.ModTransicion = "-EPSILON-";
                    /********************************************/
                    tempk.ModTope = true;
                    tempk2.ModDecision = tempk;
                    tempk2.ModTransicion_decision = "-EPSILON-";
                    /*********************************************/
                    fin_afnd = tempk3;
                    primero = false;
                }
                else
                {
                    fin_afnd.ModSiguiente = tempk;
                    fin_afnd.ModTransicion = "-EPSILON-";
                    /*********************************************/
                    tempk3 = nuevo_nodo();
                    tempk3.ModTope = true;
                    root_afnd.ModDecision = tempk3;
                    root_afnd.ModTransicion_decision = "-EPSILON-";
                    /**********************************************/
                    tempk2 = nuevo_nodo();
                    tempk.ModSiguiente = tempk2;
                    tempk.ModTransicion = token;
                    /*************************/
                    tempk2.ModSiguiente = tempk3;
                    tempk2.ModTransicion = "-EPSILON-";
                    /********************************************/
                    tempk2.ModDecision = tempk;
                    tempk2.ModTransicion_decision = "-EPSILON-";
                    tempk.ModTope = true;
                    /*********************************************/
                    fin_afnd = tempk3;
                    primero = false;
                }
                
            }//fin operador *
            else if (operador.Equals("+"))
            {
                if (primero == true)
                {
                    tempk = primer_nodo("-EPSILON-");
                    tempk2 = nuevo_nodo();
                    tempk.ModSiguiente.Add(tempk2);
                    tempk.ModTransicion.Add(token);
                    tempk2.ModSiguiente.Add(tempk);
                    tempk2.ModTransicion.Add("-EPSILON-");
                    tempk3 = nuevo_nodo();
                    tempk2.ModSiguiente.Add(tempk3);
                    tempk2.ModTransicion.Add("-EPSILON-");
                    fin_afnd = tempk3;
                    primero = false;
                }
                else
                {
                    fin_afnd.ModSiguiente.Add(tempk);
                    fin_afnd.ModTransicion.Add("-Epsilon-");
                    tempk2 = nuevo_nodo();
                    tempk.ModSiguiente.Add(tempk2);
                    tempk.ModTransicion.Add(token);
                    tempk2.ModSiguiente.Add(tempk);
                    tempk2.ModTransicion.Add("-EPSILON-");
                    tempk3 = nuevo_nodo();
                    tempk2.ModSiguiente.Add(tempk3);
                    tempk2.ModTransicion.Add("-EPSILON-");
                    fin_afnd = tempk3;
                }
            }//fin del operador +
            else if (operador.Equals("?"))
            {
                if (primero == true)
                {
                    tempk = primer_nodo("-EPSILON-");
                    tempk3 = nuevo_nodo();
                    root_afnd.ModSiguiente.Add(tempk3);
                    root_afnd.ModTransicion.Add("-EPSILON-");
                    tempk2 = nuevo_nodo();
                    tempk.ModSiguiente.Add(tempk2);
                    tempk.ModTransicion.Add(token);
                    tempk2.ModSiguiente.Add(tempk3);
                    tempk2.ModTransicion.Add("-EPSILON-");
                    fin_afnd = tempk2;
                    primero = false;
                }
                else
                {
                    fin_afnd.ModSiguiente.Add(tempk);
                    fin_afnd.ModTransicion.Add("-EPSILON-");
                    tempk3 = nuevo_nodo();
                    fin_afnd.ModSiguiente.Add(tempk3);
                    fin_afnd.ModTransicion.Add("-EPSILON-");
                    tempk2 = nuevo_nodo();
                    tempk.ModSiguiente.Add(tempk2);
                    tempk.ModTransicion.Add(token);
                    tempk2.ModSiguiente.Add(tempk3);
                    tempk2.ModTransicion.Add("-EPSILON-");
                    fin_afnd = tempk3;
                }
            }//fin del operador ?
        }//fin agregar_operacion(token,operador)

        public void agregar_operacion(String token, String token2, String operador)
        {
            if (operador.Equals("."))
            {
                if(primero == true)
                {
                    tempcon = primer_nodo(token);
                    tempcon2 = nuevo_nodo();
                    tempcon.ModSiguiente.Add(tempcon2);
                    tempcon.ModTransicion.Add(token2);
                    fin_afnd = tempcon2;
                    primero = false;
                }
                else
                {
                    tempcon2 = nuevo_nodo();
                    fin_afnd.ModSiguiente.Add(tempcon);
                    fin_afnd.ModTransicion.Add(token);
                    tempcon.ModSiguiente.Add(tempcon2);
                    tempcon.ModTransicion.Add(token2);
                    fin_afnd = tempcon2;
                }
            }//fin de la concatenacion
            else if (operador.Equals("|"))
            {
                tempor = nuevo_nodo();
                tempor2 = nuevo_nodo();
                tempor3 = nuevo_nodo();
                tempor4 = nuevo_nodo();
                tempor5 = nuevo_nodo();
                tempor5 = nuevo_nodo();
                tempor6 = nuevo_nodo();
                if (primero == true)
                {
                    tempor = primer_nodo("-EPSILON-");
                    tempor.ModSiguiente.Add(tempor2);
                    tempor.ModTransicion.Add("-EPSILON-");
                    tempor2.ModSiguiente.Add(tempor3);
                    tempor2.ModSiguiente.Add(tempor5);
                    tempor2.ModTransicion.Add("-EPSILON-");
                    tempor2.ModTransicion.Add("-EPSILON-");
                    tempor3.ModSiguiente.Add(tempor4);
                    tempor3.ModTransicion.Add(token);
                    tempor4.ModSiguiente.Add(tempor7);
                    tempor4.ModTransicion.Add("-EPSILON-");
                    tempor5.ModSiguiente.Add(tempor6);
                    tempor5.ModTransicion.Add(token2);
                    tempor6.ModSiguiente.Add(tempor7);
                    tempor7.ModSiguiente.Add(tempor8);
                    tempor7.ModTransicion.Add("-EPSILON-");
                    primero = false;
                }
                else
                {
                    fin_afnd = nuevo_nodo();
                    fin_afnd.ModSiguiente.Add(tempor);
                    fin_afnd.ModTransicion.Add("-EPSILON-");
                    tempor.ModSiguiente.Add(tempor2);
                    tempor.ModTransicion.Add("-EPSILON-");
                    tempor2.ModSiguiente.Add(tempor3);
                    tempor2.ModSiguiente.Add(tempor5);
                    tempor2.ModTransicion.Add("-EPSILON-");
                    tempor2.ModTransicion.Add("-EPSILON-");
                    tempor3.ModSiguiente.Add(tempor4);
                    tempor3.ModTransicion.Add(token);
                    tempor4.ModSiguiente.Add(tempor7);
                    tempor4.ModTransicion.Add("-EPSILON-");
                    tempor5.ModSiguiente.Add(tempor6);
                    tempor5.ModTransicion.Add(token2);
                    tempor6.ModSiguiente.Add(tempor7);
                    tempor7.ModSiguiente.Add(tempor8);
                    tempor7.ModTransicion.Add("-EPSILON-");
                    fin_afnd = tempor8;
                }
            }//fin de or
        }//fin de agregar operaciones(token, token2, operador)
        //creacion del primero nodo
        public Nodo_AFND primer_nodo(String token)
        {
            Nodo_AFND retorno = null;
            if (!token.Equals(""))
            {
                //crear raiz
                root_afnd = nuevo_nodo();
                //crear nodo siguiente
                nuevo = nuevo_nodo();
                //crear union nodos
                root_afnd.ModSiguiente = nuevo;
                root_afnd.ModTransicion = token;
                fin_afnd = nuevo;
                retorno = nuevo;
            }
            return retorno;
        }//creacion de nuevo nodo del automata
        public Nodo_AFND nuevo_nodo()
        {
            nuevo = new Nodo_AFND();
            nuevo.ModId = cont;
            cont++;
            return nuevo;
        }

        public void reset_tempcon()
        {
            this.tempcon = null;
            this.tempcon2 = null;
        }

        public void reset_tempk()
        {
            this.tempk = null;
            this.tempk2 = null;
            this.tempk3 = null;
        }
/*------------------------------------------------METODOS PARA GRAFICAR EL AFND---------------------------------------------------*/
        public void graficar_AFND()
        {
            escribir = new System.IO.StreamWriter("C:\\Practica1\\afnd"+id+".dot");
            escribir.Write("digraph afnd{\n");
            escribir_AFND(root_afnd);
            escribir.Write("}");
            escribir.Close();
            generar_AFND();
        }
        public void escribir_AFND(Nodo_AFND root)
        {
            while(root != null)
            {
                //escribir el nodo
                escribir.Write(root.ModId+"[shape = ellipse, label =\"" + root.ModId + "\"];\n");
                //escribir las transiciones
                for(int t = 0; t < root.ModTransicion.Count; t++)
                {
                    Nodo_AFND aux = (Nodo_AFND)root.ModSiguiente[t];
                    escribir.Write(root.ModId + "->" + aux.ModId+ ";\n");
                }
                //pasar a los siguientes estados
                if(root.ModSiguiente.Count > 1)
                {
                    escribir_AFND((Nodo_AFND)root.ModSiguiente[0]);
                    for (int t = 1; t < root.ModSiguiente.Count; t++)
                    {
                        escribir_AFND2((Nodo_AFND)root.ModSiguiente[t]);
                    }

                }
            }//Fin de While para recoorer AFND

        }//fin del metodo escribir_AFND()
        //metodo que se utiliza para escribir nodos adicionales
        public void escribir_AFND2(Nodo_AFND root)
        {
            //escribir el nodo
            escribir.Write(root.ModId + "[shape = ellipse, label =\"" + root.ModId + "\"];\n");
            //escribir las transiciones
            for (int t = 0; t < root.ModTransicion.Count; t++)
            {
                escribir.Write(root.ModId + "->" + root.ModTransicion[t] + ";\n");
            }
        }
        public void generar_AFND()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Graphviz\\bin\\dot.exe");
                startInfo.Arguments = "-Tjpg  C:\\Practica1\\ast"+id+".dot -o C:\\Practica1\\afnd"+id+".jpg";
                Process.Start(startInfo);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("No se pudo graficar AFND" + e.ToString());
            }
        }
/*-----------------------------------------FIN DE LOS METODOS GRAFICAR--------------------------------------------------------*/
    }
}

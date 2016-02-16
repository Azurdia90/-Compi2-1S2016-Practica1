using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irony.Ast;
using Irony.Parsing;
using System.IO;

namespace _Compi2_Practica1_201020331
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void TSMICargar_Click(object sender, EventArgs e)
        {
            tC_Aplication.SelectTab(0);
        }

        private void TSMI_Analizar_Click(object sender, EventArgs e)
        {
            tC_Aplication.SelectTab(1);
        }

        private void TSMI_Debugger_Click(object sender, EventArgs e)
        {
            tC_Aplication.SelectTab(2);
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void b_Cargar_Click(object sender, EventArgs e)
        {
            if(!this.rTB_Cargar.Text.Equals(""))
            {
                String cadena_salida = "";
                Analizador analizador = new Analizador(new Gramatica());
                try
                {
                    cadena_salida = analizador.parse(this.rTB_Cargar.Text, new Accion_Arbol()).ToString();
                }
                catch 
                {
                    cadena_salida = "error";
                }
                
                MessageBox.Show(cadena_salida);
            }
            else
            {
                MessageBox.Show("Ingrese un texto");
            }
        }
    }
}

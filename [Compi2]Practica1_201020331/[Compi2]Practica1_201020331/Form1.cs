using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}

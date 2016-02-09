using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;    //libreria obligatorias de importar
using Irony.Ast;        //libreria obligatoria de importar

namespace _Compi2_Practica1_201020331
{
    class Gramatica
    {
        //1. TERMINALES
        RegexBasedTerminal inicio_fin = new RegexBasedTerminal("inicio_fin", "%%");
        RegexBasedTerminal s_punto_coma = new RegexBasedTerminal("s_punto_coma", ";");
        RegexBasedTerminal s_punto = new RegexBasedTerminal("s_punto", ".");
        RegexBasedTerminal s_verduguilla = new RegexBasedTerminal("s_verduguilla", "~");
        RegexBasedTerminal s_coma = new RegexBasedTerminal("s_coma", ",");
        RegexBasedTerminal s_pleca = new RegexBasedTerminal("s_pleca", "|");
        RegexBasedTerminal s_par_a = new RegexBasedTerminal("s_par_a", "(");
        RegexBasedTerminal s_par_c = new RegexBasedTerminal("s_par_c", ")");
        RegexBasedTerminal s_llave_a = new RegexBasedTerminal("s_llave_a", "{");
        RegexBasedTerminal s_llave_c = new RegexBasedTerminal("s_llave_c", "}");
        RegexBasedTerminal s_corchete_a = new RegexBasedTerminal("s_corchete_a", "[");
        RegexBasedTerminal s_corchete_c = new RegexBasedTerminal("s_corchete_c", "]");
        RegexBasedTerminal s_apuntar = new RegexBasedTerminal("s_apuntar", "->");
        RegexBasedTerminal s_blanco = new RegexBasedTerminal("s_blanco", "[:blanco:]");
        RegexBasedTerminal s_tod = new RegexBasedTerminal("s_todo", "[:todo:]");
        RegexBasedTerminal s_suma = new RegexBasedTerminal("s_suma", "+");
        RegexBasedTerminal s_resta = new RegexBasedTerminal("s_resta", "-");
        RegexBasedTerminal s_multiplicacion = new RegexBasedTerminal("s_multipliacion", "*");

        //2. NO TERMINALES

        //3. EXPRESIONES REGULARES

        //4. PRECEDENCIA DE OPERADORES

        //5. TERMINOS DE PUNTUACION

    }
}

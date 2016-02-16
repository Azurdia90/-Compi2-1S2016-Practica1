using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;    //libreria obligatorias de importar
using Irony.Ast;        //libreria obligatoria de importar

namespace _Compi2_Practica1_201020331
{
    class Gramatica : Grammar
    {
        public Gramatica()
        {
            //1. TERMINALES
            IdentifierTerminal iden = new IdentifierTerminal("id");
            RegexBasedTerminal inicio_fin = new RegexBasedTerminal("inicio_fin", "%%");
            RegexBasedTerminal ascii = new RegexBasedTerminal("ascii", "[^\020\013\010\009]");
            RegexBasedTerminal s_apuntar = new RegexBasedTerminal("s_apuntar", "->");
            RegexBasedTerminal r_conjunto = new RegexBasedTerminal("r_conjunto", "CONJ");
            RegexBasedTerminal r_return = new RegexBasedTerminal("r_return", "retorno");
            RegexBasedTerminal r_texto = new RegexBasedTerminal("r_texto", "yytext");
            RegexBasedTerminal r_linea = new RegexBasedTerminal("r_linea", "yyline");
            RegexBasedTerminal r_columna = new RegexBasedTerminal("r_columna", "yyrow");
            RegexBasedTerminal r_cadena = new RegexBasedTerminal("r_cadena", "string");
            RegexBasedTerminal r_caracter = new RegexBasedTerminal("r_caracter", "char");
            RegexBasedTerminal r_entero = new RegexBasedTerminal("r_entero", "entero");
            RegexBasedTerminal r_flotante = new RegexBasedTerminal("r_flotante", "flotante");
            RegexBasedTerminal r_booleano = new RegexBasedTerminal("r_boleano", "bool");
            RegexBasedTerminal r_resev = new RegexBasedTerminal("r_reserv", "RESERV");

            //2. NO TERMINALES
            NonTerminal S0 = new NonTerminal("S0");
            NonTerminal LENGUAJE = new NonTerminal("LENGUAJE");
            NonTerminal SENTENCIAS = new NonTerminal("SENTENCIAS");
            NonTerminal SENTENCIA = new NonTerminal("SETENCIA");
            NonTerminal CONJUNTO = new NonTerminal("CONJUNTO");
            NonTerminal RANGO = new NonTerminal("RANGO");
            NonTerminal RANGO1 = new NonTerminal("RANGO1");
            NonTerminal RANGO2 = new NonTerminal("RANGO2");
            NonTerminal ID = new NonTerminal("ID");
            NonTerminal ER = new NonTerminal("ER");
            NonTerminal ER2 = new NonTerminal("ER2");
            NonTerminal ER3 = new NonTerminal("ER3");
            NonTerminal RETURN = new NonTerminal("RETURN");
            NonTerminal RETURN2 = new NonTerminal("RETURN2");
            NonTerminal RETURN3 = new NonTerminal("RETURN3");
            NonTerminal RESERV = new NonTerminal("RESERV");

            //3. PRECEDENCIA DE OPERADORES

            //4. TERMINOS DE PUNTUACION

            //5. GRAMATICA
            S0.Rule = LENGUAJE;

            LENGUAJE.Rule = inicio_fin + SENTENCIAS + inicio_fin;

            SENTENCIAS.Rule = SENTENCIAS + SENTENCIA
                                | SENTENCIA;

            SENTENCIA.Rule = CONJUNTO;
                             //| ID + s_apuntar + ER + s_apuntar + RETURN + s_apuntar + RESERV 
                             //| ID + s_apuntar + ER + s_apuntar + RETURN;

            CONJUNTO.Rule = r_conjunto + ":" + ID + s_apuntar + RANGO1
                           | r_conjunto + ":" + ID + s_apuntar + RANGO2;

            RANGO1.Rule = ascii + "~" + ascii;

            RANGO2.Rule = MakeListRule(RANGO2, ToTerm(","), ascii);

            ER.Rule = ER + "|" + ER2
                      | ER + ER2 + "|"
                      | ER + ER2 + "."
                      | ER2;

            ER2.Rule = ER2 + ER3 + "+"
                        | ER2 + ER3 + "*"
                        | ER3 + "?"
                        | ER3;

            ER3.Rule = ID
                       | RANGO
                       | ascii;

            RETURN.Rule = r_return + "(" + ID + "," + RETURN2 + ")";

            RETURN2.Rule = MakeListRule(RETURN2, ToTerm(","), RETURN3);

            RETURN3.Rule =    r_texto
                            | r_linea
                            | r_columna
                            | r_cadena
                            | r_caracter
                            | r_entero
                            | r_flotante
                            | r_booleano;
                            
            RESERV.Rule = r_resev + "[" + SENTENCIAS + "]";
             
            ID.Rule = iden
                     | "\"" + iden + "\""
                     | "\"" + ascii + "\"";

            this.Root = S0;
        }
    }
}

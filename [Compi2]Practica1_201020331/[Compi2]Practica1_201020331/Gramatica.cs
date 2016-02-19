using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;    //libreria obligatorias de importar
using Irony.Ast;        //libreria obligatoria de importar
using System.Collections;

namespace _Compi2_Practica1_201020331
{
    class Gramatica : Grammar
    {
        public Gramatica()
        {
            
            //1. TERMINALES
            //Terminales Definidos en base a expresiones regulares
            IdentifierTerminal iden = new IdentifierTerminal("iden");
            StringLiteral cadena = new StringLiteral("cadena", "\"");
            RegexBasedTerminal caracter = new RegexBasedTerminal("caracter", "\"[^\020\013\010\009\042]\"");
            RegexBasedTerminal rango1 = new RegexBasedTerminal("rango1", "([^\020\013\010\009]|[0-9]+)~([^\020\013\010\009]|[0-9]+)");
            RegexBasedTerminal rango2 = new RegexBasedTerminal("rango2", "([^\020\013\010\009]|[0-9]+)(,([^\020\013\010\009]|[0-9]+))+");
            //Terminales definidos de manera especifica
            var inicio_fin = ToTerm("%%");
            var s_apuntar = ToTerm("->");
            var s_colon = ToTerm(":");
            var s_or = ToTerm("|");
            var s_mul = ToTerm("*");
            var s_sum = ToTerm("+");
            var s_ques = ToTerm("?");
            var s_dot = ToTerm(".");
            var s_enter = ToTerm("\n");
            var s_quo = ToTerm("\'");
            var s_doquo = ToTerm("\"");
            var s_tab = ToTerm("\t");
            var s_white = ToTerm("[:blanco:]");
            var s_all = ToTerm("[todo:]");
            var s_par_a = ToTerm("(");
            var s_par_c = ToTerm(")");
            var s_key_a = ToTerm("[");
            var s_key_c = ToTerm("]");
            var s_cor_a = ToTerm("{");
            var s_cor_c = ToTerm("}");
            var s_semicolon = ToTerm(";");
            var s_comma = ToTerm(",");
            var r_return = ToTerm("retorno");
            var r_string = ToTerm("string");
            var r_char = ToTerm("char");
            var r_int = ToTerm("int");
            var r_float = ToTerm("float");
            var r_bool = ToTerm("bool");
            var r_text = ToTerm("yytext");
            var r_line = ToTerm("yyline");
            var r_row = ToTerm("yyrow"); 
            var r_conj = ToTerm("CONJ");
            var r_reserv = ToTerm("RESERV");
            var r_all = ToTerm("[:Todo:]");
            var r_white = ToTerm("[:Blanco:]");
            
            //2. NO TERMINALES
            NonTerminal S0 = new NonTerminal("S0");
            NonTerminal LENGUAJE = new NonTerminal("LENGUAJE");
            NonTerminal SENTENCIAS = new NonTerminal("SENTENCIAS");
            NonTerminal SENTENCIA = new NonTerminal("SENTENCIA");
            NonTerminal CONJUNTO = new NonTerminal("CONJUNTO");
            NonTerminal EXPRESIONES = new NonTerminal("EXPRESIONES");
            NonTerminal EXPRESION = new NonTerminal("EXPRESION");
            NonTerminal ER = new NonTerminal("ER");
            NonTerminal ER2 = new NonTerminal("ER2");
            NonTerminal ER3 = new NonTerminal("ER3");
            NonTerminal ID = new NonTerminal("ID");
            NonTerminal RETURN = new NonTerminal("RETURN");
            NonTerminal RETURN2 = new NonTerminal("RETURN2");
            NonTerminal RETURN3 = new NonTerminal("RETURN3");
            NonTerminal RESERV = new NonTerminal("RESERV");
            NonTerminal RESERV2 = new NonTerminal("RESERV");
            NonTerminal RESERV3 = new NonTerminal("RESERV");

            //3. PRECEDENCIA DE OPERADORES

            //4. TERMINOS DE PUNTUACION

            //5. GRAMATICA
            S0.Rule = LENGUAJE;

            LENGUAJE.Rule = inicio_fin + SENTENCIAS + inicio_fin;

            SENTENCIAS.Rule = MakePlusRule(SENTENCIAS, SENTENCIA); 

            SENTENCIA.Rule = CONJUNTO
                            | EXPRESION;

            CONJUNTO.Rule = r_conj + s_colon + iden + s_apuntar + rango1 + s_semicolon
                           | r_conj + s_colon + iden + s_apuntar + rango2 + s_semicolon;
                           
            EXPRESION.Rule = iden + s_apuntar + ER + s_apuntar + RETURN + s_semicolon
                            | iden + s_apuntar + ER + s_apuntar + RETURN + s_apuntar+ RESERV + s_semicolon ;

            ER.Rule = ER2
                      | ER3
                      | ID;

            ER2.Rule = ER + ER + s_or
                | ER + ER + s_dot;

            ER3.Rule = ER + s_mul
                 | ER + s_sum
                 | ER + s_ques;         
            

            ID.Rule = iden
                      | caracter
                      | rango1
                      | rango2;

            RETURN.Rule = r_return + s_par_a + iden + s_comma + RETURN2 + s_par_c;

            RETURN2.Rule = MakeListRule(RETURN2, s_comma, RETURN3);

            RETURN3.Rule = r_text
                            | r_line
                            | r_row
                            | r_string
                            | r_char
                            | r_float
                            | r_int
                            | r_bool;

            RESERV.Rule = r_reserv + s_apuntar + s_key_a + RESERV2 + s_key_c;

            RESERV2.Rule = MakePlusRule(RESERV2, RESERV3);

            RESERV3.Rule = cadena + s_apuntar + RETURN + s_semicolon;

            this.Root = S0;
            //this.MarkTransient(SENTENCIAS);
        }
    }
}

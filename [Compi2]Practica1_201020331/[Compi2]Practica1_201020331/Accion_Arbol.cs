using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;
using System.Windows.Forms;
using System.Collections;

namespace _Compi2_Practica1_201020331
{
    class Accion_Arbol : Accion
    {
        Core subir = new Core();
        public object do_action(ParseTreeNode pt_node)
        {
            return action(pt_node);
            //throw new NotImplementedException();
        }

        public object action(ParseTreeNode node)
        {
            Object result = null;
            switch (node.Term.Name.ToString())
            {
                case "S0":
                    {
                        if (node.ChildNodes.Count == 1)
                        {

                            result = node.ChildNodes[0];
                        }
                        break;
                    }
                case "LENGUAJE":
                    {
                        if(node.ChildNodes.Count == 3)
                        {
                            result = node.ChildNodes[1];

                        }
                        break;
                    }
                case "SENTENCIAS":
                    {
                        int cont = 0;
                        for (cont = 0; cont < node.ChildNodes.Count; cont++)
                        {
                            result = node.ChildNodes[cont];

                        }
                        break;
                    }
                case "SENTENCIA":
                    {
                        if (node.ChildNodes.Count == 1)
                        {
                            result = node.ChildNodes[0];
                        }
                        break;
                    }
                case "CONJUNTO":
                    {
                        if (node.ChildNodes.Count == 6)
                        {
                            Conjunto conjunto = new Conjunto();
                            String nombre = action(node.ChildNodes[3]).ToString();
                            conjunto.setNombre(nombre);
                            subir.getListaConjuntos().Add(conjunto);
                            result = subir;
                        }
                        break;
                    }
                case "EXPRESION":
                    {
                        if(node.ChildNodes.Count == 6)
                        {

                        }
                        if(node.ChildNodes.Count == 8)
                        {

                        }
                        break;
                    }
                case "ER":
                    {
                        if (node.ChildNodes.Count == 1)
                        {
                            String er = action(node.ChildNodes[0]).ToString();
                            result = er;
                        }
                        break;
                    }
                case "ER2":
                    {
                        if( node.ChildNodes.Count == 3)
                        {
                            String er = "(" + action(node.ChildNodes[0]).ToString() + ")" + action(node.ChildNodes[2]).ToString() + "(" + action(node.ChildNodes[1]).ToString() + ")";
                            result = er;
                        }
                        break;
                    }
                case "ER3":
                    {
                        if(node.ChildNodes.Count == 2)
                        {
                            String er = "(" + action(node.ChildNodes[0]).ToString() + ")" + action(node.ChildNodes[1]).ToString();
                            result = er;
                        }
                        break;
                    }
                case "ID":
                    {
                        if(node.ChildNodes.Count == 1)
                        {
                            String id = action(node.ChildNodes[0]).ToString();
                            result = id;
                        }
                        break;
                    }
                case "RETURN":
                    {
                        if(node.ChildNodes.Count == 6)
                        {
                            ER expresion = new ER();
                            expresion.setId(true);
                            int cont = 0;
                            ArrayList retorno = (ArrayList)action(node.ChildNodes[5]);
                            for (cont = 0; cont < retorno.Count; cont++)
                            {
                                if (retorno[cont].ToString().Equals("yytext")) ;
                                {
                                    expresion.setTexto(true);
                                }else if (retorno[cont].ToString().Equals("yyline");
                                 {
                                    expresion.setLinea(true);
                                } else if (retorno[cont].ToString().Equals("yyrow");
                                {
                                    expresion.setColumna(true);
                                }
                                else
                                {
                                    expresion.setTipo(retorno[cont].ToString());
                                }
                            }

                        }
                        break;
                    }   
                case "RETURN2":
                    {
                        int cont = 0;
                        ArrayList retorno = new ArrayList();
                        for (cont = 0; cont < node.ChildNodes.Count; cont++)
                        {
                            retorno.Add(action(node.ChildNodes[cont]).ToString());
                        }
                        result = retorno;
                        break;
                    }                    
                case "RETURN3":
                    {
                        if (node.ChildNodes.Count == 1)
                        {
                            String valor = action(node.ChildNodes[0]).ToString();
                            result = valor;
                        }
                        break;
                    } 
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}

using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Compi2_Practica1_201020331
{
    class Accion_Arbol : Accion
    {
        Core core;
        String exp;
        ER nueva_expresion;
        Conjunto nuevo_conjunto;
        public Object do_action(ParseTreeNode pt_node)
        {
            return action(pt_node);
        }

        public Object action(ParseTreeNode node)
        {
            Object result = null;
            switch (node.Term.Name.ToString())
            {
                case "S0":
                {
                        if(node.ChildNodes.Count == 1)
                        {
                            core = new Core();
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            result = action(node.ChildNodes[0]);
                        }
                        break;
                }
                case "LENGUAJE":
                    {
                        if(node.ChildNodes.Count == 3)
                        {
                            //System.Windows.Forms.MessageBox.Show("ENTRO A LENGUAJE");
                            result = action(node.ChildNodes[1]);
                        }
                        break;
                    }
                case "SENTENCIAS":
                    {
                        //MessageBox.Show("ENTRO A SENTENCIAS, TIENE " + node.ChildNodes.Count + "hijos");
                        int cont = 0;
                        for (cont = 0; cont < node.ChildNodes.Count; cont++)
                        {                           
                            result = action(node.ChildNodes[cont]);
                        }
                        break;
                    }
                case "SENTENCIA":
                    {
                        if(node.ChildNodes.Count == 1)
                        {
                            //MessageBox.Show("ENTRO A SeNTenCIa");
                            result = action(node.ChildNodes[0]);
                        }
                        break;
                    }
                case "CONJUNTO":
                    {
                        if(node.ChildNodes.Count == 6)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            nuevo_conjunto = new Conjunto();
                            nuevo_conjunto.setNombre(node.ChildNodes[2].Token.Value.ToString());
                            core.getListaConjuntos().Add(nuevo_conjunto);
                        }
                        break;
                    }
                case "EXPRESION":
                    {
                        if(node.ChildNodes.Count == 6)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            nueva_expresion = new ER();
                            nueva_expresion.setNombre(node.ChildNodes[0].Token.Value.ToString());
                            nueva_expresion.setExpresion((action(node.ChildNodes[2]).ToString()));
                            result = action(node.ChildNodes[4]);
                            core.getListaExpresiones().Add(nueva_expresion);     
                        }
                        if(node.ChildNodes.Count == 8)
                        {
                            System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            nueva_expresion = new ER();
                            nueva_expresion.setNombre(node.ChildNodes[0].Token.Value.ToString());
                            nueva_expresion.setNombre((action(node.ChildNodes[2]).ToString()));
                            result = action(node.ChildNodes[4]);
                            result = action(node.ChildNodes[6]);
                            core.getListaExpresiones().Add(nueva_expresion);
                        }
                        break;
                    }
                case "ER":
                    {
                        if(node.ChildNodes.Count == 1)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            result = action(node.ChildNodes[0]);
                        }
                        break;
                    }
                case "ER2":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        exp = "(" + action(node.ChildNodes[0]).ToString() + ")" + node.ChildNodes[2].Token.Value.ToString() + "("+action(node.ChildNodes[1]).ToString()+")";
                        result = exp;
                        break;
                    }
                case "ER3":
                    {
                        if(node.ChildNodes.Count == 2)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            exp = "(" + action(node.ChildNodes[0]).ToString() + ")" + node.ChildNodes[1].Token.Value.ToString();
                            result = exp;
                        }
                        break;
                    }
                case "ID":
                    {
                        if (node.ChildNodes.Count() == 1)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            result = action(node.ChildNodes[0]);
                        }
                        break;
                    }
                case "RETURN":
                    {
                        if(node.ChildNodes.Count == 6)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            nueva_expresion.setId(true);
                            result = action(node.ChildNodes[4]);
                        }
                        break;
                    }
                case "RETURN2":
                    { 
                    MessageBox.Show("RETURN2 TIENE " + node.ChildNodes.Count + " hijos");
                    int cont = 0;
                    for (cont = 0; cont < node.ChildNodes.Count; cont++)
                    {
                        result = action(node.ChildNodes[cont]);
                    }
                    break;
                    }
                case "RETURN3":
                    {
                        if(node.ChildNodes.Count == 1)
                        {
                            //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                            result = action(node.ChildNodes[0]);
                        }
                        break;
                    }
                case "caracter":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        result = node.Token.Value;
                        break;
                    }
                case "iden":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        result = node.Token.Value;
                        break;
                    }
                case "rango1":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        result = node.Token.Value;
                        break;
                    }
                case "rango2":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        result = node.Token.Value;
                        break;
                    }
                case "r_string":
                    {
                        System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setTipo("string");
                        break;
                    }
                case "r_char":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setTipo("char");
                        break;
                    }
                case "r_int":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setTipo("int");
                        break;
                    }
                case "r_float":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setTipo("float");
                        break;
                    }
                case "r_bool":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setTipo("bool");
                        break;
                    }
                case "yytext":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setTexto(true);
                        break;
                    }
                case "yyline":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setLinea(true);
                        break;
                    }
                case "yyrow":
                    {
                        //System.Windows.Forms.MessageBox.Show(node.Term.Name.ToString());
                        nueva_expresion.setColumna(true);
                        break;
                    }
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}

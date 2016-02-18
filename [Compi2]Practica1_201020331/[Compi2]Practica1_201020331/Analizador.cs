using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;
using System.Diagnostics;

namespace _Compi2_Practica1_201020331
{
    class Analizador
    {
        private Grammar gramatica;

        private Analizador()
        {
            gramatica = null;
        }

        public Analizador(Grammar gramatica)
        {
            this.gramatica = gramatica;
        }

        public Object parse(string str, Accion action)
        {
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser p = new Parser(lenguaje);
            ParseTree s_tree = p.Parse(str);
            if (s_tree.Root != null)
            {
                ActionMaker act = new ActionMaker(s_tree.Root);
                act.escribir_arbol();
                return act.getEval(action);
            }
            return null;
        }

        private class ActionMaker
        {
            private ParseTreeNode root;
            System.IO.StreamWriter escribir;

            public ActionMaker(ParseTreeNode pt_root)
            {
                root = pt_root;
            }

            public Object getEval(Accion action)
            {
                //evaluar el árbol
                return action.do_action(root);
            }

            public void escribir_arbol()
            {
                escribir = new System.IO.StreamWriter("C:\\Practica1\\ast.dot");
                escribir.Write("digraph ast{\n");
                graficar_arbol(root);
                escribir.Write("\n}");
                escribir.Close();
                generar_arbol();
            }
            public void graficar_arbol(ParseTreeNode pt_root)
            {
                if(pt_root != null)
                {
                    escribir.Write(pt_root.GetHashCode()+"[shape = ellipse ,label=\""+ pt_root.Term.Name.ToString()+"\"];\n");
                    if (pt_root.ChildNodes.Count > 0)
                    {
                        ParseTreeNode[] hijos = pt_root.ChildNodes.ToArray();
                        for (int cont = 0; cont < pt_root.ChildNodes.Count; cont++)
                        {
                            graficar_arbol(hijos[cont]);
                            escribir.Write(pt_root.GetHashCode() + "->"+hijos[cont].GetHashCode() + ";\n");
                        }
                    }

                }
            }
            public void generar_arbol()
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Graphviz\\bin\\dot.exe");
                    startInfo.Arguments = "-Tjpg  C:\\Practica1\\ast.dot -o C:\\Practica1\\ast.jpg";
                    Process.Start(startInfo);
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR EN LA EJECUCION DE LA IMAGEN DEL ARBOL DE EXPRESIONES" + e.ToString());
                }
            }
        }
    }
}

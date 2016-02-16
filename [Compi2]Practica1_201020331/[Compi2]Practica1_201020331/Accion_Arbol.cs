using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing; 

namespace _Compi2_Practica1_201020331
{
    class Accion_Arbol : Accion
    {
        public object action(ParseTreeNode pt_node)
        {
            return action(pt_node);
            //throw new NotImplementedException();
        }

        public object do_action(ParseTreeNode node)
        {
            Object result = null;
            switch (node.Term.Name.ToString())
            {
                case "S0":
                    {
                        if (node.ChildNodes.Count == 1)
                        {
                            result = "aceptado";
                        }
                        break;
                    }
            }
            return result;
            //throw new NotImplementedException();
        }
    }
}

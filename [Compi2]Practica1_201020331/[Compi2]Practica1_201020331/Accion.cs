using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace _Compi2_Practica1_201020331
{
        interface Accion
        {
            Object do_action(ParseTreeNode pt_node);
            Object action(ParseTreeNode pt_node);
        }   
}

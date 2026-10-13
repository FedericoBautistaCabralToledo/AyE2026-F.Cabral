using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Tree
    {
        public Nodo raiz { get; set; }

        public Tree()
        {
            raiz = null;
        }
        public void Insertar()
        {
            raiz = insertarRecursivo(raiz);
        }
        public Nodo insertarRecursivo(Nodo nodoActual)
        {
            if (nodoActual == null)
            {
                return new Nodo();
            }

            if (Agentes.id < nodoActual.id)
            {
                nodoActual.nodoIzquierdo = insertarRecursivo(nodoActual.nodoIzquierdo);
            }
            else if (Agentes.id > nodoActual.id)
            {
                nodoActual.nodoDerecho = insertarRecursivo(nodoActual.nodoDerecho);
            }

            return nodoActual;
        }

        public string buscar(int idBuscado)
        {
            if (raiz == null)
            {
                return "El árbol está vacío.";
            }
            return (raiz,idBuscado);
        }
    }
}

       

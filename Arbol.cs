using System;

namespace ConsoleApp1
{
    public class Arbol
    {
        public Nodo raiz { get; set; }

        public Arbol()
        {
            raiz = null;
        }

        public void insertar(int valor)
        {
            raiz = insertarRecursivo(raiz, valor);
        }

        public Nodo insertarRecursivo(Nodo nodoActual, int valor)
        {
            if (nodoActual == null)
            {
                return new Nodo(valor);
            }
            if (valor < nodoActual.valor)
            {
                nodoActual.izquierdo = insertarRecursivo(nodoActual.izquierdo, valor);
            }
            else if (valor > nodoActual.valor)
            {
                nodoActual.derecho = insertarRecursivo(nodoActual.derecho, valor);
            }

            return nodoActual;
        }

        public bool buscar(int valor)
        {
            return buscarRecursivo(raiz, valor);
        }

        public bool buscarRecursivo(Nodo nodoactual, int valor)
        {
            if (nodoactual == null)
            {
                return false;
            }
            if (nodoactual.valor == valor)
            {
                return true;
            }
            if (valor < nodoactual.valor)
            {
                return buscarRecursivo(nodoactual.izquierdo, valor);
            }
            else
            {
                return buscarRecursivo(nodoactual.derecho, valor);
            }
        }


        public int ObtenerMinimo()
        {
            if (raiz == null)
                throw new InvalidOperationException("El arbol esta vacio.");

            Nodo actual = raiz;
            while (actual.izquierdo != null)
            {
                actual = actual.izquierdo;
            }
            return actual.valor;
        }

        public int ObtenerMaximo()
        {
            if (raiz == null)
                throw new InvalidOperationException("El arbol esta vacio.");

            Nodo actual = raiz;
            while (actual.derecho != null)
            {
                actual = actual.derecho;
            }
            return actual.valor;
        }

        public int ObtenerCantidadNodos()
        {
            return ContarNodosRecursivo(raiz);
        }

        public int ContarNodosRecursivo(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            return ContarNodosRecursivo(nodo.izquierdo) + ContarNodosRecursivo(nodo.derecho) + 1;
        }
    }
}
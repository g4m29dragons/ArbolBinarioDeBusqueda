using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_arboles_binarios
{
    internal class ArbolBinario
    {
        public Nodo Raiz { get; private set; }

        public ArbolBinario()
        {
            Raiz = null; // El árbol está vacío inicialmente
        }

        public void Limpiar()
        {
            Raiz = null;
        }

        // Método para agregar un nodo al árbol binario de búsqueda
        public void AgregarNodo(int valor)
        {
            Raiz = InsertarNodo(Raiz, valor); // Llamada recursiva para insertar el nodo
        }

        private Nodo AgregarNodo(Nodo nodo, int valor)
        {
            if (nodo == null)
                return new Nodo(valor);

            if (valor < nodo.Valor)
                nodo.Izquierdo = AgregarNodo(nodo.Izquierdo, valor);
            else if (valor > nodo.Valor)
                nodo.Derecho = AgregarNodo(nodo.Derecho, valor);

            return nodo;
        }

        // Método recursivo para insertar un nodo en el árbol
        private Nodo InsertarNodo(Nodo nodo, int valor)
        {
            // Si el nodo es null, crea uno nuevo
            if (nodo == null)
            {
                return new Nodo(valor);
            }

            // Si el valor es menor que el valor del nodo actual, va a la izquierda
            if (valor < nodo.Valor)
            {
                nodo.Izquierdo = InsertarNodo(nodo.Izquierdo, valor);
            }
            // Si el valor es mayor que el valor del nodo actual, va a la derecha
            else if (valor > nodo.Valor)
            {
                nodo.Derecho = InsertarNodo(nodo.Derecho, valor);
            }

            // Si el valor ya existe, no se agrega (puedes agregar un mensaje de advertencia aquí si lo prefieres)
            return nodo;
        }

        public void Insertar(int valor)
        {
            if (Raiz == null)
                Raiz = new Nodo(valor);
            else
                InsertarRecursivo(Raiz, valor);
        }

        private void InsertarRecursivo(Nodo nodo, int valor)
        {
            if (valor == nodo.Valor) return; // Ignorar duplicados
            if (valor < nodo.Valor)
            {
                if (nodo.Izquierdo == null)
                    nodo.Izquierdo = new Nodo(valor);
                else
                    InsertarRecursivo(nodo.Izquierdo, valor);
            }
            else
            {
                if (nodo.Derecho == null)
                    nodo.Derecho = new Nodo(valor);
                else
                    InsertarRecursivo(nodo.Derecho, valor);
            }
        }

        public List<int> RecorridoPreorden()
        {
            List<int> resultado = new List<int>();
            RecorridoPreorden(Raiz, resultado);
            return resultado;
        }

        private void RecorridoPreorden(Nodo nodo, List<int> resultado)
        {
            if (nodo != null)
            {
                resultado.Add(nodo.Valor);
                RecorridoPreorden(nodo.Izquierdo, resultado);
                RecorridoPreorden(nodo.Derecho, resultado);
            }
        }

        public List<int> RecorridoInorden()
        {
            List<int> resultado = new List<int>();
            RecorridoInorden(Raiz, resultado);
            return resultado;
        }

        private void RecorridoInorden(Nodo nodo, List<int> resultado)
        {
            if (nodo != null)
            {
                RecorridoInorden(nodo.Izquierdo, resultado);
                resultado.Add(nodo.Valor);
                RecorridoInorden(nodo.Derecho, resultado);
            }
        }

        public List<int> RecorridoPosorden()
        {
            List<int> resultado = new List<int>();
            RecorridoPosorden(Raiz, resultado);
            return resultado;
        }

        private void RecorridoPosorden(Nodo nodo, List<int> resultado)
        {
            if (nodo != null)
            {
                RecorridoPosorden(nodo.Izquierdo, resultado);
                RecorridoPosorden(nodo.Derecho, resultado);
                resultado.Add(nodo.Valor);
            }
        }
    }
}

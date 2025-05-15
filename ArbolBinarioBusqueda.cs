using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_arboles_binarios
{
    internal class ArbolBinarioBusqueda
    {
        public Nodo Raiz { get; set; }
        public List<int> ObtenerPreorden()
        {
            var recorrido = new List<int>();
            Preorden(Raiz, recorrido);
            return recorrido;
        }

        public List<int> ObtenerInorden()
        {
            var recorrido = new List<int>();
            Inorden(Raiz, recorrido);
            return recorrido;
        }

        public List<int> ObtenerPosorden()
        {
            var recorrido = new List<int>();
            Posorden(Raiz, recorrido);
            return recorrido;
        }

        // Métodos recursivos internos
        private void Preorden(Nodo nodo, List<int> recorrido)
        {
            if (nodo == null) return;
            recorrido.Add(nodo.Valor);
            Preorden(nodo.Izquierdo, recorrido);
            Preorden(nodo.Derecho, recorrido);
        }

        private void Inorden(Nodo nodo, List<int> recorrido)
        {
            if (nodo == null) return;
            Inorden(nodo.Izquierdo, recorrido);
            recorrido.Add(nodo.Valor);
            Inorden(nodo.Derecho, recorrido);
        }

        private void Posorden(Nodo nodo, List<int> recorrido)
        {
            if (nodo == null) return;
            Posorden(nodo.Izquierdo, recorrido);
            Posorden(nodo.Derecho, recorrido);
            recorrido.Add(nodo.Valor);
        }

    }
}

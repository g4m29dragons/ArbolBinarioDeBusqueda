using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_arboles_binarios
{
    public partial class Fase_4_árbol_binario : Form
    {
        private ArbolBinario arbol = new ArbolBinario();

        public Fase_4_árbol_binario()
        {
            InitializeComponent();
            // Asumir que tienes estos paneles ya definidos en el formulario
            panelPreorden.Paint += new PaintEventHandler(panelPreorden_Paint);
            panelInorden.Paint += new PaintEventHandler(panelInorden_Paint);
            panelPosorden.Paint += new PaintEventHandler(panelPosorden_Paint);

            panelArbol.Paint += PanelArbol_Paint;
        }

        // Paint para el panel de Preorden
        private void panelPreorden_Paint(object sender, PaintEventArgs e)
        {
            List<int> preorden = arbol.RecorridoPreorden();
            DibujarRecorrido(e.Graphics, preorden);
        }

        // Paint para el panel de Inorden
        private void panelInorden_Paint(object sender, PaintEventArgs e)
        {
            List<int> inorden = arbol.RecorridoInorden();
            DibujarRecorrido(e.Graphics, inorden);
        }

        // Paint para el panel de Posorden
        private void panelPosorden_Paint(object sender, PaintEventArgs e)
        {
            List<int> posorden = arbol.RecorridoPosorden();
            DibujarRecorrido(e.Graphics, posorden);
        }

        // Actualiza los recorridos en los tres paneles
        private void ActualizarRecorridos()
        {
            panelPreorden.Invalidate();
            panelInorden.Invalidate();
            panelPosorden.Invalidate();
        }

        // Dibuja los valores de los recorridos sobre el panel
        private void DibujarRecorrido(Graphics g, List<int> recorrido)
        {
            int x = 10;
            int y = 10;

            foreach (var valor in recorrido)
            {
                g.FillEllipse(Brushes.LightGreen, x, y, 30, 30);
                g.DrawEllipse(Pens.Black, x, y, 30, 30);
                g.DrawString(valor.ToString(), Font, Brushes.Black, x + 10, y + 10);

                x += 40;
            }
        }

        // Método para dibujar el árbol binario sobre panelArbol
        private void PanelArbol_Paint(object sender, PaintEventArgs e)
        {
            if (arbol.Raiz != null)
                DibujarArbol(e.Graphics, arbol.Raiz, panelArbol.Width / 2, 20, panelArbol.Width / 4, 1);
        }

        private int CalcularDistancia(int valorPadre, int valorHijo, int offsetX)
        {
            // Factor proporcional a la diferencia de valores
            int factorEscalado = 2; // Ajusta según el comportamiento que desees
            int diferencia = Math.Abs(valorPadre - valorHijo);

            // Cuanto mayor sea la diferencia, mayor será la distancia
            int distancia = offsetX + (diferencia * factorEscalado);

            // Limitar la distancia mínima y máxima
            int distanciaMinima = 45; // Evita que los nodos queden demasiado juntos
            int distanciaMaxima = offsetX * 2; // Evita distancias demasiado grandes
            if (distancia < distanciaMinima)
                distancia = distanciaMinima;
            if (distancia > distanciaMaxima)
                distancia = distanciaMaxima;

            return distancia;
        }

        // Dibuja el árbol binario
        private void DibujarArbol(Graphics g, Nodo nodo, int x, int y, int offsetX, int nivel)
        {
            if (nodo == null || nivel > 4) return;

            g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
            g.DrawString(nodo.Valor.ToString(), Font, Brushes.Black, x - 10, y - 10);

            if (nodo.Izquierdo != null)
            {
                int distanciaIzquierda = CalcularDistancia(nodo.Valor, nodo.Izquierdo.Valor, offsetX);
                g.DrawLine(Pens.Black, x, y, x - distanciaIzquierda, y + 50);
                DibujarArbol(g, nodo.Izquierdo, x - distanciaIzquierda, y + 50, offsetX / 2, nivel + 1);
            }

            if (nodo.Derecho != null)
            {
                int distanciaDerecha = CalcularDistancia(nodo.Valor, nodo.Derecho.Valor, offsetX);
                g.DrawLine(Pens.Black, x, y, x + distanciaDerecha, y + 50);
                DibujarArbol(g, nodo.Derecho, x + distanciaDerecha, y + 50, offsetX / 2, nivel + 1);
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valorNodo;

            // Validar si el texto ingresado es un número entero válido
            if (int.TryParse(txtNodo.Text, out valorNodo))
            {
                // Agregar el nodo al árbol binario
                arbol.AgregarNodo(valorNodo);

                // Redibujar el árbol en el panel
                panelArbol.Invalidate();

                // Actualizar los recorridos
                ActualizarRecorridos();

                // Limpiar el cuadro de texto
                txtNodo.Clear();
            }
            else
            {
                // Mostrar un mensaje de error si la entrada no es válida
                MessageBox.Show("Por favor, ingresa un número entero válido.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia el árbol
            arbol.Limpiar(); // Asegúrate de que exista un método Limpiar() en tu clase ArbolBinario.

            // Limpia el área de dibujo
            panelArbol.Invalidate();

            // Limpia también los paneles de recorridos
            panelPreorden.Invalidate();
            panelInorden.Invalidate();
            panelPosorden.Invalidate();

            // Opcional: Limpia etiquetas, cuadros de texto u otros controles
            txtNodo.Clear();

            // (Opcional) Mensaje de confirmación
            MessageBox.Show("El árbol y los recorridos han sido limpiados.", "Limpieza completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

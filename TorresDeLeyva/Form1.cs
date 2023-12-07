using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresDeLeyva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Mensaje(string texto)
        {
            MessageBox.Show(""+texto);
        }
        private string MensajeArray(int[,] arr)
        {
            string texto = "";
            for (int fila = 0; fila < registro.GetLength(0); fila++)
            {
                for (int columna = 0; columna < registro.GetLength(1); columna++)
                {
                    texto += (registro[fila, columna] + "\t");
                }
                texto += "\n"; 
            }
            return texto;
        }
        private void centrarPanelInternoHorizontal(Panel panelInterno, Panel panelExterno)
        {
            // Calcular las coordenadas para centrar el panel interno horizontalmente dentro del panel externo
            int x = (panelExterno.Width - panelInterno.Width) / 2;
            // Establecer la nueva posición del panel interno
            panelInterno.Location = new Point(x, panelInterno.Location.Y);
        }
        private void setGrande(Panel pan1, Panel pan2)
        {
            pan1.Size = new Size(108, pan1.Size.Height);
            centrarPanelInternoHorizontal(pan1, pan2);
        }
        private void setMediano(Panel pan1, Panel pan2)
        {
            pan1.Size = new Size(84, pan1.Size.Height);
            centrarPanelInternoHorizontal(pan1, pan2);  
        }
        private void setPeque(Panel pan1, Panel pan2)
        {
            pan1.Size = new Size(61, pan1.Size.Height);
            centrarPanelInternoHorizontal(pan1, pan2);
        }
        Stack<int> pilaBast0 = new Stack<int>();
        Stack<int> pilaBast1 = new Stack<int>();
        Stack<int> pilaBast2 = new Stack<int>();
        Stack<int> pilaBast3 = new Stack<int>();
        int[,] registro = {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0}
        };
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Text = "Reiniciar";
            registro = new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0}
            };

            Random random = new Random();

            // Asegurar que haya al menos un 1, un 2 y un 3 por fila
            for (int grupo = 0; grupo < 3; grupo++)
            {
                // Obtener las filas correspondientes al grupo
                int filaInicio = grupo * 3;
                int filaFin = filaInicio + 2;

                // Desordenar la lista de números específicos
                int[] numeros = { 1, 2, 3 };
                Shuffle(numeros, random);

                // Asignar un número específico a cada columna en el grupo actual
                for (int i = 0; i < 3; i++)
                {
                    int columna;
                    do
                    {
                        // Desordenar la lista de columnas
                        List<int> columnasDisponibles = Enumerable.Range(0, 4).ToList();
                        Shuffle(columnasDisponibles, random);

                        // Obtener la primera columna disponible
                        columna = columnasDisponibles[0];

                        // Verificar si la columna ya contiene el número
                    } while (registro[filaInicio + i, columna] != 0);

                    // Asignar número a columna en la fila
                    registro[filaInicio + i, columna] = numeros[i];
                }
            }
            Mensaje("Tabla: \n" + MensajeArray(registro));
            
        }
        static void Shuffle<T>(T[] array, Random random)
        {
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        static void Shuffle(List<int> list, Random random)
        {
            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}

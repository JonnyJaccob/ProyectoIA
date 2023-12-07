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
            pilaBast0 = new Stack<int>();
            pilaBast1 = new Stack<int>();
            pilaBast2 = new Stack<int>();
            pilaBast3 = new Stack<int>();
            //setGrande(pnBast1Lv3, pnContenedorJg1);
            //setMediano(pnBast1Lv2, pnContenedorJg1);
            //setPeque(pnBast1Lv1, pnContenedorJg1);
            var lista = new List<int> { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            // Crear un objeto Random para utilizarlo en el desordenamiento
            Random random = new Random();

            // Desordenar la lista utilizando el método Shuffle
            var listaDesordenada = lista.OrderBy(x => random.Next()).ToList();
            Mensaje(string.Join(", ", listaDesordenada));
            int contV = 0,contR = 0,contA = 0;

            while (listaDesordenada.Count > 0)
            {
                int aleatorio = random.Next(1,5);
                switch (aleatorio)
                {
                    case 1:
                        if (pilaBast0.Count < 3)
                        {
                            int ultimoElemento = listaDesordenada.Last();
                            listaDesordenada.RemoveAt(listaDesordenada.Count - 1);
                            pilaBast0.Push(ultimoElemento);
                            int fila;
                            if(contV < 3)
                            {
                                fila = contV;
                                contV++;
                            }else if(contR < 3){
                                fila = contR + 3;
                                contR++;
                            }
                            else
                            {
                                fila = contA + 6;
                                contA++;
                            }
                            int Tamaño = ultimoElemento;
                            registro[fila, 0] = Tamaño;
                        }
                        break;
                    case 2:
                        if (pilaBast1.Count < 3)
                        {
                            int ultimoElemento = listaDesordenada.Last();
                            listaDesordenada.RemoveAt(listaDesordenada.Count - 1);
                            pilaBast1.Push(ultimoElemento);
                            int fila;
                            if (contV < 3)
                            {
                                fila = contV;
                                contV++;
                            }
                            else if (contR < 3)
                            {
                                fila = contR + 3;
                                contR++;
                            }
                            else
                            {
                                fila = contA + 6;
                                contA++;
                            }
                            int Tamaño = ultimoElemento;
                            registro[fila, 1] = Tamaño;
                        }
                        break;
                    case 3:
                        if (pilaBast2.Count < 3)
                        {
                            int ultimoElemento = listaDesordenada.Last();
                            listaDesordenada.RemoveAt(listaDesordenada.Count - 1);
                            pilaBast2.Push(ultimoElemento);
                            int fila;
                            if (contV < 3)
                            {
                                fila = contV;
                                contV++;
                            }
                            else if (contR < 3)
                            {
                                fila = contR + 3;
                                contR++;
                            }
                            else
                            {
                                fila = contA + 6;
                                contA++;
                            }
                            int Tamaño = ultimoElemento;
                            registro[fila, 2] = Tamaño;
                        }
                        break;
                    case 4:
                        if (pilaBast3.Count < 3)
                        {
                            int ultimoElemento = listaDesordenada.Last();
                            listaDesordenada.RemoveAt(listaDesordenada.Count - 1);
                            pilaBast3.Push(ultimoElemento);
                            int fila;
                            if (contV < 3)
                            {
                                fila = contV;
                                contV++;
                            }
                            else if (contR < 3)
                            {
                                fila = contR + 3;
                                contR++;
                            }
                            else
                            {
                                fila = contA + 6;
                                contA++;
                            }
                            int y = ultimoElemento;
                            int Tamaño = ultimoElemento;
                            registro[fila, 3] = Tamaño;
                        }
                        break;
                }
            }
            Mensaje("Tabla: \n" + MensajeArray(registro));
            for (int i = 0; i < registro.GetLength(0); i++)
            {

                for (int j = 0; j < registro.GetLength(1); j++)
                {

                }
            }
        }
    }
}

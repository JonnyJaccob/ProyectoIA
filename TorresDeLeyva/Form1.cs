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
        private string MensajeMatriz(int[,] arr)
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
        private string MensajeArreglo(int[] arr)
        {
            string texto = "";
            for (int i = 0; i < arr.Length; i++)
            {
                texto += (arr[i] + "\t");
            }
            texto += "\n";
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
            int cont = 0;
            int vuelta = 0;
            while(cont < 9 && vuelta < 1000)
            {
                vuelta++;
                // Obtener un número entre 0 y 3
                int numeroColumna = random.Next(0, 4);
                // Obtener un número entre 1 y 3
                int numeroCategoria = random.Next(1, 4);
                int[] arrray = ObtenerElementosColumna(numeroColumna-1);
                if (!arrray.Contains(1))
                {
                    switch (numeroCategoria)
                    {
                        case 1:
                            if (!TieneValorEnFila(0))
                            {   
                                int[] fila1 = ObtenerFila(0);
                                if (fila1.Contains(1))
                                {
                                    registro[0, numeroColumna] = 1;
                                    cont++;
                                }
                                
                                
                            }else if (!TieneValorEnFila(1))
                            {
                                int[] fila2 = ObtenerFila(1);
                                if (fila2.Contains(1))
                                {
                                    registro[1, numeroColumna] = 1;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2))
                            {
                                int[] fila3 = ObtenerFila(2);
                                if (fila3.Contains(1))
                                {
                                    registro[2, numeroColumna] = 1;
                                    cont++;
                                }
                            }
                                break;
                        case 2:
                            if (!TieneValorEnFila(0+3))
                            {
                                int[] fila = ObtenerFila(0+3);
                                if (fila.Contains(1))
                                {
                                    registro[0+3, numeroColumna] = 1;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1+3))
                            {
                                int[] fila = ObtenerFila(1+3);
                                if (fila.Contains(1))
                                {
                                    registro[1+3, numeroColumna] = 1;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2+3))
                            {
                                int[] fila = ObtenerFila(2+3);
                                if (fila.Contains(1))
                                {
                                    registro[2+3, numeroColumna] = 1;
                                    cont++;
                                }
                            }
                            break;
                        case 3:
                            if (!TieneValorEnFila(0 + 6))
                            {
                                int[] fila = ObtenerFila(0 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[0 + 6, numeroColumna] = 1;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1 + 6))
                            {
                                int[] fila = ObtenerFila(1 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[1 + 6, numeroColumna] = 1;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2 + 6))
                            {
                                int[] fila = ObtenerFila(2 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[2 + 6, numeroColumna] = 1;
                                    cont++;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }else if (!arrray.Contains(2))
                {
                    switch (numeroCategoria)
                    {
                        case 1:
                            if (!TieneValorEnFila(0))
                            {
                                int[] fila1 = ObtenerFila(0);
                                if (fila1.Contains(1))
                                {
                                    registro[0, numeroColumna] = 2;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1))
                            {
                                int[] fila2 = ObtenerFila(1);
                                if (fila2.Contains(1))
                                {
                                    registro[1, numeroColumna] = 2;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2))
                            {
                                int[] fila3 = ObtenerFila(2);
                                if (fila3.Contains(1))
                                {
                                    registro[2, numeroColumna] = 2;
                                    cont++;
                                }
                            }
                            break;
                        case 2:
                            if (!TieneValorEnFila(0 + 3))
                            {
                                int[] fila = ObtenerFila(0 + 3);
                                if (fila.Contains(1))
                                {
                                    registro[0 + 3, numeroColumna] = 2;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1 + 3))
                            {
                                int[] fila = ObtenerFila(1 + 3);
                                if (fila.Contains(1))
                                {
                                    registro[1 + 3, numeroColumna] = 2;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2 + 3))
                            {
                                int[] fila = ObtenerFila(2 + 3);
                                if (fila.Contains(1))
                                {
                                    registro[2 + 3, numeroColumna] = 2;
                                    cont++;
                                }
                            }
                            break;
                        case 3:
                            if (!TieneValorEnFila(0 + 6))
                            {
                                int[] fila = ObtenerFila(0 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[0 + 6, numeroColumna] = 2;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1 + 6))
                            {
                                int[] fila = ObtenerFila(1 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[1 + 6, numeroColumna] = 2;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2 + 6))
                            {
                                int[] fila = ObtenerFila(2 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[2 + 6, numeroColumna] = 2;
                                    cont++;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (!arrray.Contains(3))
                {
                    switch (numeroCategoria)
                    {
                        case 1:
                            if (!TieneValorEnFila(0))
                            {
                                int[] fila1 = ObtenerFila(0);
                                if (fila1.Contains(1))
                                {
                                    registro[0, numeroColumna] = 3;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1))
                            {
                                int[] fila2 = ObtenerFila(1);
                                if (fila2.Contains(1))
                                {
                                    registro[1, numeroColumna] = 3;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2))
                            {
                                int[] fila3 = ObtenerFila(2);
                                if (fila3.Contains(1))
                                {
                                    registro[2, numeroColumna] = 3;
                                    cont++;
                                }
                            }
                            break;
                        case 2:
                            if (!TieneValorEnFila(0 + 3))
                            {
                                int[] fila = ObtenerFila(0 + 3);
                                if (fila.Contains(1))
                                {
                                    registro[0 + 3, numeroColumna] = 3;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1 + 3))
                            {
                                int[] fila = ObtenerFila(1 + 3);
                                if (fila.Contains(1))
                                {
                                    registro[1 + 3, numeroColumna] = 3;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2 + 3))
                            {
                                int[] fila = ObtenerFila(2 + 3);
                                if (fila.Contains(1))
                                {
                                    registro[2 + 3, numeroColumna] = 3;
                                    cont++;
                                }
                            }
                            break;
                        case 3:
                            if (!TieneValorEnFila(0 + 6))
                            {
                                int[] fila = ObtenerFila(0 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[0 + 6, numeroColumna] = 3;
                                    cont++;
                                }


                            }
                            else if (!TieneValorEnFila(1 + 6))
                            {
                                int[] fila = ObtenerFila(1 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[1 + 6, numeroColumna] = 3;
                                    cont++;
                                }
                            }
                            else if (!TieneValorEnFila(2 + 6))
                            {
                                int[] fila = ObtenerFila(2 + 6);
                                if (fila.Contains(1))
                                {
                                    registro[2 + 6, numeroColumna] = 3;
                                    cont++;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            Mensaje("Tabla: \n" + MensajeMatriz(registro));
            
        }
        int[] ObtenerElementosColumna(int indiceColumna)
        {
            int[] elementosColumna = new int[9];

            for (int fila = 0; fila < 9; fila++)
            {
                elementosColumna[fila] = registro[fila, indiceColumna];
            }

            return elementosColumna;
        }
        bool TieneValorEnFila( int fila)
        {
            for (int columna = 0; columna < registro.GetLength(1); columna++)
            {
                if (registro[fila, columna] != 0)
                {
                    return true;
                }
            }
            return false;
        }
        int[] ObtenerFila(int indiceFila)
        {
            int[] fila = new int[registro.GetLength(1)];

            for (int i = 0; i < registro.GetLength(1); i++)
            {
                fila[i] = registro[indiceFila, i];
            }

            return fila;
        }
       
    }
}

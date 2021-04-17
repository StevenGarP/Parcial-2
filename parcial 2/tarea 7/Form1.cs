using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea_7.Clases;

namespace tarea_7
{
    public partial class Form1 : Form
    {
        private string[,] ArregloDosDimenciones;
        private string[] ArregloNotas;
        int[] resultado1, resultado2, resultado3;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSecciones_Click(object sender, EventArgs e)
        {
            string seccion = labelpromedio1.Text;
            string[,] resultado;
            int acumulador = 0;
            int tamanoArreglo = ArregloNotas.Length;

            string[,] ArregloDosDimensiones = new string[tamanoArreglo, 6];

            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                ArregloDosDimensiones[acumulador, 0] = datos[0];
                ArregloDosDimensiones[acumulador, 1] = datos[1];
                ArregloDosDimensiones[acumulador, 2] = datos[2];
                ArregloDosDimensiones[acumulador, 3] = datos[3];
                ArregloDosDimensiones[acumulador, 4] = datos[4];
                ArregloDosDimensiones[acumulador, 5] = datos[5];
                acumulador++;
            }
            PromediosMatrices Clasificar = new PromediosMatrices();
            resultado = Clasificar.Clasificar_Alumnos(ArregloDosDimensiones, seccion);
            for (int i = 0; i < tamanoArreglo; i++)
            {
                listBoxResultado.Items.Add($"{resultado[i, 0]} {resultado[i, 1]}");
            }

        }

        private void promedio_Click(object sender, EventArgs e)
        {
            textBoxParcial.Text = "3";
            textBoxSeccion.Text = "A";
            int contador = 0;
            int parcial = Convert.ToInt32(textBoxParcial.Text) + 1;
            string seccion = textBoxSeccion.Text;
            int promedio, acumulador;
            acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int[] ordenParcial = new int[ArregloNotas.Length - 1];
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {
                    listBoxResultado.Items.Add(datos[1]);
                    acumulador = acumulador + Convert.ToInt32(datos[4]);
                    ordenParcial[contador - 1] = Convert.ToInt32(datos[4]);
                }
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                ArregloDosDimensiones[contador, 5] = datos[5];
                contador++;
            }
            ClsArreglos fncArreglos = new ClsArreglos(ordenParcial);
            ordenParcial = fncArreglos.MetodoBurbujaNotas1();
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length - 1];
            promedio = acumulador / ArregloNotas.Length - 1;
            PromediosMatrices Promedio = new PromediosMatrices();
            int promedioMatriz = Promedio.promedios_por_parcial(ArregloDosDimensiones, parcial);
            int PromedioSeccion = Promedio.promedios_por_seccion(ArregloDosDimensiones, parcial, seccion);
            int PromedioGeneral = Promedio.promedios_general_seccion(ArregloDosDimensiones, parcial, seccion);
            MessageBox.Show($"Promedio es {promedio}\nmin={min}\nmax={max}\nPromedio Parcial={promedioMatriz}\nPromedio Seccion={PromedioSeccion}\nPromedio General de Seccion={PromedioGeneral}");
        }

        private void buttonSumatoria_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            string[,] resultado;
            int acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                ArregloDosDimensiones[acumulador, 0] = datos[0];
                ArregloDosDimensiones[acumulador, 1] = datos[1];
                ArregloDosDimensiones[acumulador, 2] = datos[2];
                ArregloDosDimensiones[acumulador, 3] = datos[3];
                ArregloDosDimensiones[acumulador, 4] = datos[4];
                ArregloDosDimensiones[acumulador, 5] = datos[5];
                acumulador++;
            }
            PromediosMatrices Sumatoria = new PromediosMatrices();
            resultado = Sumatoria.sumatoria_general_por_alumno(ArregloDosDimensiones);
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                listBoxResultado.Items.Add($"{resultado[i, 0]}-{resultado[i, 1]}");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\jeant\Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);

                textBoxContenido.Text = resultado;
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

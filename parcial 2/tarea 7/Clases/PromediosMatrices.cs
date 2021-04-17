using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_7.Clases
{
    class PromediosMatrices : InterfaceArreglos
    {


        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            int contador = 0, tamanomatriz = 0;

            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    tamanomatriz++;
                }
            }
                string[,] M_alumnos = new string[tamanomatriz, 2];
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    M_alumnos[contador, 0] = matriz[i, 1];
                    M_alumnos[contador, 1] = matriz[i, 5];
                    contador++;
                }
            }
            return M_alumnos;
            
        }


        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0, promedio = 0;
            int tamanoMatriz = matriz.GetLength(0);


            for (int i =1; i < tamanoMatriz; i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    promedio += Convert.ToInt32(matriz[i, 2]);
                    promedio += Convert.ToInt32(matriz[i, 3]);
                    promedio += Convert.ToInt32(matriz[i, 4]);
                    acumulador++;
                }
                
            }
            promedio /= (acumulador * 3);
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0, promedio = 0;
            int tamanoMatriz = matriz.GetLength(0);

            for (int i = 0; i < tamanoMatriz; i++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[i, columna_parcial]);
            }
            promedio = acumulador / tamanoMatriz - 1;
            return promedio;

        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0, promedio = 0;
            int tamanoMatriz = matriz.GetLength(0);

            for (int i = 0; i < tamanoMatriz; i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    promedio += int.Parse(matriz[i, columna_parcial]);
                    acumulador++;
                  
                }
            }
            promedio /= acumulador;
            return promedio;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            int suma;
            int tamanoMatriz = matriz.GetLength(0);
            string[,] suma_alumnos = new string[tamanoMatriz,2];

            for ( int i = 0; i<tamanoMatriz; i++)
            {
                suma = int.Parse(matriz[i, 2]) + int.Parse(matriz[i, 3] + int.Parse(matriz[i, 4]));
                suma_alumnos[i - 1, 0] = matriz[i, 1];
                suma_alumnos[i - 1, 1] = Convert.ToString(suma);
            }
            return suma_alumnos;
        }
    }
}

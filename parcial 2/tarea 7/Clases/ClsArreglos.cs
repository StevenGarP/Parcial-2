using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_7.Clases
{
    class ClsArreglos
    {
        private string[] ArregloTemporal;
        private string[] datos1;
        private int i, j;
        private string datoTemporal;

        public ClsArreglos(string[] arreglo)
        {
            datos1 = arreglo;

        }

        public string[] MetodoBurbujaNombres()
        {
            ArregloTemporal = datos1;

            for (i=0; i < datos1.Length - 1; i++)
            {
                for (j=i+1; j < datos1.Length; j++)
                {
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j])>0)
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }


            private int[] datos1NB;

            public ClsArreglos(int[] arreglo)
            {
                datos1NB = arreglo;

            }

        private int[] ArregloTemporalNB;
            private int x, y;
            private int datoTemporalNB;


            public int[] MetodoBurbujaNotas1()
            {
                ArregloTemporalNB = datos1NB;

                for (x = 0; x < datos1NB.Length - 1; x++)
                {
                    for (y = x + 1; y < datos1NB.Length; y++)
                    {
                        if (ArregloTemporalNB[x] < ArregloTemporalNB[y])
                        {
                            datoTemporalNB = ArregloTemporalNB[x];
                            ArregloTemporalNB[x] = ArregloTemporalNB[y];
                            ArregloTemporalNB[y] = datoTemporalNB;
                        }
                    }
                }

                return ArregloTemporalNB;
            }


            private int[] ArregloTemporalNI; 
            private int a,d, datoTemporalNI;

        public int[] MetodoInsercionNotas2()
        {
            ArregloTemporalNI = datos1NB;
            for (a = 0; a < datos1NB.Length; a++)
            {
                datoTemporalNI = ArregloTemporalNI[a];
                d = a - 1;
                while (d >= 0 && ArregloTemporalNI[d] > datoTemporalNI)
                {
                    ArregloTemporalNI[d + 1] = ArregloTemporalNI[d];
                    d--;
                }
                ArregloTemporalNI[d + 1] = datoTemporalNI;
            }
            return ArregloTemporalNI;
        }

        private int[] ArregloTemporalNS;
        private int b, c, min;
        private int datoTemporalNS;

        public int[] MetodoSeleccionNotas3()
        {
            ArregloTemporalNS = datos1NB;
            for (b = 0 ; b < datos1NB.Length; b++ )
            {
                min = b;
                for (c = b + 1 ; c < datos1NB.Length; c++ )
                {
                    if (ArregloTemporalNS[c] < ArregloTemporalNS[min])
                    {
                        min = c;
                    }
                }
                datoTemporalNS = ArregloTemporalNS[b];
                ArregloTemporalNS[b] = ArregloTemporalNS[min];
                ArregloTemporalNS[min] = datoTemporalNS;
            }
            return ArregloTemporalNS;
        }
    }
}

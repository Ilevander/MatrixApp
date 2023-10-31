using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    internal class Program
    {

        static int[,] createMatrix()
        {
            int[,] matrice = new int[3, 3];
            Random rand = new Random(); // Générateur de nombres aléatoires

            // Remplir la matrice avec des valeurs aléatoires (vous pouvez changer ces valeurs si vous le souhaitez)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrice[i, j] = rand.Next(1, 101); // Valeurs aléatoires de 1 à 100
                }
            }

            return matrice;
        }

        static int calculerMin(int[,] matrice)
        {
            int min = matrice[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrice[i, j] < min)
                        min = matrice[i, j];
                }
            }
            return min;
        }

        static int calculerMax(int[,] matrice)
        {
            int max = matrice[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrice[i, j] > max)
                        max = matrice[i, j];
                }
            }
            return max;
        }

        static int calculerSomme(int[,] matrice)
        {
            int somme = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                        somme += matrice[i, j];
                }
            }
            return somme;
        }

        static double CalculerMoy(int[,] matrice)
        {
            int somme = calculerSomme(matrice);
            return (double)somme / 9;
        }

        static void Main(string[] args)
        {
            int[,] matrix = createMatrix();

            Console.WriteLine("Enter a matrix of 3x3 : ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "|");
                }
                Console.Write("_");
                Console.WriteLine();
            }

            int min = calculerMin(matrix);
            int max = calculerMax(matrix);
            int some = calculerSomme(matrix);
            double moy = CalculerMoy(matrix);

            Console.WriteLine("Somme : "+some);
            Console.WriteLine("Moyenne : " + moy);
            Console.WriteLine("Min : " + min);
            Console.WriteLine("Max : " + max);
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

        }
    }
}

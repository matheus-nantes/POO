using System;
//class Matriz
namespace Pratica
{
    class Aula3008{
        public void Empezar()
        {
            int[] dimensoes = IngresarDimensoes();
            int linhas = dimensoes[0];
            int colunas = dimensoes[1];

            int[,] matriz = IngresarDatos(linhas, colunas);

            Console.WriteLine("\nMatriz original:");
            ImprimirMatriz(matriz, linhas, colunas);

            Console.Write("Deseja ordenar a matriz em ordem ascendente (A) ou descendente (D)? ");
            string ordem = Console.ReadLine().Trim().ToUpper();
            bool ascendente = ordem == "A";

            OrdenarMatriz(matriz, linhas, colunas, ascendente);

            Console.WriteLine("\nMatriz ordenada:");
            ImprimirMatriz(matriz, linhas, colunas);
        }

        public int[] IngresarDimensoes()
        {
            Console.Write("Digite o número de linhas: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
            int colunas = int.Parse(Console.ReadLine());
            return new int[] { linhas, colunas };
        }

        public int[,] IngresarDatos(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine("Digite os elementos da matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Elemento [{i },{j }]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matriz;
        }

        public void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void OrdenarMatriz(int[,] matriz, int linhas, int colunas, bool ascendente)
        {
            int[] elementos = new int[linhas * colunas];
            int index = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    elementos[index++] = matriz[i, j];
                }
            }
            if (ascendente)
            {
                Array.Sort(elementos);
            }
            else
            {
                Array.Sort(elementos);
                Array.Reverse(elementos);
            }

            index = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = elementos[index++];
                }
            }
        }
    }
}
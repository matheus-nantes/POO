using System;
//class Herencia
namespace Pratica
{
    class Aula0409{
        int[,] numeros;
        int lineas, colunas;
        public Aula0409(){
            Console.WriteLine("Ingrese numero de lineas: ");
            lineas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de colunas: ");
            colunas = int.Parse(Console.ReadLine());
            numeros = new int[lineas,colunas];
            Random rng = new Random();
            for(int i = 0; i < lineas; i ++){
                for(int j = 0; j < colunas; j++){
                    numeros[i,j] = rng.Next(100);
                }
            }
            for(int i = 0; i < lineas; i ++){
                Console.Write("[ ");
                for(int j = 0; j < colunas; j++){
                    Console.Write(numeros[i,j]+",\t");
                }
                Console.WriteLine("]");
            }
        }       
    }
}
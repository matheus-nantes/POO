using System;
namespace Pratica
{
    class Aula2308
    {
        private int quantidade;
        private float[] alturas;
        public void Cargar()
        {
            Console.Write("Insira a cuantidad de elementos de tu lista: ");
            quantidade = int.Parse(Console.ReadLine());
            alturas = new float[quantidade];

            for(int i = 0; i < quantidade; i++){
                Console.Write("Insira o valor "+(i+1)+"° : ");
                alturas[i] = float.Parse(Console.ReadLine());
            }
        }

        public float CalcularPromedio(){
            float total = 0;
            for(int i = 0; i < quantidade; i++){
                total+= alturas[i];
            }
            return total/quantidade;
        }

        public void MayoresMenores(){
            List<float> mayores = new List<float>();
            List<float> menores = new List<float>();

            float promedio = CalcularPromedio();

            for(int i = 0; i < quantidade; i ++){
                if(alturas[i] > promedio)
                    mayores.Add(alturas[i]);
                else if(alturas[i] < promedio)
                    menores.Add(alturas[i]);
            }
            Console.Write("\n"+mayores.Count+" Mayores: ");
            for(int i = 0; i < mayores.Count; i++){
                Console.Write(mayores[i]+" ");
            }

            Console.Write("\n"+menores.Count+" Menores: ");

            for(int i = 0; i < menores.Count; i++){
                Console.Write(menores[i]+" ");
            }
            Console.WriteLine("");
            
            Console.WriteLine((quantidade-mayores.Count-menores.Count)+" igual(es) ao promedio");

        }
    }
}
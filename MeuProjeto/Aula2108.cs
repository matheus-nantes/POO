using System;
namespace practical
{
    class Aula2108
    {


        public void CargarDatos(){
            int valor;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar): ");
                valor = int.Parse(Console.ReadLine());
                if(valor != -1)
                {
                    Calcular(valor);
                }

            }while(valor != -1);
        }

        public void Calcular(int v){
            for(int i = v; i <= v*10; i+=v)
            {
                Console.Write(i + "-");
            }
            Console.WriteLine();
        }

    }
}
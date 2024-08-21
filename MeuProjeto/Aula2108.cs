using System;
namespace practical
{
    class Aula2108
    {   
        public int valor1,valor2,valor3,mayor,menor;


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

        //segunda parte da aula

        public void CargarValores(){
            Console.WriteLine("Ingresse valor1: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresse valor2: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresse valor3: ");
            valor3 = int.Parse(Console.ReadLine());

            mayor = CalcularMayor(valor1,valor2,valor3);
            Console.WriteLine("El numero mayor de los 3 es: "+mayor);

            menor = CalcularMenor(valor1,valor2,valor3);
            Console.WriteLine("El numero menor de los 3 es: "+menor);

        }

        public int CalcularMayor(int valor1, int valor2, int valor3){
            if(valor1>valor2 && valor1>valor3){
                return valor1;
            }
            else if(valor2 > valor3){
                return valor2;
            }
            else{
                return valor3;
            }
            
        } 

        public int CalcularMenor(int valor1, int valor2, int valor3){
            if(valor1<valor2 && valor1<valor3){
                return valor1;
            }
            else if(valor2 < valor3){
                return valor2;
            }
            else{
                return valor3;
            }
            
        } 

    }
}
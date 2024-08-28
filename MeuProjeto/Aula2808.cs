using System;
//class Vector
    namespace Pratica{
    class Aula2808{
        private int[]  numeros;
        public void Cargar(){
            Console.WriteLine("Cuantos numeros ingresará: ");
            int cant = int.Parse(Console.ReadLine());
            numeros = new int[cant];
        }

        public void IngressarDatos(){
            for(int i = 0; i<numeros.Length; i++){
                Console.Write("Ingrese Número "+(i+1) +"; ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Imprimir(){
            Console.Write("\n");
            for(int i = 0; i<numeros.Length; i++){
                Console.Write(numeros[i]+" ");
            }
            Console.Write("\n\n");
        }

        
        
        private void OrdenaCresciente(){
            int menor;
            int indexMenor;
            for(int j = 0; j < numeros.Length-1; j++){
                indexMenor = j;
                menor=numeros[j];
                for(int i = j+1; i < numeros.Length; i++){
                    if(numeros[i] < menor){
                        menor = numeros[i];
                        indexMenor = i;
                    }
                }
                numeros[indexMenor] = numeros[j];
                numeros[j] = menor;
            }
        }


        private void OrdenarDecresciente(){
            int menor;
            int indexMenor;
            for(int j = 0; j < numeros.Length-1; j++){
                indexMenor = j;
                menor=numeros[j];
                for(int i = j+1; i < numeros.Length; i++){
                    if(numeros[i] > menor){
                        menor = numeros[i];
                        indexMenor = i;
                    }
                }
                numeros[indexMenor] = numeros[j];
                numeros[j] = menor;
            }
        }

        public void Ordenar(){
            int choice = 1;
            while(choice != 0){
                Console.WriteLine("selecione un método de Ordenacción:\n1 - Crescente\n2- Descresciente\n0-salir");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:
                        OrdenaCresciente();
                        Imprimir();
                        break;
                    case 2:
                        OrdenarDecresciente();
                        Imprimir();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("ingresse una opcción valida");
                        break;
                }
            }
        }

    }

}
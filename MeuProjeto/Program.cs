using System;
namespace practical
{
    class Triangulo
    {
        public int l1, l2, l3;
        public string tipo;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese l1:");
            l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese l2:");
            l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese l3:");
            l3 = int.Parse(Console.ReadLine());

            ValidaTriangulo();
            
        }

        public void ValidaTriangulo()
        {
            if(l1 != l2 && l2 != l3)
            {
                tipo = "escaleno" ;
            }
            else if(l1 == l2 && l2 == l3)
            {
                tipo = "equilatero";
            }
            else{
                tipo = "isoceles";
            }
        }


        public void Imprimir()
        {
            Console.Write("El trinagulo con lados L1= "+l1+" y L2= "+l2+" y L3= "+l3+" es: ");
            Console.WriteLine(this.tipo);

            // Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Triangulo objeto = new Triangulo();
            // objeto.Inicializar();
            // objeto.Imprimir();
            Aula2108 temp = new Aula2108();
            temp.CargarDatos();
        }
    }
}
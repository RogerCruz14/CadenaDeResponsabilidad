using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadenaDeResponsabilidad.Clases;

namespace CadenaDeResponsabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos los cuatro objetos que van a ser parte de la cadena
            var comprador = new Comprador();
            var gerente = new Gerente();
            var director = new Director();
            var directorGeneral = new DirectorGneral();

            //componemos la cadena
            //le decimos que el sucesor del geren es el director 
            //y que el sucesor de comprador es gerente
            //y que el sucesor de director es director genreal  
            director.AgregarSiguiente(directorGeneral);
            gerente.AgregarSiguiente(director);
            comprador.AgregarSiguiente(gerente);
          
            //creamos una compra y lo empezamos con un clico para simular las operaciones
            //en donde solicitamos el importe de la compra 
            var c = new Compra();
            double importe = 1;
            while (importe != 0)

                //crear un nuevo objeto vemos que este objeto sera serivado directamente al primera de la cadena
                //que es el comprador
                //cuando se reciba la solicitud y no la puede procesar se lo enviara al siguiente
            {
                Console.WriteLine("Ingrese el importe de la compra (0 para terminar)");
                importe = double.Parse(Console.ReadLine());
                c.Importe = importe;
                comprador.Procesar(c);
            }


        }
    }
}

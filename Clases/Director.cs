using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Clases
{
    //tendremos una herencia de la clase aprovador y va a sobrecribir la operacion procesar
    public class Director : Aprobador
    {
        public override void Procesar(Compra c)
        {
            //si es menor a 5000 la va a aprovar el director y si no conoce a su sucesor 
            //para derivarla solicitud de la cadena 
            if (c.Importe < 5000)
                Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
            else
                siguiente.Procesar(c);
        }
    }
}

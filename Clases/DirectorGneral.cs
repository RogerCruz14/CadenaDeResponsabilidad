using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Clases
{
    public class DirectorGneral : Aprobador
    {
        //tras ser el ultimo estabon de la cadena no va a tener asociación 
        //al recibir la compra sera por que es necesario que la apruebe.
        public override void Procesar(Compra c)
        {
            Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
        }
    }
}

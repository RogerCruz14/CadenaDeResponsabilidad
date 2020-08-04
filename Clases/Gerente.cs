using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Clases
{
    //Tambien hereda de aprovador y implementa la presion abstracta procesada
    public class Gerente : Aprobador
    {
        public override void Procesar(Compra c)
        {
            //si es menor o igual a 1000 la va a aprovar el genrente y si no conoce a su sucesor 
            //para derivarla solicitud de la cadena 
            if (c.Importe <= 1000)
            {
                Console.WriteLine(string.Format("Compra aprobada por el {0}", this.GetType().Name));
            }
            else
            {
                siguiente.Procesar(c);
            }
        }
    }
}

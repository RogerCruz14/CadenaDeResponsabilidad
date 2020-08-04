using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidad.Clases
{
    //Es una clase abstracta llamada aprovador
    public abstract class Aprobador
    {
        //Tiene un atributo que va a representar el "siguiente" si el sucesor
        protected Aprobador siguiente;

        //Va a recibir una instacia de aprovador 
        //Lo utilizamos para definir la agregación
        public void AgregarSiguiente(Aprobador aprobador)
        {
            siguiente = aprobador;
        }

        //Tendremos una operación abstracta que e el "procesar " esto va arecibir por parametro una compra y sera implementado en
        //cada uno de los aprovadores completos
        public abstract void Procesar(Compra c);
    }
}

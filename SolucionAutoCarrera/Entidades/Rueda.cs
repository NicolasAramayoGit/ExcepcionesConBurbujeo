using MisExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rueda
    {
        private string _marca;

        public void Pinchar()
        {
            
            int numero = Carrera._rnd.Next(1,10);

            if (numero == 8)
            {
                //Lanzo la excepcion.
                //Aqui comienza el burbujeo.
                //Donde comienza solo utilizo throw.
                throw new RuedaException("Se pincho la rueda de marca: " + this._marca);
            }
           
        }
    }
}

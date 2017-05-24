using MisExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Motor
    {
        private string _marca;

        public void Fallar()
        {
            int numero = Carrera._rnd.Next(1, 10);
            if (numero == 8)
            {
                //Lanzo la excepcion.
                //Aqui comienza el burbujeo.
                //Donde comienza solo utilizo throw.
                throw new RuedaException("Falla en el motor de marca " + this._marca);
            }
            
        }

        public Motor(string marca)
        {
            this._marca = marca;
        }

    }
}

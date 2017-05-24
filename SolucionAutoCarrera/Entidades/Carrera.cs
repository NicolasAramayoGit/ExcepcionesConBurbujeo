using MisExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {

        public List<Autos> _listaAutos; //lo hago publico para que se vea en el main.
        public static Random _rnd;

        public Carrera()
        {
            this._listaAutos = new List<Autos>();
        }

        static Carrera()
        {
            _rnd = new Random();
        }


        public void correr()
        {
            int i;

            try
            {
                for (i = 0; i < 10; i++)//cantidad de vueltas de la carrera.
                {
                    foreach (Autos a in this._listaAutos)
                    {
                        a.Andar();
                    }
                }
            }
            catch (MiException ex)
            {
                throw new MiException(ex.Message, ex);
            }
            finally 
            {
                Console.WriteLine("Esto paso por el metodo correr() de Carrera.cs");
            }
            

            

        }


    }
}

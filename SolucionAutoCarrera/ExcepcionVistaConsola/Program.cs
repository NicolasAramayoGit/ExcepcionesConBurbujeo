using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionVistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Carrera micarrera = new Entidades.Carrera();

            Entidades.Motor motor1 = new Entidades.Motor("pato");

            Entidades.Rueda rdd = new Entidades.Rueda();
            Entidades.Rueda rdi = new Entidades.Rueda();
            Entidades.Rueda rtd = new Entidades.Rueda();
            Entidades.Rueda rti = new Entidades.Rueda();


            Entidades.Autos a1 = new Entidades.Autos("Ford", motor1, rdd, rdi, rtd, rti);
            Entidades.Autos a2 = new Entidades.Autos("Wolsvagen", motor1, rdd, rdi, rtd, rti);
            Entidades.Autos a3 = new Entidades.Autos("Hillux", motor1, rdd, rdi, rtd, rti);
            Entidades.Autos a4 = new Entidades.Autos("Fiat", motor1, rdd, rdi, rtd, rti);
            Entidades.Autos a5 = new Entidades.Autos("Ferrari", motor1, rdd, rdi, rtd, rti);



            micarrera._listaAutos.Add(a1);
            micarrera._listaAutos.Add(a2);
            micarrera._listaAutos.Add(a3);
            micarrera._listaAutos.Add(a4);
            micarrera._listaAutos.Add(a5);

            try
            {
                micarrera.correr();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message, ex);
            }
            finally
            {
                Console.WriteLine("Esto paso por el finally del MAIN");
            }


        }
    }
}

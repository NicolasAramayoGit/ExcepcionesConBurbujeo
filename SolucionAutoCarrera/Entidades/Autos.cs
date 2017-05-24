using MisExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autos
    {
        private string _marca;
        private Rueda _DD;
        private Rueda _DI;
        private Rueda _TD;
        private Rueda _TI;
        private Motor _motor;

        //método que falle

        public void Andar()
        {
            try
            {
                //random
                //llamar a las ruedas y al metodo pinchar pinchar.
                this._motor.Fallar();
                this._DD.Pinchar();
                this._DI.Pinchar();
                this._TI.Pinchar();
                this._TD.Pinchar();
            }
            catch (RuedaException ex)
            {
                throw new MiException(ex.Message + "añado mensaje", ex); ;
            }
            catch (MotorException ex)
            {
                throw new MiException(ex.Message + "añado mensaje", ex);
            }
            catch (MiException ex)
            {
                throw new MiException(ex.Message + "añado mensaje", ex); ;
            }
            finally
            {
                Console.WriteLine("Esto paso por el finally de metodo Andar() de Auto");
            }
        }

        public Autos(string marca, Motor motor, Rueda DD,Rueda DI,Rueda TD,Rueda TI)
        {
            this._marca = marca;
            this._motor = motor;
            this._DD = DD;
            this._DI = DI;
            this._TD = TD;
            this._TI = TI;
        }
    }
}

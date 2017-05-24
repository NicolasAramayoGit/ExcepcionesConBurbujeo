using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    public class MiException:Exception
    {
        public MiException(string message):base(message)
        {
            
        }

        public MiException(string message, Exception ex):base(message,ex)
        {

        }
    }
}

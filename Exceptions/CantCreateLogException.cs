using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantCreateLogException : ApplicationException
    {
        public CantCreateLogException() : base("Nao foi possivel criar o ficheiro de log")
        {
        }

        public CantCreateLogException(string mensagem) : base(mensagem) { }

        public CantCreateLogException(string mensagem, Exception e)
        {
            throw new CantCreateLogException(e.Message + " - " + mensagem);
        }
    }
}

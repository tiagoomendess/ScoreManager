using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantRestoreException : ApplicationException
    {
        public CantRestoreException() : base("Nao foi possivel restaurar objeto")
        {
        }

        public CantRestoreException(string mensagem) : base(mensagem) { }

        public CantRestoreException(string mensagem, Exception e)
        {
            throw new CantRestoreException(e.Message + " - " + mensagem);
        }
    }
}

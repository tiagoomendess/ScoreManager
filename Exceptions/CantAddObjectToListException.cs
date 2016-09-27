using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantAddObjectToListException : ApplicationException
    {
        public CantAddObjectToListException() : base("Objeto nao foi adicionado a Lista")
        {
        }

        public CantAddObjectToListException(string mensagem) : base(mensagem) { }

        public CantAddObjectToListException(string mensagem, Exception e)
        {
            throw new CantAddObjectToListException(e.Message + " - " + mensagem);
        }
    }
}

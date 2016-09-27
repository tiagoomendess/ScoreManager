using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantRemoveFromListException : ApplicationException
    {
        public CantRemoveFromListException() : base("Nao foi possivel remover da lista")
        {
        }

        public CantRemoveFromListException(string mensagem) : base(mensagem) { }

        public CantRemoveFromListException(string mensagem, Exception e)
        {
            throw new CantAddObjectToListException(e.Message + " - " + mensagem);
        }
    }
}

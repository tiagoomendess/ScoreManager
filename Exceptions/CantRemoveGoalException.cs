using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantRemoveGoalException : ApplicationException
    {
        public CantRemoveGoalException() : base("Não e possivel remover um golo a equipa pretendida")
        {
        }

        public CantRemoveGoalException(string mensagem) : base(mensagem) { }

        public CantRemoveGoalException(string mensagem, Exception e)
        {
            throw new CantRemoveGoalException(e.Message + " - " + mensagem);
        }
    }
}

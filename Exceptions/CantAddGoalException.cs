using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantAddGoalException : ApplicationException
    {
        public CantAddGoalException() : base("Não foi possivel adicionar um golo a equipa pretendida")
        {
        }

        public CantAddGoalException(string mensagem) : base(mensagem) { }

        public CantAddGoalException(string mensagem, Exception e)
        {
            throw new CantAddGoalException(e.Message + " - " + mensagem);
        }
    }
}

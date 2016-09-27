using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CantWriteToTxt : ApplicationException
    {
        public CantWriteToTxt() : base("Não foi possivel escrever o texto no ficheiro pretendido")
        {
        }

        public CantWriteToTxt(string mensagem) : base(mensagem) { }

        public CantWriteToTxt(string mensagem, Exception e)
        {
            throw new CantWriteToTxt(e.Message + " - " + mensagem);
        }
    }
}

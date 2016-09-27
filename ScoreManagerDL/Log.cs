using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace ScoreManagerDL
{
    /// <summary>
    /// A Classe LOG regista todas as operações importantes feitas no programa
    /// </summary>
    public static class Log
    {
        #region ESTADO
        #endregion

        #region METODOS

        #region CONTRUTORES
        #endregion

        #region PROPRIEDADES
        #endregion

        #region OUTROS

        /// <summary>
        /// Regista um evento na log do programa
        /// </summary>
        /// <param name="msg">A Mensagem a ser escrita</param>
        /// <returns>1 se o processo decorrer sem anormalidades</returns>
        public static int Regista(string msg)
        {
            DateTime dataLocal = new DateTime();
            dataLocal = DateTime.Now;
            string horaFormatada = dataLocal.ToString(Definicoes.FormatoDataLog);
            string caminho = Definicoes.PastaLogs + "/" + dataLocal.ToString("dd-MM-yyyy") + ".txt";
            string texto = "";
            texto = "[" + horaFormatada + "]: " + msg;
            return FicheirosIO.AddLinhaNoTxt(caminho, texto);
        }

        #endregion

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerDL
{
    [Serializable]
    public class Definicoes
    {
        #region ESTADO
        static string pastaTextos = "Textos";
        static string formatoDataLog = "dd/MM/yyyy HH:mm:ss";
        static string pastaLogs = "Logs";
        static string nomeTxtResultado = "Score";
        static string nomeTxtTeamA = "TeamA";
        static string nomeTxtTeamB = "TeamB";
        static string formatoScore = "{TA} {SA} - {SB} {TB}";
        static string nomeTxtCronometro = "Cronometro";
        static string formatoCronometro = "{m}{m}:{s}{s}";
        #endregion

        #region METODOS

        #region CONTRUTORES
        #endregion

        #region PROPRIEDADES
        public static string PastaTextos
        {
            get{ return pastaTextos; }
            set { pastaTextos = value; }
        }

        public static string FormatoDataLog
        {
            get { return formatoDataLog; }
            set { formatoDataLog = value; }
        }

        public static string PastaLogs
        {
            get { return pastaLogs; }
            set { pastaLogs = value; }
        }

        public static string NomeTxtResultado
        {
            get { return nomeTxtResultado; }
            set { nomeTxtResultado = value; }
        }
        public static string NomeTxtTeamA
        {
            get { return nomeTxtTeamA; }
            set { nomeTxtTeamA = value; }
        }

        public static string NomeTxtTeamB
        {
            get { return nomeTxtTeamB; }
            set { nomeTxtTeamB = value; }
        }

        public static string FormatoScore
        {
            get { return formatoScore; }
            set { formatoScore = value; }
        }

        public static string NomeTxtCronometro
        {
            get { return nomeTxtCronometro; }
            set { nomeTxtCronometro = value; }
        }

        public static string FormatoCronometro
        {
            get { return formatoCronometro; }
            set { formatoCronometro = value; }
        }
        #endregion

        #region OUTROS
        #endregion

        #endregion
    }
}

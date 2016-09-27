using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using ScoreManagerDL;
using ScoreManagerBO;

namespace ScoreManagerBL
{
    [Serializable]
    public static class Contador
    {
        #region ESTADO
        static int golosVisitado = 0;
        static int golosVisitante = 0;
        static string nomeVisitado = "TeamA";
        static string nomeVisitante = "TeamB";
        #endregion

        #region METODOS

        #region CONTRUTORES
        #endregion

        #region PROPRIEDADES
        public static int GolosVisitado
        {
            get { return golosVisitado; }
        }

        public static int GolosVisitante
        {
            get { return golosVisitante; }
        }

        public static string NomeVisitado
        {
            get { return nomeVisitado; }
            set { nomeVisitado = value; }
        }

        public static string NomeVisitante
        {
            get { return nomeVisitante; }
            set { nomeVisitante = value; }
        }
        #endregion

        #region OUTROS        
        /// <summary>
        /// Adiciona um golo.
        /// </summary>
        /// <param name="equipa">A equipa pretendida.</param>
        /// <returns></returns>
        /// <exception cref="Exeptions.CantAddGoalToTeamException">Não foi possivel adicionar o golo porque a equipa escolhida não é válida</exception>
        public static bool AddGolo(int equipa)
        {

            if (equipa == (int)ScoreManagerBO.Enumerados.Equipas.Visitado)
            {
                golosVisitado++;
                
            }
            else if (equipa == (int)ScoreManagerBO.Enumerados.Equipas.Visitante)
            {
                golosVisitante++;
            }
            else
            {
                throw new CantAddGoalException("Não foi possivel adicionar o golo porque a equipa escolhida não é válida");
            }

            return true;
        }

        /// <summary>
        /// Removes the golo.
        /// </summary>
        /// <param name="equipa">The equipa.</param>
        /// <returns></returns>
        /// <exception cref="Exeptions.CantRemoveGoalException">
        /// A equipa visitada nao pode ter golos negativos
        /// or
        /// A equipa visitante nao pode ter golos negativos
        /// or
        /// Não foi possivel remover o golo porque a equipa escolhida não é válida
        /// </exception>
        public static bool RemoveGolo(int equipa)
        {

            if (equipa == (int)ScoreManagerBO.Enumerados.Equipas.Visitado)
            {
                //Verifica se a equipa nao vai ficar com golos negativos
                if (golosVisitado - 1 < 0)
                    throw new CantRemoveGoalException("A equipa visitada nao pode ter golos negativos");
                else
                    golosVisitado--;
            }
            else if (equipa == (int)ScoreManagerBO.Enumerados.Equipas.Visitante)
            {
                //Verifica se a equipa nao vai ficar com golos negativos
                if (golosVisitante - 1 < 0)
                    throw new CantRemoveGoalException("A equipa visitante nao pode ter golos negativos");
                else
                    golosVisitante--;
            }
            else
            {
                throw new CantRemoveGoalException("Não foi possivel remover o golo porque a equipa escolhida não é válida");
            }

            return true;
        }

        public static int AtualizaResultado()
        {
            string formato = Definicoes.FormatoScore;
            //Formatar o texto como é pedido
            string texto = formato.Replace("{TA}", nomeVisitado);
            texto = texto.Replace("{TB}", nomeVisitante);
            texto = texto.Replace("{SA}", golosVisitado.ToString());
            texto = texto.Replace("{SB}", golosVisitante.ToString());
            return FicheirosIO.EscreveNoTxt(Definicoes.PastaTextos + "/" + Definicoes.NomeTxtResultado, texto);
        }

        public static int AtualizaEquipas()
        {
            FicheirosIO.EscreveNoTxt(Definicoes.PastaTextos + "/" + Definicoes.NomeTxtTeamA, nomeVisitado);
            FicheirosIO.EscreveNoTxt(Definicoes.PastaTextos + "/" + Definicoes.NomeTxtTeamB, nomeVisitante);
            return (int)ScoreManagerBO.Enumerados.Codigos.Sucesso;
        }
        #endregion

        #endregion
    }
}

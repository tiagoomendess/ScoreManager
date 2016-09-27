using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerBO
{
    /// <summary>
    /// Um jogador tem um numero, uma posicao e uma equipa. Herda de Pessoa
    /// </summary>
    public class Jogador : Pessoa
    {
        #region ESTADO
        int numero;
        int posicao;
        int equipa;
        #endregion

        #region METODOS

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region CONTRUTORES
        /// <summary>
        /// Instancia um jogador por defeito
        /// </summary>
        public Jogador()
        {
            numero = -1;
            posicao = (int)Enumerados.Posicoes.Default;
            equipa = (int)Enumerados.Equipas.Default;
        }

        /// <summary>
        /// Instancia um jogador com os parametros passados
        /// </summary>
        /// <param name="numero">Numero de camisola do jogador</param>
        /// <param name="nome">Nome do jogador</param>
        /// <param name="posicao">Posição em campo</param>
        /// <param name="equipa">Equipa onde joga, ver enumerado de equipas</param>
        public Jogador(int numero, string nome, int posicao, int equipa) : base(nome)
        {
            this.numero = numero;
            this.posicao = posicao;
            this.equipa = equipa;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Numero do jogador
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Posição em campo
        /// </summary>
        public int Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        /// <summary>
        /// Equipa do jogador
        /// </summary>
        public int Equipa
        {
            get { return equipa; }
            set { equipa = value; }
        }
        #endregion

        #region OUTROS

        /// <summary>
        /// Compara se esta instancia é igual ao objeto enviado por parametro
        /// </summary>
        /// <param name="obj">Objeto a comparar</param>
        /// <returns>Verdadeiro se for, falso se nao for igual</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Jogador) || obj == null)
                return false;

            Jogador aux = (Jogador)obj;
            return (this == aux);
        }

        public override string ToString()
        {
            return "Jogador [\nId: " + Id + "\nNome: " + Nome + "\nNumero: " + numero + "\nPosicao: " + posicao + "\nEquipa: " + equipa + "\n]";
        }

        #region OPERADORES
        public static bool operator ==(Jogador a, Jogador b)
        {
            /*
            Sobre estes pontos de interrogação, são umas verificações para o caso de ser
            null, desta forma não dá erro porque verifica primeiro se é null, mais info
            ver este video: https://www.youtube.com/watch?v=PvWTB8N3AB4
            */

            //Um jogador é igual ao outro se a equipa e o numero sao iguais
            return ((a?.Equipa == b?.Equipa) && (a?.Numero == b?.Numero));
        }

        public static bool operator !=(Jogador a, Jogador b)
        {
            return ((a?.Equipa != b?.Equipa) || (a?.Numero != b?.Numero));
        }
        #endregion

        #endregion

        #endregion
    }
}

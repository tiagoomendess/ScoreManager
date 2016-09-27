using Exceptions;
using ScoreManagerBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerDL
{
    /// <summary>
    /// Classe que armazena todos os jogadores
    /// </summary>
    
    [Serializable]
    public static class Jogadores
    {
        #region ATRIBUTOS
        const int MAXJOGADORES = 50;
        const int TAMANHOINICIAL = 22;
        static List<Jogador> todos = new List<Jogador>(TAMANHOINICIAL);
        #endregion

        #region METODOS

        #region CONSTRUTORES
        //Não há
        #endregion

        #region PROPRIEDADES
            //Nao ha
        #endregion

        #region OUTROS
        
        /// <summary>
        /// Adiciona jogador à lista
        /// </summary>
        /// <param name="jogador">O jogador a ser adicionado</param>
        /// <returns>Ver lista de codigos</returns>
        public static int Add(Jogador jogador)
        {

            //Nao deixar introduzir mais de 50 Jogadores na lista
            if (todos.Count >= MAXJOGADORES)
                return (int)Enumerados.Codigos.ListaCheia;

            //Tenta inserir um novo jogador na lista
            try
            {
                todos.Add(jogador);
            }
            catch (Exception e)
            {
                throw new CantAddObjectToListException("", e);
            }

            return (int)Enumerados.Codigos.Sucesso;
        }

        /// <summary>
        /// Procura um jogador na lista pelo id
        /// </summary>
        /// <param name="id">Id a procurar</param>
        /// <returns>Um objeto do jogador encontrado ou um jogador por defeito se nao encontrar nenhum</returns>
        public static Jogador GetById(int id)
        {
            Jogador jogadorTmp = todos.Find(x => x.Id == id);
            return jogadorTmp;
        }

        /// <summary>
        /// Procura um jogador na lista pelo numero de camisola
        /// </summary>
        /// <param name="id">Numero a procurar</param>
        /// <returns>Um objeto do jogador encontrado ou um jogador por defeito se nao encontrar nenhum</returns>
        public static Jogador GetByNumber(int numero)
        {
            Jogador jogadorTmp = todos.Find(x => x.Numero == numero);
            return jogadorTmp;
        }

        /// <summary>
        /// Procura na lista de jogadores todos com a equipa coorespondente
        /// </summary>
        /// <param name="equipa">Equipa</param>
        /// <returns></returns>
        public static List<Jogador> GetByTeam(int equipa)
        {
            List<Jogador> novaLista = todos.FindAll(x => x.Equipa == equipa); //Assegurar que o que retorna e uma lista diferente. Como vi nos ArrayList, achei que aqui tb era necessário algo
            return novaLista;
        }

        public static List<Jogador> GetAll()
        {
            List<Jogador> novaLista = todos.ToList(); //Assegurar que o que retorna e uma lista diferente. Como vi nos ArrayList, achei que aqui tb era necessário algo
            return novaLista;
        }

        //ver isto
        public static int Remove(Jogador jogador)
        {
            //Variaveis locais
            Jogador temporario;

            //Se nao existir sai logo do metodo
            if (!todos.Contains(jogador))
                return (int)Enumerados.Codigos.NaoEncontrado;

            //Procura na lista pelo objeto
            temporario = todos.Find(x => x.Numero == jogador.Numero && x.Equipa == jogador.Equipa);

            //Tenta remover desta lista
            try
            {
                Reciclagem.Add(temporario);
                todos.Remove(temporario);
            }
            catch (Exception e)
            {

                throw new CantRemoveFromListException(e.Message);
            }

            Log.Regista("O jogador " + jogador.Nome + ", com o ID " + jogador.Id + " foi enviado para a reciclagem");
            return (int)Enumerados.Codigos.Sucesso;
        }
        #endregion

        #endregion


    }
}

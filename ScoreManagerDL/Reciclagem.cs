using ScoreManagerBO;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerDL
{
    /// <summary>
    /// Esta classe armazena até 100 objetos que cumpram o IPessoa
    /// </summary>
    public static class Reciclagem
    {

        #region ESTADO
        const int MAX = 1000;
        private static ArrayList reciclagem = new ArrayList(); //Vai conter vários objectos que foram removidos das respectivas listas
        #endregion

        #region METODOS

        #region CONTRUTORES
        #endregion

        #region PROPRIEDADES
        #endregion

        #region OUTROS

        /// <summary>
        /// Adiciona um novo objeto a reciclagem
        /// </summary>
        /// <param name="obj">O Objheto a adicionar</param>
        /// <returns>ver enumerados dos codigos possiveis</returns>
        public static int Add(IPessoa obj)
        {
            if (reciclagem.Count >= MAX)
                return (int)ScoreManagerBO.Enumerados.Codigos.Sucesso;

            try
            {
                reciclagem.Add(obj);
            }
            catch (Exception e)
            {
                throw new Exceptions.CantAddObjectToListException("Nao foi possivel adicionar item a lista de Reciclagem", e);
            }

            return (int)Enumerados.Codigos.Sucesso;
        }

        /// <summary>
        /// Procura na reciclagem por um objeto que implementa o IPessoa
        /// </summary>
        /// <param name="obj">O Objeto a ser procurado</param>
        /// <returns>O indice onde esse objecto existe, ou retorna -1 se nao encontrar</returns>
        public static int WhereIs(IPessoa obj)
        {
            //Variaveis locais
            int totalEntradas = reciclagem.Count;
            int indice = -1;

            for (int i = 0; i < totalEntradas; i++)
            {
                if (((IPessoa)reciclagem[i]) == obj)
                {
                    indice = i;
                }
            }

            return indice;
        }

        /// <summary>
        /// Procura um objecto na reciclagem por ID que implementa IPessoa
        /// </summary>
        /// <param name="id">O Id único do objeto a procurar</param>
        /// <returns>O indice onde esse objecto existe, ou retorna -1 se nao encontrar</returns>
        public static int WhereIs(int id)
        {
            //Variaveis locais
            int totalEntradas = reciclagem.Count;
            int indice = -1;

            for (int i = 0; i < totalEntradas; i++)
            {
                if (((IPessoa)reciclagem[i]).Id == id)
                {
                    indice = i;
                }
            }

            return indice;
        }

        public static int Restaura(IPessoa obj)
        {
            //Variaveis locais
            int posicao = WhereIs(obj);

            if (posicao == -1)
                return (int)Enumerados.Codigos.NaoEncontrado;

            //Tentar restaurar o objeto encontrado
            try
            {
                if (obj.GetType() == typeof(Jogador))
                    Jogadores.Add((Jogador)reciclagem[posicao]);

                //if (obj.GetType() == typeof(Arbitro))
                //    Arbitros.Add((Arbitro)reciclagem[posicao]);

                //if (obj.GetType() == typeof(Tecnico))
                //    Tecnicos.Add((Tecnico)reciclagem[posicao]);
            }
            catch (Exceptions.CantAddObjectToListException e)
            {
                Log.Regista("Excepção: " + e.Message);
                throw new Exceptions.CantRestoreException(e.Message);
            }
            catch (Exception e)
            {
                Log.Regista("Excepção: " + e.Message);
                throw new Exceptions.CantRestoreException("Nao foi possivel restaurar objeto da reciclagem", e);
            }

            Log.Regista("Removido da reciclagem com o id " + obj.Id.ToString() + " e nome " + obj.Nome);
            reciclagem.RemoveAt(posicao);
            
            return (int)ScoreManagerBO.Enumerados.Codigos.Sucesso;
        }

        /// <summary>
        /// Esvazia a reciclagem
        /// </summary>
        /// <returns></returns>
        public static int Esvazia()
        {
            reciclagem.Clear();
            Log.Regista("Reciclagem esvaziada");
            return (int)Enumerados.Codigos.Sucesso;
        }
        #endregion

        #endregion
    }
}

//#region ESTADO
//#endregion

//#region METODOS

//#region CONTRUTORES
//#endregion

//#region PROPRIEDADES
//#endregion

//#region OUTROS
//#endregion

//#endregion

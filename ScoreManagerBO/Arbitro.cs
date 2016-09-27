using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerBO
{
    public class Arbitro : Pessoa
    {
        #region ESTADO
        int tipoArbitro;
        int idade;
        int nacionalidade;
        #endregion

        #region METODOS

        #region CONTRUTORES
        public Arbitro()
        {
            tipoArbitro = (int)Enumerados.Arbitro.Default;
            idade = 0;
            nacionalidade = (int)Enumerados.Nacionalidade.Portugal;
        }

        public Arbitro(string nome, int tipoArbitro, int idade, int nacionalidade) : base(nome)
        {
            this.tipoArbitro = tipoArbitro;
            this.idade = idade;
            this.nacionalidade = nacionalidade;
        }
        #endregion

        #region PROPRIEDADES
        public int TipoArbitro
        {
            get { return tipoArbitro; }
            set { tipoArbitro = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
        #endregion

        #region OUTROS
        #endregion

        #endregion
    }
}

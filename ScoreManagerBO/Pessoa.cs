using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerBO
{
    public abstract class Pessoa : IPessoa
    {
        #region ESTADO
        int id;
        string nome;

        static int incrementaId = 0;
        #endregion

        #region METODOS

        #region CONTRUTORES        
        /// <summary>
        /// Initializes a new instance of the <see cref="Pessoa"/> class.
        /// </summary>
        public Pessoa()
        {
            incrementaId++;
            id = incrementaId;
            nome = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pessoa"/> class.
        /// </summary>
        /// <param name="nome">The nome.</param>
        public Pessoa(string nome)
        {
            incrementaId++;
            id = incrementaId;
            this.nome = nome;
        }
        #endregion

        #region PROPRIEDADES        
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Gets or sets the nome.
        /// </summary>
        /// <value>
        /// O nome.
        /// </value>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region OUTROS
        #endregion

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagerBO
{
    public class Enumerados
    {
        /// <summary>
        /// Lista de posições possiveis para os jogadores em campo
        /// </summary>
        public enum Posicoes { GuardaRedes = 1, Defesa, Medio, Atacante, Default = 99 };

        /// <summary>
        /// Lista de equipas possíveis
        /// </summary>
        public enum Equipas { Visitado = 1, Visitante, Arbitragem, Default = 99 };

        /// <summary>
        /// Tipos de Arbitro
        /// </summary>
        public enum Arbitro { Principal = 1, FiscalLinha, Assistente, Baliza, Default = 99 };

        /// <summary>
        /// Lista de paises
        /// </summary>
        public enum Nacionalidade { Portugal = 1, Espanha, Alemanha, Inglaterra, Marroquino };

        public enum Codigos { Sucesso = 1, Erro, FicheiroJaExiste, PastaJaExiste, FormatoInvalido, ListaCheia, NaoEncontrado = 404 };
    }
}

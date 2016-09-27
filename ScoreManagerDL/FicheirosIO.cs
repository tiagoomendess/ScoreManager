using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoreManagerBO;

namespace ScoreManagerDL
{
    /// <summary>
    /// A classe Utils possui vários métodos que escreve nos ficheiros de texto
    /// </summary>
    public class FicheirosIO
    {

        /// <summary>
        /// Cria as pastas Default para o programa funcionar
        /// </summary>
        /// <returns></returns>
        public static int CriaPastas()
        {
            try
            {
                Directory.CreateDirectory(Definicoes.PastaLogs);
                Directory.CreateDirectory(Definicoes.PastaTextos);

            }
            catch (Exception)
            {
                //Duvida
                return (int)Enumerados.Codigos.Erro;
            }

            return (int)Enumerados.Codigos.Sucesso;
        }

        /// <summary>
        /// Cria um ficheiro txt se nao existir
        /// </summary>
        /// <param name="caminho">Caminho para o ficheiro</param>
        /// <returns>Ver enumerado Codigos</returns>
        public static int CriaTxt(string caminho)
        {
            if (!File.Exists(caminho))
            {
                CriaPastas(); //Ter a certeza que as pastas estão criadas
                StreamWriter sw = new StreamWriter(caminho);
                sw.Write("");
                sw.Close();
                return (int)Enumerados.Codigos.Sucesso;
            }
            else
            {
                return (int)Enumerados.Codigos.FicheiroJaExiste;
            }
        }

        /// <summary>
        /// Escreve texto no ficheiro, apaga o que lá estiver e escreve por cima
        /// </summary>
        /// <param name="caminho">O caminho desejado com a extensao txt</param>
        /// <param name="texto">O texto a ser escrito</param>
        /// <returns></returns>
        public static int EscreveNoTxt(string caminho, string texto)
        {
            //Para maximizar performance, nao testo se o ficheiro existe, pois se houver algum problema,
            //lanço uma excepção
            try
            {
                File.WriteAllText(caminho, string.Empty);//Limpa o ficheiro
                StreamWriter ficheiro = File.AppendText(caminho);
                ficheiro.Write(texto);
                ficheiro.Close();
            }
            catch (Exception e)
            {
                throw new Exceptions.CantWriteToTxt("Nao foi possivel escrever no ficheiro", e);
            }

            return (int)Enumerados.Codigos.Sucesso;
        }

        /// <summary>
        /// Escreve texto numa nova linha num ficheiro txt
        /// </summary>
        /// <param name="caminho">O caminho do ficheiro ja com a extenção</param>
        /// <param name="texto">O texto a ser escrito</param>
        /// <returns>1 se escrever no ficheiro</returns>
        public static int AddLinhaNoTxt(string caminho, string texto)
        {
            try
            {
                StreamWriter ficheiro = File.AppendText(caminho);
                ficheiro.WriteLine(texto);
                ficheiro.Close();
            }
            catch (Exception e)
            {
                throw new Exceptions.CantWriteToTxt("Nao foi possivel escrever no ficheiro", e); ;
            }
            
            //Retorna o valor inteiro do sucesso
            return (int)Enumerados.Codigos.Sucesso;
        }
    }
}

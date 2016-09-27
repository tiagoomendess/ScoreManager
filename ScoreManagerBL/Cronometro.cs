using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ScoreManagerBL
{
    /// <summary>
    /// Um conometro conta os segundos que recebe a ordem de começo
    /// </summary>
    public static class Cronometro
    {

        #region ESTADO
        static TimeSpan atrasa = new TimeSpan(0, 0, 0);
        static Stopwatch cronometro = new Stopwatch();
        static int segundosTotal = 0;
        static Thread thread = new Thread(AtualizaFicheiro);
        #endregion

        #region METODOS

        #region CONTRUTORES
        #endregion

        #region PROPRIEDADES
        public static int SegundosTotal
        {
            get { return segundosTotal; }
        }
        #endregion

        #region OUTROS
        static void AtualizaFicheiro()
        {
            while (true)
            {
                segundosTotal = atrasa.Seconds + (int)cronometro.Elapsed.TotalSeconds;
                ScoreManagerDL.FicheirosIO.EscreveNoTxt(ScoreManagerDL.Definicoes.PastaTextos + "/" + ScoreManagerDL.Definicoes.NomeTxtCronometro + ".txt", Formata());
            }
        }

        /// <summary>
        /// Inicia o cronometro
        /// </summary>
        public static void Start()
        {
            cronometro.Start();
            thread.Start();
        }

        /// <summary>
        /// Para o cronometro
        /// </summary>
        public static void Stop()
        {
            cronometro.Stop();
            thread.Interrupt();
        }

        /// <summary>
        /// Reinicia o cronometro a 0
        /// </summary>
        public static void Reset()
        {
            cronometro.Reset();
            SetAtraso(0,0,0);
        }

        /// <summary>
        /// Coloca o conometro a 0, mas nao para de correr
        /// </summary>
        public static void Restart()
        {
            Reset();
            Start();
        }

        /// <summary>
        /// kjnl
        /// </summary>
        /// <param name="h"></param>
        /// <param name="m"></param>
        /// <param name="s"></param>
        public static void SetAtraso(int h, int m, int s)
        {
            atrasa.Subtract(atrasa.Duration());
            atrasa.Add(new TimeSpan(h,m,s));
        }

        /// <summary>
        /// Verifica se o cronometro esta a correr
        /// </summary>
        /// <returns>Verdadeiro se estiver e falso se nao estiver</returns>
        public static bool IsRunning()
        {
            return cronometro.IsRunning;
        }

        /// <summary>
        /// Formata o tick no formato do cronometro.
        /// </summary>
        /// <returns>A string formatada</returns>
        public static string Formata()
        {
            string formatado = "";
            int min, seg = 0;

            min = segundosTotal / 60;
            seg = segundosTotal % 60;
            formatado = min.ToString("00") + ":" + seg.ToString("00");
            return formatado;
        }
        #endregion

        #endregion

    }
}

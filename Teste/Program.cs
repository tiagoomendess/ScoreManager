using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ScoreManagerBO;
using System.Collections;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            //var th = new Thread(ScoreManagerBL.Cronometro.Inicializa);
            //th.Start();
            //Console.ReadKey();
            //ScoreManagerBL.Cronometro.Start();
            //Console.WriteLine(ScoreManagerBL.Cronometro.Tick);

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine(ScoreManagerBL.Cronometro.Formata());
            //    Thread.Sleep(500);
            //}
            //Console.ReadKey();
            //Console.WriteLine(ScoreManagerBL.Cronometro.Tick);
            //string a = Console.ReadLine();
            //ScoreManagerBL.Cronometro.Stop();
            //Console.WriteLine(ScoreManagerBL.Cronometro.Tick);
            //Console.ReadKey();
            //Console.WriteLine(ScoreManagerBL.Cronometro.Tick);

            //Console.ReadKey();

            //ScoreManagerBL.Cronometro.Start();

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine(ScoreManagerBL.Cronometro.Formata());
            //    Console.WriteLine(ScoreManagerBL.Cronometro.SegundosTotal);
            //    Thread.Sleep(50);
            //}

            Jogador a = new Jogador(10, "Tiago", (int)Enumerados.Posicoes.Defesa, (int)Enumerados.Equipas.Visitado);
            Jogador b = new Jogador(11, "Manel", (int)Enumerados.Posicoes.Atacante, (int)Enumerados.Equipas.Visitante);
            Jogador c = null;
            Jogador f = null;
            Jogador d = new Jogador(10, "Maria", (int)Enumerados.Posicoes.Defesa, (int)Enumerados.Equipas.Visitado);

            if (f != c)
            {
                Console.WriteLine("Sao iguais");
            }
            else
            {
                Console.WriteLine("Sao diferentes");
            }

            Console.Read();

        }
    }
}

using System;
using tabuleiro;
using xadrez;

namespace xadrez_console{

    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

             try
              {
               /*   Tabuleiro tab = new Tabuleiro(8, 8);

                  tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                  tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 3));
                  tab.colocarPeca(new Torre(tab, Cor.), new Posicao(1, 3));
                  tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                  tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 5));

                  Tela.imprimirTabuleiro(tab);
              */

                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimirTabuleiro(partida.tab);

                while (partida.terminada == false)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
                }
              catch (TabuleiroException e) {
                  Console.WriteLine(e.Message);
              }

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
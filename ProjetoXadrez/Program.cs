using System;
using tabuleiro;
using Xadrez;
namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] possicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, possicoesPossiveis);


                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                 Tela.imprimirTabuleiro(partida.tab);
               
            }
            catch (TabException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

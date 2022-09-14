﻿using System;
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
                /* Tabuleiro tab = new Tabuleiro(8, 8);

                 tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                 tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                 tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                 Tela.imprimirTabuleiro(tab);
                */

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());
            }
            catch (TabException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

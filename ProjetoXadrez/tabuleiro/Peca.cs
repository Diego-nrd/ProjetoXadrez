using System;

namespace tabuleiro
{
    class Peca 
    {
        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca()
        {

        }
        public Peca(Posicao posicao, Cor cor, int qteMovimentos, Tabuleiro tab)
        {
            Posicao = posicao;
            this.cor = cor;
            this.qteMovimentos = qteMovimentos;
            this.tab = tab;
        }
    }
}

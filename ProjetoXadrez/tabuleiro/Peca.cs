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
        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }

        public void incrementarQtdMovimentos()
        {
            qteMovimentos++;
        }
    }
}

using tabuleiro;
namespace Xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null || p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca)
            {
                pos.definiValores(Posicao.Linha - 1, Posicao.Coluna);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definiValores(Posicao.Linha - 2, Posicao.Coluna);
                if (tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definiValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.definiValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {
                if (cor == Cor.Preta)
                {
                    pos.definiValores(Posicao.Linha + 1, Posicao.Coluna);
                    if (tab.posicaoValida(pos) && livre(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }

                    pos.definiValores(Posicao.Linha + 2, Posicao.Coluna);
                    if (tab.posicaoValida(pos) && livre(pos) && qteMovimentos == 0)
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }

                    pos.definiValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                    if (tab.posicaoValida(pos) && existeInimigo(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }

                    pos.definiValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                    if (tab.posicaoValida(pos) && existeInimigo(pos))
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                }

            }
            return mat;
        }
    }
}

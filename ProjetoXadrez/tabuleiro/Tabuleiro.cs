
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro()
        {

        }

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca (int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}

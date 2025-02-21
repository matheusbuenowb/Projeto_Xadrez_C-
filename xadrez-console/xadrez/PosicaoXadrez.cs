using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        
        public char coluna { get; set; }
        public int linha { get; set;}

        public PosicaoXadrez(char coluna, int linha) { 
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a'); //codigo do a = 0, codigo do  b= 1, por isso funciona
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

    }
}

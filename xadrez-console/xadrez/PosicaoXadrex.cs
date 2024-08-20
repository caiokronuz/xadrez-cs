//Classe para instanciar uma matriz usando o padrão A,B,C,... para colunas e 1-8 para linhas

using tabuleiro;

namespace xadrez{
    public class PosicaoXadrez{
        public char coluna {get; set;}
        public int linha {get; set;}

        public PosicaoXadrez(char coluna, int linha){
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao ToPosicao(){
            return new Posicao(8-linha, coluna - 'a'); //Converte do padrao letra, numero para numero, numero
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
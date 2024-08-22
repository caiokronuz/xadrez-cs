using System;
using tabuleiro;

namespace xadrez{
    class Cavalo: Peca{
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor){}

        private bool podeMover(Posicao pos){
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0,0);

            pos.definirValores(posicao.linha - 1, posicao.linha + 2);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha - 2, posicao.linha - 1);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha - 2, posicao.linha + 1);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha - 1, posicao.linha + 2);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 1, posicao.linha + 2);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 2, posicao.linha + 1);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 2, posicao.linha - 1);
            if(tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }

        public override string ToString()
        {
            return "C";
        }
    }
}
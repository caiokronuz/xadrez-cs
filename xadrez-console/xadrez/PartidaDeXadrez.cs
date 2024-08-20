//Classe que comanda a lógica da partida de xadrez

using System;
using tabuleiro;

namespace xadrez{
    class PartidaDeXadrez{
        public Tabuleiro tab {get; private set;}
        public int turno {get; private set;}
        public  Cor jogadorAtual {get; private set;}
        public bool terminada {get; private set;}

        /*
            A classe deve iniciar tudo que a partida precisa para começar ou seja:  
            - Um tabuleiro 8x8
            - Contagem de turnos
            - O jogador atual (quem vai fazer a jogada)
            - se a partida terminou (para controlar o while)
            - As peças iniciais
        */
        public PartidaDeXadrez(){
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        /*
            Função que faz a movimentação das peças, ela faz a parte generica (move a peça de lugar e 
            retira a que estava no local salvando-a como peça capturada) as regras de movimentação são 
            definidas nas classes de peças
        */
        public void executaMovimento(Posicao origem, Posicao destino){
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCaputrada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino){
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        private void mudaJogador(){
            if(jogadorAtual == Cor.Branca){
                jogadorAtual = Cor.Preta;
            }else{
                jogadorAtual = Cor.Branca;
            }
        }

        private void colocarPecas(){

            //PEOES
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('a',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('b',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('c',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('d',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('e',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('f',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('g',2).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branca), new PosicaoXadrez('h',2).ToPosicao());

            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('a',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('b',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('c',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('d',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('e',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('f',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('g',7).ToPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preta), new PosicaoXadrez('h',7).ToPosicao());

            //TORRES
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a',1).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h',1).ToPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a',8).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h',8).ToPosicao());

            //REIS
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('e',1).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('e',8).ToPosicao());
        }
    }
}
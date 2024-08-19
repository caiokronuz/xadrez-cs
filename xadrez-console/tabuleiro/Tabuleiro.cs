//Classe que controla o Tabuleiro e a lógica de verificação das peças

using System;

namespace tabuleiro{
    class Tabuleiro{
        public int linhas {get; set;}
        public int colunas {get; set;}
        public Peca[,] pecas; //Matriz de peças

        public Tabuleiro(int linhas, int colunas){
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas]; //Instancia uma matriz de peças do mesmo tamanho do tabuleiro
        }

        public Peca peca(int linha, int coluna){
            return pecas[linha, coluna]; //Retorna a peça que esta na posição linha, coluna
        }

        public Peca peca(Posicao pos){
            return peca(pos.linha, pos.coluna); //Retorna a peça a partir da classe Posicao
        }

        public void colocarPeca(Peca p, Posicao pos){

            if(existePeca(pos)){
                throw new TabuleiroException("Já existe uma peça na posição escolhida");
            }

            pecas[pos.linha, pos.coluna] = p; // Coloca uma peça "p" na posição linha,coluna da matriz pecas
            p.posicao = pos; //Define a posição da peça "p" como "pos"
        }

        public bool posicaoValida(Posicao pos){
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas){ //Verifica se a posição declarada é válida
                return false;
            }

            return true;
        }

        public void validarPosicao(Posicao pos){
            if(!posicaoValida(pos)){
                throw new TabuleiroException("Posição inválida!"); //Manda um erro caso a posição não seja válida
            }
        }

        public bool existePeca(Posicao pos){
            validarPosicao(pos);
            return peca(pos) != null; //Testa se existe uma peça na posição pos ou não
        }

        
    }
}
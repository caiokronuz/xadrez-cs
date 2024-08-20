using System;
using tabuleiro;
using xadrez;

namespace xadrez_console{
    class Program{
        static void Main (string[] args){
            try{

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada){
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(origem, destino);
                }

            }catch(TabuleiroException e){
                Console.WriteLine("Erro: "+ e.Message);
            }
        }
    }
}
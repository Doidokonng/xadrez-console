using tabuleiro;
using xadrez_console;
using xadrez;

Tabuleiro tab = new Tabuleiro(8, 8);


tab.ColacarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 0));

Tela.ImprimirTabuleiro(tab);

Console.ReadLine();


using tabuleiro;
using xadrez_console;
using xadrez;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);


    tab.ColacarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 0));
    tab.ColacarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.ColacarPeca(new Bispo(tab, Cor.Branca), new Posicao(5, 4));


    Tela.ImprimirTabuleiro(tab);

    Console.ReadLine();
}

catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}


using tabuleiro;
using xadrez_console;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);
        
        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

        bool[,] posicoesPosssiveis = partida.Tab.peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab, posicoesPosssiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutarMovimento(origem, destino);

    }
}

catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}


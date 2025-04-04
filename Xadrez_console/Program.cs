using xadrez_console.Tabuleiro;
using Xadrez_console;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;
try {
    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.Terminada) { 

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);
        
        Console.WriteLine();

        Console.Write("Origem: ");
        Posicao Origem = Tela.lerPosicaoXadrez().toPosicao();

        bool[,] posicoesPossiveis = partida.tab.peca(Origem).movimentosPossiveis();

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

        Console.WriteLine();
        Console.Write("Destino: ");
        Posicao Destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executarMovimento(Origem, Destino);

    }
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
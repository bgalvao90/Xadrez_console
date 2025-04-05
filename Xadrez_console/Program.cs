using xadrez_console.Tabuleiro;
using Xadrez_console;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;
try
{
    PartidaXadrez partida = new PartidaXadrez();

    while (!partida.terminada)
    {

        try
        {
            Console.Clear();
            Tela.imprimirPartida(partida);
            Console.Write("Origem: ");
            Posicao Origem = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoOrigem(Origem);

            bool[,] posicoesPossiveis = partida.tab.peca(Origem).movimentosPossiveis();

            Console.Clear();
            Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao Destino = Tela.lerPosicaoXadrez().toPosicao();
            partida.validarPosicaoDestino(Origem, Destino);


            partida.realizaJogada(Origem, Destino);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
        Console.Clear();
        Tela.imprimirPartida(partida);
    }
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
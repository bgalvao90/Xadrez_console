using xadrez_console.Tabuleiro;
using Xadrez_console;
using Xadrez_console.tabuleiro;
using Xadrez_console.xadrez;
try { 
Tabuleiro tab = new Tabuleiro(8, 8);

tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 3));
tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));


Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
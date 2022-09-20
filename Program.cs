// See https://aka.ms/new-console-template for more information

using TicTacToe;


new JogoDaVelha().Iniciar();

bool reiniciarJogo = true;

Console.WriteLine("Deseja refazer? <S> <N>");
string resp = Console.ReadLine();
if (resp == "S")
{
    Console.Clear();
    new JogoDaVelha().Iniciar();
}
else
{
    reiniciarJogo = false;

}



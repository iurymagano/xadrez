using tabuleiro;
using xadrez.tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.WriteLine(tab);
        }
    }
}
using GameAF;

class Program
{
    static void Main(string[] args)
    {
        GameRunner gr = new GameRunner();
        IMap jungle = new Jungle();
        gr.Play(jungle);

    }
}
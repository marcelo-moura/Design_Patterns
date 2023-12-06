namespace DesignPatterns.Adapter.Libs
{
    public class Mp3Player
    {
        private string File = "";

        public Mp3Player()
        {
        }

        public Mp3Player(string file)
        {
            File = file;
        }

        public void Run()
        {
            Console.WriteLine($"Executando arquivo Mp3: {File}");
        }
    }
}

namespace DesignPatterns.Singleton
{
    public class LogSingleton
    {
        public static LogSingleton Instancia;

        private LogSingleton()
        {
        }

        public static LogSingleton GetInstancia
        {
            get
            {
                if (Instancia is null)
                    Instancia = new();

                return Instancia;
            }
        }

        public void Write(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}

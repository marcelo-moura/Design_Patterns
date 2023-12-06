// CONVERTER A INTERFACE DE UMA CLASSE EM OUTRA INTERFACE, ESPERADA PELO CLIENTE.  
// O ADAPTER PERMITE QUE INTERFACES INCOMPATIVEIS TRABALHEM EM CONJUNTO - O QUE DE OUTRA FORMA, SERIA IMPOSSIVEL.

using DesignPatterns.Adapter.Adapters;

Console.WriteLine("Informe o arquivo de midia que deseja executar: ");
string file = Console.ReadLine();

var file_parte = file.Split('.'); //file://musica.mp3

IPlayer player;

switch (file_parte[1])
{
    case "mp3":
        player = new Mp3PlayerAdapter();
        player.Play(file);
        break;
    case "mp4":
        player = new Mp4PlayerAdapter();
        player.Play(file);
        break;
    default:
        Console.WriteLine("Arquivo de midia incompativel");
        break;
}

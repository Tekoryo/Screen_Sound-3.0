using  ScreenSoud.Modelos;
using  ScreenSoud.Menus;
using ScreenSound.Menus;

Banda Linkin_Park = new Banda("Linkin Park");

Linkin_Park.AdicionarNota(new Avaliacao(10));
Linkin_Park.AdicionarNota(new Avaliacao(8));
Linkin_Park.AdicionarNota(new Avaliacao(6));
Banda The_Beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
bandasRegistradas.Add("Linkin Park",Linkin_Park);
bandasRegistradas.Add("The Beatles",The_Beatles);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MenuRegistrarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostrarBandasRegistradas menu3 = new();
            menu3.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            MenuAvaliarBandas menu4 = new();
            menu4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            MenusExibirDetalhes menu5 = new();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 0:
            MenuSair menu0 = new();
            menu0.Executar();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();

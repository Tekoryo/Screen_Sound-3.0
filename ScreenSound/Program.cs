using  ScreenSoud.Modelos;
using  ScreenSoud.Menus;
using ScreenSound.Menus;

Banda Linkin_Park = new Banda("Linkin Park");

Linkin_Park.AdicionarNota(new Avaliacao(10));
Linkin_Park.AdicionarNota(new Avaliacao(8));
Linkin_Park.AdicionarNota(new Avaliacao(6));
Banda The_Beatles = new Banda("The Beatles");
Banda U2 = new Banda("U2");
U2.AdicionarNota(new Avaliacao(10));
U2.AdicionarNota(new Avaliacao(8));
U2.AdicionarNota(new Avaliacao(8));
U2.AdicionarNota(new Avaliacao(9));
U2.AdicionarNota(new Avaliacao(6));
U2.AdicionarNota(new Avaliacao(3));
U2.AdicionarNota(new Avaliacao(10));


Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
bandasRegistradas.Add("Linkin Park",Linkin_Park);
bandasRegistradas.Add("The Beatles",The_Beatles);
bandasRegistradas.Add("U2", U2);
U2.AdicionarAlbum(new Album("test1"));

U2.AdicionarAlbum(new Album("test2"));

Dictionary<int,Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBandas());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenusExibirDetalhes());
opcoes.Add(0, new MenuSair());
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
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();


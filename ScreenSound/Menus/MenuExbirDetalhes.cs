using ScreenSoud.Modelos;
using ScreenSound.Menus;

namespace ScreenSoud.Menus;

internal class MenusExibirDetalhes : Menu
{
    
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media.ToString("F")}.");
            Console.WriteLine($"\nDiscografia: ");
            foreach (Album albuns in banda.Albuns)
            {
                Console.WriteLine($"\n {albuns.Nome} -> {albuns.Media.ToString("F")}.");
            }

            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
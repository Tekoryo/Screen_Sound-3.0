using OpenAI_API;
using ScreenSoud.Modelos;
using ScreenSound.Menus;
using OpenAI_API;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var client = new OpenAIAPI("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");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda}! em 1 parágrafo. Adote um estilo informal.");

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult() ;
        banda.Resumo = resposta;
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}

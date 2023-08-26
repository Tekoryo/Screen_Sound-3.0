using ScreenSoud.Modelos;
using ScreenSound.Menus;
namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
        Thread.Sleep(2000);
        base.Executar(bandasRegistradas);
    }
}

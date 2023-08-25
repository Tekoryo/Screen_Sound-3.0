using ScreenSoud.Modelos;
using ScreenSound.Menus;
namespace ScreenSound.Menus;

internal class MenuSair
{
    public void Executar()
    {
        Console.WriteLine("Tchau tchau :)");
        Thread.Sleep(2000);
        Console.Clear();
    }
}

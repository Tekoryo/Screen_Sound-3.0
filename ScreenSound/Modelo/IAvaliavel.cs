using ScreenSoud.Modelos;

namespace ScreenSound.Modelo
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media { get; }
    }
}

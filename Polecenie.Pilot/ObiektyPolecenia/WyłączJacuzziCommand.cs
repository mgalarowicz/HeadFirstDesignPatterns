using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WyłączJacuzziCommand : ICommand
    {
        private readonly Jacuzzi _jacuzzi;

        public WyłączJacuzziCommand(Jacuzzi jacuzzi)
        {
            _jacuzzi = jacuzzi;
        }

        public void Execute()
        {
            _jacuzzi.Wyłącz();
        }

        public void Undo()
        {
            _jacuzzi.Włącz();
        }
    }
}

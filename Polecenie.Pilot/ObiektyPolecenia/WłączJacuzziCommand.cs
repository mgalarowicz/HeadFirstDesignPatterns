using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WłączJacuzziCommand : ICommand
    {
        private readonly Jacuzzi _jacuzzi;

        public WłączJacuzziCommand(Jacuzzi tv) => _jacuzzi = tv;

        public void Execute()
        {
            _jacuzzi.Włącz();
        }

        public void Undo()
        {
            _jacuzzi.Wyłącz();
        }
    }
}

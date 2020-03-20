using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WyłączTVCommand : ICommand
    {
        private readonly TV _tv;

        public WyłączTVCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Wyłącz();
        }

        public void Undo()
        {
            _tv.Włącz();
        }
    }
}

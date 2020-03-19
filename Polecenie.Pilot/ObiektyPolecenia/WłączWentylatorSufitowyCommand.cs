using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WłączWentylatorSufitowyCommand : ICommand
    {
        private readonly WentylatorSufitowy _wentylatorSufitowy;

        public WłączWentylatorSufitowyCommand(WentylatorSufitowy wentylatorSufitowy)
        {
            _wentylatorSufitowy = wentylatorSufitowy;
        }

        public void Execute()
        {
            _wentylatorSufitowy.WysokieObroty();
            _wentylatorSufitowy.PobierzPrędkość();
        }
    }
}

﻿using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WłączWentylatorSufitowyWolnoCommand : ICommand
    {
        private Obroty _previousSpeed;

        private readonly WentylatorSufitowy _wentylatorSufitowy;

        public WłączWentylatorSufitowyWolnoCommand(WentylatorSufitowy wentylatorSufitowy)
        {
            _wentylatorSufitowy = wentylatorSufitowy;
        }

        public void Execute()
        {
            _previousSpeed = _wentylatorSufitowy.PobierzPrędkość();
            _wentylatorSufitowy.NiskieObroty();
        }

        public void Undo()
        {
            switch (_previousSpeed)
            {
                case Obroty.Wysokie:
                    _wentylatorSufitowy.WysokieObroty();
                    break;
                case Obroty.Średnie:
                    _wentylatorSufitowy.ŚrednieObroty();
                    break;
                case Obroty.Niskie:
                    _wentylatorSufitowy.NiskieObroty();
                    break;
                default:
                    _wentylatorSufitowy.Wyłącz();
                    break;
            }
        }
    }
}

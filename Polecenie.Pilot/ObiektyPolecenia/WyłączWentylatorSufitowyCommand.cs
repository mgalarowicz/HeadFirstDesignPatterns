﻿using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyRealizujace;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class WyłączWentylatorSufitowyCommand : ICommand
    {
        private readonly WentylatorSufitowy _wentylatorSufitowy;
        private Obroty _previousSpeed;

        public WyłączWentylatorSufitowyCommand(WentylatorSufitowy wentylatorSufitowy)
        {
            _wentylatorSufitowy = wentylatorSufitowy;
        }

        public void Execute()
        {
            _previousSpeed = _wentylatorSufitowy.PobierzPrędkość();
            _wentylatorSufitowy.Wyłącz();
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

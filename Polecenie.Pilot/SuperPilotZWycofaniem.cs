using System;
using System.Collections.Generic;
using System.Text;
using Polecenie.Pilot.ObiektyPolecenia;

namespace Polecenie.Pilot
{
    public class SuperPilotZWycofaniem
    {
        private readonly ICommand[] _włączCommands;
        private readonly ICommand[] _wyłączCommands;
        private ICommand _undoCommand;

        public SuperPilotZWycofaniem()
        {
            _włączCommands = new ICommand[7];
            _wyłączCommands = new ICommand[7];

            ICommand emptyCommand = new EmptyCommand();

            for (int i = 0; i < 7; i++)
            {
                _włączCommands[i] = emptyCommand;
                _wyłączCommands[i] = emptyCommand;
            }

            _undoCommand = emptyCommand;
        }

        public void UstawPolecenie(int slot, ICommand włączCommand, ICommand wyłączCommand)
        {
            _włączCommands[slot] = włączCommand;
            _wyłączCommands[slot] = wyłączCommand;
        }

        public void WciśniętoPrzyciskWłącz(int slot)
        {
            _włączCommands[slot].Execute();
            _undoCommand = _włączCommands[slot];
        }

        public void WciśniętoPrzyciskWyłącz(int slot)
        {
            _wyłączCommands[slot].Execute();
            _undoCommand = _wyłączCommands[slot];
        }

        public void WciśniętoPrzyciskWycofaj()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\n----- Super Pilot -----\n");

            for (int i = 0; i < _włączCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] {_włączCommands[i].GetType()} : {_wyłączCommands[i].GetType()} \n");
            }

            stringBuilder.Append($"[undo] {_undoCommand.GetType()} \n");

            return stringBuilder.ToString();
        }
    }
}

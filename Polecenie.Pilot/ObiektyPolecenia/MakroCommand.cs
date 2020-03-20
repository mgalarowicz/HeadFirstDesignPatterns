using System;

namespace Polecenie.Pilot.ObiektyPolecenia
{
    public class MakroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MakroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].Undo();
            }
        }
    }
}

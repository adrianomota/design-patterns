using Command.Core.Contract;
using System.Collections.Generic;

namespace Command.Core.Core
{
    public class SimpleRemoteControl
    {
        private readonly IList<ICommand> _onCommands;
        private readonly IList<ICommand> _offCommands;
        private ICommand _noCommand;

        public SimpleRemoteControl(IList<ICommand> onCommands, IList<ICommand> offCommands, ICommand noCommand)
        {
            _onCommands = onCommands;
            _offCommands = offCommands;
            _noCommand = noCommand;

            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = _noCommand;
                _offCommands[i] = _noCommand;
            }

        }

        public void SetCommand(int slot, ICommand onCommand_, ICommand offCommand_)
        {
            _onCommands[slot].Execute();
            _offCommands[slot].Execute();    
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Execute();
            _noCommand = _onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            _onCommands[slot].Execute();
            _noCommand = _offCommands[slot];
        }

    }
}
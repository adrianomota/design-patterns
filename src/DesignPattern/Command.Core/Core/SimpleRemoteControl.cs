using Command.Core.Contract;
using System.Collections.Generic;

namespace Command.Core.Core
{
    public class SimpleRemoteControl
    {
        private readonly IList<ICommand> _onCommands;
        private readonly IList<ICommand> _offCommands;
        private ICommand _noCommand;

        public SimpleRemoteControl(IList<ICommand> onCommands_, IList<ICommand> offCommands_, ICommand noCommand_)
        {
            _onCommands = onCommands_;
            _offCommands = offCommands_;
            _noCommand = noCommand_;

            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = _noCommand;
                _offCommands[i] = _noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand_, ICommand offCommand_)
        {
            _onCommands[slot] = onCommand_;
            _offCommands[slot] = offCommand_;
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Execute();
            _noCommand = _onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Execute();
            _noCommand = _offCommands[slot];
        }
    }
}
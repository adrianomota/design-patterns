using Command.Core.Contract;

namespace Command.Core.Commands
{
    public sealed class LightOffCommand : ICommand
    {
        private readonly ILight _light;

        public LightOffCommand(ILight light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
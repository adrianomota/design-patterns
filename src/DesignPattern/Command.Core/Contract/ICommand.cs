using System.Security.Cryptography.X509Certificates;

namespace Command.Core.Contract
{
    public interface ICommand
    {
        void Execute();
    }
}
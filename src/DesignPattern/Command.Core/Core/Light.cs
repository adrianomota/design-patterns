using Command.Core.Contract;
using System;
using System.Diagnostics;

namespace Command.Core.Core
{
    public sealed class Light : ILight
    {
        public void On()
        {
            Debug.WriteLine("Ligando a luz!");
        }

        public void Off()
        {
            Debug.WriteLine("Desligando a luz!");
        }
    }
}
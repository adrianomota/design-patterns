using Command.Core.Commands;
using Command.Core.Contract;
using Command.Core.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Command.Test
{
    [TestClass]
    public class SimpleRemoteControlTest
    {
        [TestMethod]
        public void Quando_eu_pressionar_o_botao_de_ligar()
        {
            //arrange
            var simpleRemoteControl = new SimpleRemoteControl(new List<ICommand>(7)
            {
                new LightOnCommand(new Light()),
                new NoCommand(),
                new NoCommand(),
                new NoCommand(),
                new NoCommand(),
                new NoCommand(),
                new NoCommand()
            },
            new List<ICommand>(7)
            {
               new LightOffCommand(new Light()),
               new NoCommand(),
               new NoCommand(),
               new NoCommand(),
               new NoCommand(),
               new NoCommand(),
               new NoCommand()
            },
               new NoCommand());
            //action

            simpleRemoteControl.SetCommand(0, new LightOnCommand(new Light()), new LightOffCommand(new Light()));

            simpleRemoteControl.OnButtonWasPressed(0);
            simpleRemoteControl.OffButtonWasPressed(0);
        }
    }
}
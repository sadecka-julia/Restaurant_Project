using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRestaurant
{
    class OrderService
    {
        private List<ICommand> commands = new List<ICommand>();
        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void MakeCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
            commands.Clear();
        }

    }
}
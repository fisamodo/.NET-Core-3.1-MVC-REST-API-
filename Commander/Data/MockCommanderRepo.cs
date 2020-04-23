using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil", Line="Boil", Platform="Kettle"},
                new Command{Id=1, HowTo="Cut", Line="On Desk", Platform="Board"},
                new Command{Id=2, HowTo="Dinst", Line="Kapula", Platform="Tava"}
            };

            return commands;
        }
        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil", Line="Boil", Platform="Kettle"};
        }
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext context;
        public SqlCommandAPIRepo(CommandContext _context)
        {
            context=_context;
        }
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }        
        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Command> GetAllCommands()
        {
           return this.context.CommandsItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            
           return this.context.CommandsItems.FirstOrDefault(x=> x.Id ==id);
        }
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
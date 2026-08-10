using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }

        public async Task CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public async Task<Command> GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id.Equals(id));
        }

        public async Task<bool> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
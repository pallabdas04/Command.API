using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        Task<bool> SaveChanges();
        Task<IEnumerable<Command>> GetAllCommands();
        Task<Command> GetCommandById(int id);
        Task CreateCommand(Command cmd);
        Task UpdateCommand(Command cmd);
        Task DeleteCommand(Command cmd);
    }
}
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
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
            var commands = new List<Command>
            {
                new() {
                    Id = 0,
                    HowTo = "How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform = ".Net Core EF"
                },
                new()
                {
                    Id = 1,
                    HowTo = "Run a Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform = ".Net Core EF"
                },
                new()
                {
                    Id = 2,
                    HowTo = "List active Migrations",
                    CommandLine = "dotnet ef migrations list",
                    Platform = ".Net Core EF"
                }
            };

            return commands;
        }

        public async Task<Command> GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "How to generate a migration",
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                Platform = ".Net Core EF"
            };
        }

        public Task<bool> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
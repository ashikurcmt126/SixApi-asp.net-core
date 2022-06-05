using System;
using SixApi.Models;

namespace SixApi.Data
{
	public interface ICommandRepo
	{
        Task SaveChanges();

        Task<IEnumerable<Command>> GetAllCommands();
        Task<Command?> GetCommandById(int id);
        Task CreateCommand(Command cmd);

        void DeleteCommand(Command cmd);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        CommandContext _database;

        public SqlCommandAPIRepo(CommandContext database)
        {
            _database = database;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _database.CommandItems.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _database.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _database.CommandItems.FirstOrDefault(e => e.Id == id);
        }

        public bool SaveChanges()
        {
           return (_database.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command cmd)
        {
            
        }
    }
}
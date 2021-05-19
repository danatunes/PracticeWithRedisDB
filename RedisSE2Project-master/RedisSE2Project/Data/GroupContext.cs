using RedisSE2Project.Data.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSE2Project.Data
{
    public class GroupContext : IGroupContext
    {
        private readonly ConnectionMultiplexer _connection;

        public GroupContext(ConnectionMultiplexer connection)
        {
            _connection = connection;
            Redis = _connection.GetDatabase();
        }

        public IDatabase Redis { get; }
    }
}

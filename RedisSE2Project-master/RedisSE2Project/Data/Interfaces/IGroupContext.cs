using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSE2Project.Data.Interfaces
{
    public interface IGroupContext
    {
        IDatabase Redis { get; }
    }
}

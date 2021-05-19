using RedisSE2Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisSE2Project.Repositories.Interfaces
{
    public interface IGroupRepository
    {
        Task<Group> GetGroup(string name);
        Task<Group> UpdateGroup(Group group);
        Task<bool> DeleteGroup(string name);
    }
}

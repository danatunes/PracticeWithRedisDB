using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedisSE2Project.Entities;
using RedisSE2Project.Repositories.Interfaces;

namespace RedisSE2Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _repository;

        public GroupController(IGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Group), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Group>> GetGroup(string name)
        {
            var group = await _repository.GetGroup(name);
            return Ok(group ?? new Group(name));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Group), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Group>> UpdateGroup(Group group)
        {
            var updatedGroup = await _repository.UpdateGroup(group);
            return Ok(updatedGroup);
        }

        [HttpDelete("{name}")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> DeleteGroup(string name)
        {
            return Ok(await _repository.DeleteGroup(name));
        }
    }
}

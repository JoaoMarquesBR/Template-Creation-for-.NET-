using Contracts.Requests;
using Domain.Entities;
using Domain.IServices;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/TEMPLATE_ENTITY_CLASS")]
    public class TEMPLATE_CONTROLLER : ControllerBase
    {
        private readonly TEMPLATE_ENTITY_SERVICE_INTERFACE<TEMPLATE_ENTITY_CLASS> TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION;
        private readonly IMapper _mapper;

        public TEMPLATE_CONTROLLER(TEMPLATE_ENTITY_SERVICE_INTERFACE<TEMPLATE_ENTITY_CLASS> TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION_CONSTRUCTOR, IMapper mapper)
        {
            TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION = TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION_CONSTRUCTOR;
            _mapper = mapper;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(TEMPLATE_REGISTRATION_REQUEST req)
        {
            TEMPLATE_ENTITY_CLASS command = _mapper.Map<TEMPLATE_ENTITY_CLASS>(req);
            await TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION.Add(command);
            return Ok(command);
        }

        [HttpGet("All")]
        public async Task<IEnumerable<TEMPLATE_ENTITY_CLASS>> GetAll()
        {
            return await TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION.GetAll();
        }

        [HttpDelete("DeleteById")]
        public async Task DeleteUserById(int id)
        {
            await TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION.Delete(id);
        }

        [HttpPut("Update")]
        public async Task Update(int id, TEMPLATE_ENTITY_CLASS user)
        {
            await TEMPLATE_ENTITY_SERVICE_INTERFACE_IMPLEMENTATION.Update(id,user);
        }
    }
}

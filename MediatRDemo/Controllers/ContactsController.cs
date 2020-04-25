using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MediatRDemo.ContactsController;

namespace MediatRDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ContactsController : ControllerBase
    {
        private IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Contact> GetContact([FromRoute]GetContatsFilter getContatsFilter)
        {
            return await _mediator.Send<Contact>(getContatsFilter).ConfigureAwait(false);
        }
    }
}
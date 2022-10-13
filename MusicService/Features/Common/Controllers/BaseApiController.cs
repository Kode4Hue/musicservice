﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MusicService.Features.Common.Controllers
{

    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        protected readonly ISender Mediator;

        protected BaseApiController(ISender mediator)
        {
            Mediator = mediator;
        }
    }
}
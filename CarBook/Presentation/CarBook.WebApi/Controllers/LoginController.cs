﻿using CarBook.Application.Features.Mediator.Queries.AppUserQuries;
using CarBook.Application.Tools;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly IMediator _mediator;

		public LoginController(IMediator mediator)
		{
			_mediator = mediator;
		}
		[HttpPost]
		public async Task<IActionResult>Index(GetCheckAppUserQuery query)
		{
			var values = _mediator.Send(query);
			if (values.IsCompleted)
			{ 
				return Created("", JwtTokenGenerator.GenerateToken(values));
			}
			else
			{
				return BadRequest("Kullanıcı adı ve şifre hatalıdır");
			}
		}
	}
}

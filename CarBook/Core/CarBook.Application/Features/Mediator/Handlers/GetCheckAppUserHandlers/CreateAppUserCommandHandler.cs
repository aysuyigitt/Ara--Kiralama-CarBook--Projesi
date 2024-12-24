using CarBook.Application.Enums;
using CarBook.Application.Features.Mediator.Commands.RegisterCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.GetCheckAppUserHandlers
{
	public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
	{
		private readonly IRepository<AppUser> _appUserRepository;

		public CreateAppUserCommandHandler(IRepository<AppUser> appUserRepository)
		{
			_appUserRepository = appUserRepository;
		}

		public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
		{
			await _appUserRepository.CreateAsync(new AppUser
			{
				Password = request.Password,
				Name = request.UserName,
				AppRoleId = (int)RolesType.Member,
				Email = request.Email,	
				Namee=request.Namee,	
				Surname = request.Surname,	
			});
		}
	}
}

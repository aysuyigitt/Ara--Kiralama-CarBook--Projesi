﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.RegisterCommands
{
	public class CreateAppUserCommand:IRequest
	{
		public string UserName {  get; set; }	
		public string Password { get; set; }
        public string Namee { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}

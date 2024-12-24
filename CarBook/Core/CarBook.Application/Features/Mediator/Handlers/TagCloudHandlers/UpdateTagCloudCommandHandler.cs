﻿using CarBook.Application.Features.Mediator.Commands.TagCloudCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateServiceCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values= await _repository.GetByIdAsync(request.TagCloudID);
            values.Title = request.Title;
            values.BlogID=request.BlogID;   
            await _repository.UpdateAsync(values);
            

        }
    }
}

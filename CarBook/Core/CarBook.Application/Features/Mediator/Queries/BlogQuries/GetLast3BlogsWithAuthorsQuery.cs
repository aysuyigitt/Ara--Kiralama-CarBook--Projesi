﻿using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.BlogQuries
{
    public class GetLast3BlogsWithAuthorsQuery:IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
    }
}

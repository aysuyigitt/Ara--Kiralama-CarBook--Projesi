﻿using CarBook.Application.Features.Mediator.Results.PricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.PricingQuries
{
    public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
    {

    }
}

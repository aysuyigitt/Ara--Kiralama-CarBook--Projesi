﻿using CarBook.Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.FeatureQuries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {

    }
}

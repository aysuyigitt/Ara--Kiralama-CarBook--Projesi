﻿using CarBook.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialQuries
{
	public class GetTestimonialQuery:IRequest<List<GetTestimonialQueryResult>>
	{
	}
}

﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Application.Features.Companies.Queries.GetAllCompanyQuery
{
    public sealed record GetAllCompanyQuery : IRequest<GetAllCompanyQueryResponse>;
}

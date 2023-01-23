﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo.Application.Features.Companies.Commands.CreateCompany
{
    public sealed record CreateCompanyCommand(
        string CompanyName,
        TimeSpan OrderStartTime,
        TimeSpan OrderFinishTime
    ) : IRequest<CreateCompanyCommandResponse>;
}
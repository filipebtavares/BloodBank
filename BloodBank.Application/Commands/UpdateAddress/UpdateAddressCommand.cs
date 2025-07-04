﻿using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.UpdateAddress
{
    public  class UpdateAddressCommand : IRequest<ResultViewModel>
    {
        public int IdAddress { get; set; }
        public string PublicPlace { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Cep { get; set; }
    }
}

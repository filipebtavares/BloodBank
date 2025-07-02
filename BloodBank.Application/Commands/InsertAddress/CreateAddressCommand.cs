using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.InsertAddress
{
    public class CreateAddressCommand : IRequest<ResultViewModel<int>>
    {
        public string PublicPlace { get;set; }
        public string City { get;set; }
        public string State { get;set; }
        public string Cep { get;set; }

        public Address ToEntity()
            => new(PublicPlace, City, Cep, State);


    }
}

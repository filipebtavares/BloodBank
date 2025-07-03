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
        public string Cep { get; set; }
        public int IdDonor { get; set; }

        public CreateAddressCommand(string cep, int idDonor)
        {
            Cep = cep;
            IdDonor = idDonor;
        }
    }
}

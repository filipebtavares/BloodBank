using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.DeleteDonation
{
    public class DeleteDonationCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }

        public DeleteDonationCommand(int id)
        {
            Id = id;
        }
    }
}

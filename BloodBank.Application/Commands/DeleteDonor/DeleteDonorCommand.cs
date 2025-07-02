using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.DeleteDonor
{
    public class DeleteDonorCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }

        public DeleteDonorCommand(int id)
        {
            Id = id;
        }
    }
}

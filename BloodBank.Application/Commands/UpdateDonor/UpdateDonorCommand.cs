using BloodBank.Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.UpdateDonor
{
    public class UpdateDonorCommand : IRequest<ResultViewModel>
    {
        public int IdDonor { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Genre { get; set; }
        public double Weight { get; set; }
        public string BloodType { get; set; }
    }
}

using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Application.Commands.InsertDonor
{
    public class CreateDonorCommand : IRequest<ResultViewModel<int>>
    {
        public string FullName { get;   set; }
        public string Email { get;   set; }
        public DateTime BirthDate { get;   set; }
        public string Genre { get;   set; }
        public double Weight { get;   set; }
        public string BloodType { get;   set; }

        public Donor ToEntity()
              => new(FullName, Genre, Email, BirthDate, BloodType, Weight);
    }
}

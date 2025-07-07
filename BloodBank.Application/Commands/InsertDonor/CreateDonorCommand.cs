using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using MediatR;


namespace BloodBank.Application.Commands.InsertDonor
{
    public class CreateDonorCommand : IRequest<ResultViewModel<int>>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Genre { get; set; }
        public double Weight { get; set; }
        public string RhFactor { get; set; }
        public string BloodType { get; set; }

        public string Cep { get; set; }
        
    }
}

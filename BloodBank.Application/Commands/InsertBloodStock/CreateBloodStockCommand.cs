using BloodBank.Application.Model;
using BloodBank.Core.Entities;
using MediatR;


namespace BloodBank.Application.Commands.InsertBloodStock
{
    public class CreateBloodStockCommand : IRequest<ResultViewModel<int>>
    {
        public string BloodType { get;   set; }
        public string RhFactor { get;   set; }
        public int QuantityML { get;   set; }
        public int IdDonation { get;   set; }

        public BloodStock ToEntity()
            => new(BloodType, RhFactor, QuantityML, IdDonation);
    }
}

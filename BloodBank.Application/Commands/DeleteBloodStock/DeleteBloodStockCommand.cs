using BloodBank.Application.Model;
using MediatR;


namespace BloodBank.Application.Commands.DeleteBloodStock
{
    public  class DeleteBloodStockCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }

        public DeleteBloodStockCommand(int id)
        {
            Id = id;
        }
    }
}

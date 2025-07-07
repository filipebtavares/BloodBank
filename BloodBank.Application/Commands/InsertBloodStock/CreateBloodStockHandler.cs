using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;
 

namespace BloodBank.Application.Commands.InsertBloodStock
{
    public class CreateBloodStockHandler : IRequestHandler<CreateBloodStockCommand, ResultViewModel<int>>
    {

        private readonly IBloodStockRepository _repository;

        public CreateBloodStockHandler(IBloodStockRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<int>> Handle(CreateBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodStock = request.ToEntity();

            await _repository.PostBloodStock(bloodStock);

            return ResultViewModel<int>.Sucess(bloodStock.Id);
        }
    }
}

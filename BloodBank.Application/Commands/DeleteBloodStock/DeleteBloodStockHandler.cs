using BloodBank.Application.Model;
using BloodBank.Core.Respositories;
using MediatR;

namespace BloodBank.Application.Commands.DeleteBloodStock
{
    public class DeleteBloodStockHandler : IRequestHandler<DeleteBloodStockCommand, ResultViewModel>
    {
        private readonly IBloodStockRepository _repository;

        public DeleteBloodStockHandler(IBloodStockRepository repository)
        {
            _repository = repository;
        }
        public async  Task<ResultViewModel> Handle(DeleteBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodStock = await _repository.GetBloodStockById(request.Id);

            if(bloodStock is null)
            {
                return ResultViewModel.Error("This Blood Stock does not exist.");
            }

            bloodStock.SetAsDeleted();
            await _repository.UpdateBloodStock(bloodStock);

            return ResultViewModel.Sucess();
        }
    }
}
